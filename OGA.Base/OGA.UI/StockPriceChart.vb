Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.FileIO
Imports OGA.BI
Imports OGA.BL

Public Class StockPriceChart

    Private targets As New List(Of ターゲット)
    Private dispCode As Decimal = 0
    Private csvList As New List(Of StockPriceList)

    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtp開始.Value = CDate("2010/01/01")
        Me.dtp終了.Value = Now.Date

        ConfigChart()

        Dim parser = New TextFieldParser(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "StockCodeList.txt"))
        parser.TextFieldType = FieldType.Delimited
        parser.SetDelimiters(",")
        parser.HasFieldsEnclosedInQuotes = False
        parser.TrimWhiteSpace = False

        'Dim codes As New BindingList(Of StockPriceList)
        While Not parser.EndOfData
            Dim row As String() = parser.ReadFields()
            Dim p As New StockPriceList
            p.証券コード = Convert.ToDecimal(row(0))
            p.企業名 = row(1)
            csvList.Add(p)
        End While

        Me.BindingSource.DataSource = csvList

        Me.dgvList.AutoGenerateColumns = False
        Me.dgvList.DataSource = Me.BindingSource

        'Dim targetbl As New BL.TargetBL
        'targets = targetbl.Getターゲット


        ''' チャート設定の初期化
        ''' Series(系列)、Titles(タイトル)、ChatAreas(チャートエリア)、Legends(凡例)
        'chartPrice.Series.Clear()
        'chartPrice.Legends.Clear()
        'chartPrice.ChartAreas.Clear()
        'chartPrice.Titles.Clear()

        'Dim title = New Title("株価")
        'chartPrice.Titles.Add(title)

        'Dim seriesLine As New Series()
        'seriesLine.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        'seriesLine.BorderWidth = 2
        'seriesLine.XValueType = ChartValueType.Date        '' X軸は日付
        'seriesLine.YValueType = ChartValueType.Int64
        'seriesLine.IsVisibleInLegend = False

        'chartPrice.Series.Add(seriesLine)

        'Dim seriesColumn As New Series()
        'seriesColumn.ChartArea = "出来高"
        'seriesColumn.ChartType = SeriesChartType.Column
        'seriesColumn.BorderWidth = 2
        'seriesColumn.XValueType = ChartValueType.Date        '' X軸は日付
        'seriesColumn.YValueType = ChartValueType.Int64
        'seriesColumn.IsVisibleInLegend = False

        'chartPrice.Series.Add(seriesColumn)



        'Dim seriesAverage5 As New Series()
        'seriesAverage5.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        'seriesAverage5.BorderWidth = 1
        'seriesAverage5.XValueType = ChartValueType.Date        '' X軸は日付
        'seriesAverage5.YValueType = ChartValueType.Int64
        'seriesAverage5.Color = Color.Green
        'seriesAverage5.IsVisibleInLegend = False

        'chartPrice.Series.Add(seriesAverage5)

        'Dim seriesAverage25 As New Series()
        'seriesAverage25.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        'seriesAverage25.BorderWidth = 1
        'seriesAverage25.XValueType = ChartValueType.Date        '' X軸は日付
        'seriesAverage25.YValueType = ChartValueType.Int64
        'seriesAverage25.Color = Color.Orange
        'seriesAverage25.IsVisibleInLegend = False

        'chartPrice.Series.Add(seriesAverage25)

        'Dim seriesAverage75 As New Series()
        'seriesAverage75.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        'seriesAverage75.BorderWidth = 1
        'seriesAverage75.XValueType = ChartValueType.Date        '' X軸は日付
        'seriesAverage75.YValueType = ChartValueType.Int64
        'seriesAverage75.Color = Color.Red
        'seriesAverage75.IsVisibleInLegend = False

        'chartPrice.Series.Add(seriesAverage75)


        'Dim area = New ChartArea("株価")
        'area.AxisX.IsLabelAutoFit = False
        'area.AxisX.IsMarginVisible = False

        'chartPrice.ChartAreas.Add(area)

        'Dim areaColumn = New ChartArea("出来高")
        ''' Y軸を合わせる処置
        'areaColumn.AlignWithChartArea = "株価"
        'areaColumn.AxisX.IsMarginVisible = False
        'areaColumn.AxisY.IsMarginVisible = False
        'areaColumn.AxisY.MajorGrid.Enabled = True
        'areaColumn.Axes(0).IsLabelAutoFit = False
        'areaColumn.Axes(0).Enabled = AxisEnabled.False
        'areaColumn.IsSameFontSizeForAllAxes = False



        ''areaColumn.AxisY.ValueToPosition(10)
        ''areaColumn.AxisX.IsLabelAutoFit = False
        ''areaColumn.AxisX.MaximumAutoSize = 20
        'chartPrice.ChartAreas.Add(areaColumn)







    End Sub

    Public Sub ConfigChart()
        '' チャート設定の初期化
        '' Series(系列)、Titles(タイトル)、ChatAreas(チャートエリア)、Legends(凡例)
        chartPrice.Series.Clear()
        chartPrice.Legends.Clear()
        chartPrice.ChartAreas.Clear()
        chartPrice.Titles.Clear()

        '' Titles
        Dim title = New Title("株価")
        chartPrice.Titles.Add(title)

        'チャートエリア
        chartPrice.ChartAreas.Add(GetChartArea("price"))
        chartPrice.ChartAreas.Add(GetChartArea("rate"))
        chartPrice.ChartAreas.Add(GetChartArea("volume"))

        ' 上下の軸合わせ
        chartPrice.ChartAreas("volume").AlignWithChartArea = "price"
        chartPrice.ChartAreas("volume").AlignmentStyle = AreaAlignmentStyles.PlotPosition

        chartPrice.ChartAreas("rate").AlignWithChartArea = "price"
        chartPrice.ChartAreas("rate").AlignmentStyle = AreaAlignmentStyles.PlotPosition


        chartPrice.ChartAreas("price").Position.Height = 65
        chartPrice.ChartAreas("price").Position.Width = 95
        chartPrice.ChartAreas("price").Position.Y = 5

        'chartPrice.ChartAreas("volume").Position.Auto = False
        chartPrice.ChartAreas("volume").Position.Height = 10
        chartPrice.ChartAreas("volume").Position.Width = 95
        chartPrice.ChartAreas("volume").Position.Y = 90

        chartPrice.ChartAreas("rate").Position.Height = 20
        chartPrice.ChartAreas("rate").Position.Width = 95
        chartPrice.ChartAreas("rate").Position.Y = 70


        '' Series
        '株価
        chartPrice.Series.Add(GetLineSeries("price", "price", 2, Color.Black))
        '移動平均
        chartPrice.Series.Add(GetLineSeries("avg5", "price", 1, Color.Green))
        chartPrice.Series.Add(GetLineSeries("avg25", "price", 1, Color.Orange))
        chartPrice.Series.Add(GetLineSeries("avg75", "price", 1, Color.Red))
        chartPrice.Series.Add(GetLineSeries("avg200", "price", 1, Color.Blue))
        '乖離率
        chartPrice.Series.Add(GetLineSeries("rate5", "rate", 1, Color.Green))
        chartPrice.Series.Add(GetLineSeries("rate25", "rate", 1, Color.Orange))
        chartPrice.Series.Add(GetLineSeries("rate75", "rate", 1, Color.Red))
        chartPrice.Series.Add(GetLineSeries("rate200", "rate", 1, Color.Blue))
        '出来高
        chartPrice.Series.Add(GetColumnSeries("volume", "volume", 2, Color.Black))

        chartPrice.Series.Add(GetPointSeries("point", "price", 3, Color.OrangeRed))




    End Sub

    Public Function GetLineSeries(name As String, chartArea As String, width As Integer, color As Color) As Series
        Dim series As New Series
        series.Name = name
        series.ChartArea = chartArea
        series.ChartType = SeriesChartType.Line
        series.BorderWidth = width
        series.XValueType = ChartValueType.Date
        series.YValueType = ChartValueType.Int64
        series.IsVisibleInLegend = False
        series.Color = color
        Return series
    End Function

    Public Function GetColumnSeries(name As String, chartArea As String, width As Integer, color As Color) As Series
        Dim series As New Series
        series.Name = name
        series.ChartArea = chartArea
        series.ChartType = SeriesChartType.Column
        series.BorderWidth = width
        series.XValueType = ChartValueType.Date
        series.YValueType = ChartValueType.Int64
        series.IsVisibleInLegend = False
        series.Color = color
        Return series
    End Function

    Public Function GetPointSeries(name As String, chartArea As String, width As Integer, color As Color) As Series
        Dim series As New Series
        series.Name = name
        series.ChartArea = chartArea
        series.ChartType = SeriesChartType.Point
        series.BorderWidth = width
        series.XValueType = ChartValueType.Date
        series.YValueType = ChartValueType.Int64
        series.IsVisibleInLegend = False
        series.Color = color
        Return series
    End Function

    Public Function GetChartArea(name As String) As ChartArea
        Dim area As New ChartArea
        area.Name = name
        area.AxisX.IsLabelAutoFit = False
        area.AxisX.IsMarginVisible = False
        area.AxisX.IsMarginVisible = False
        area.AxisY.IsMarginVisible = False
        area.AxisY.MajorGrid.Enabled = True
        area.Axes(0).IsLabelAutoFit = False
        area.Axes(0).Enabled = AxisEnabled.False
        area.IsSameFontSizeForAllAxes = False
        Return area
    End Function



    Private Sub DisplayChart(証券コード As Decimal)
        For Each s In chartPrice.Series
            s.Points.Clear()
        Next
        Dim bl As New StockPriceBL
        Dim prices As List(Of StockPriceBI)
        prices = bl.SelectBackTest(証券コード)

        prices = (From p In prices
                  Where Me.dtp開始.Value.Date <= p.日付 AndAlso p.日付 <= dtp終了.Value.Date
                  Select p).ToList()

        If prices.Count = 0 Then
            Return
        End If
        Dim dp As DataPoint
        Dim dpCol As DataPoint
        Dim dpAvg5 As DataPoint
        Dim dpAvg25 As DataPoint
        Dim dpAvg75 As DataPoint

        Dim xMin As Decimal = prices.Min(Function(d) d.調整後終値)
        Dim xMax As Decimal = prices.Max(Function(d) d.調整後終値)

        If xMax < prices.Max(Function(d) d.移動平均5) Then
            xMax = Convert.ToDecimal(prices.Max(Function(d) d.移動平均5))
        End If
        If xMax < prices.Max(Function(d) d.移動平均25) Then
            xMax = Convert.ToDecimal(prices.Max(Function(d) d.移動平均25))
        End If
        If xMax < prices.Max(Function(d) d.移動平均75) Then
            xMax = Convert.ToDecimal(prices.Max(Function(d) d.移動平均75))
        End If
        If xMax < prices.Max(Function(d) d.移動平均200) Then
            xMax = Convert.ToDecimal(prices.Max(Function(d) d.移動平均200))
        End If

        If xMin > prices.Min(Function(d) d.移動平均5) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均5))
        End If
        If xMin > prices.Min(Function(d) d.移動平均25) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均25))
        End If
        If xMin > prices.Min(Function(d) d.移動平均75) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均75))
        End If
        If xMin > prices.Min(Function(d) d.移動平均200) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均200))
        End If

        '' 上下5％の空きを作る
        Me.chartPrice.ChartAreas(0).AxisY.Maximum = xMax * 1.05
        Me.chartPrice.ChartAreas(0).AxisY.Minimum = xMin * 0.95

        For Each r In prices
            '' 折れ線グラフのポイントを設定
            'dp = New DataPoint
            'dp.SetValueXY(r.日付, r.調整後終値)
            'Me.chartPrice.Series("price").Points.Add(dp)
            ChartSetValue(r.日付, r.調整後終値, "price")

            If r.移動平均5乖離率 <= -0.1 AndAlso r.移動平均75乖離率 <= -0.3 AndAlso r.移動平均200乖離率 <= -0.3 Then
                ChartSetPoint(r.日付, r.調整後終値, "point")
            End If

            '移動平均
            If Me.chk5.Checked Then
                ChartSetValue(r.日付, r.移動平均5, "avg5")
            End If
            If Me.chk25.Checked Then
                ChartSetValue(r.日付, r.移動平均25, "avg25")
            End If
            If Me.chk75.Checked Then
                ChartSetValue(r.日付, r.移動平均75, "avg75")
            End If
            If Me.chk200.Checked Then
                ChartSetValue(r.日付, r.移動平均200, "avg200")
            End If

            '乖離率
            If Me.chk5.Checked Then
                ChartSetValue(r.日付, r.移動平均5乖離率 * 100, "rate5")
            End If
            If Me.chk25.Checked Then
                ChartSetValue(r.日付, r.移動平均25乖離率 * 100, "rate25")
            End If
            If Me.chk75.Checked Then
                ChartSetValue(r.日付, r.移動平均75乖離率 * 100, "rate75")
            End If
            If Me.chk200.Checked Then
                ChartSetValue(r.日付, r.移動平均200乖離率 * 100, "rate200")
            End If

            '出来高
            ChartSetValue(r.日付, r.出来高, "volume")

            ''' 移動平均5
            'If r.移動平均5.HasValue Then
            '    dpAvg5 = New DataPoint
            '    dpAvg5.SetValueXY(r.日付, r.移動平均5)
            '    Me.chartPrice.Series(2).Points.Add(dpAvg5)
            'End If

            ''' 移動平均25
            'If r.移動平均25.HasValue Then
            '    dpAvg25 = New DataPoint
            '    dpAvg25.SetValueXY(r.日付, r.移動平均25)
            '    Me.chartPrice.Series(3).Points.Add(dpAvg25)
            'End If

            ''' 移動平均75
            'If r.移動平均75.HasValue Then
            '    dpAvg75 = New DataPoint
            '    dpAvg75.SetValueXY(r.日付, r.移動平均75)
            '    Me.chartPrice.Series(4).Points.Add(dpAvg75)
            'End If

            '' 移動平均 直近15日の終値の平均
            'Dim q = (From p In prices
            '         Where p.日付 <= r.日付
            '         Order By p.日付 Descending
            '         Select p).Take(75)

            'If q.Count = 75 Then
            '    dpAvg = New DataPoint
            '    dpAvg.SetValueXY(r.日付, q.Average(Function(d) d.移動平均75))
            '    Me.chartPrice.Series(2).Points.Add(dpAvg)
            'End If

            'dpCol = New DataPoint
            'dpCol.SetValueXY(r.日付, r.出来高)
            'Me.chartPrice.Series(1).Points.Add(dpCol)
        Next

    End Sub

    Private Sub ChartSetValue(d As Date, v As Double?, name As String)
        Dim dp = New DataPoint
        dp.SetValueXY(d, v)
        Try
            Me.chartPrice.Series(name).Points.Add(dp)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ChartSetPoint(d As Date, v As Double?, name As String)
        Dim dp = New DataPoint
        dp.BorderWidth = 4
        dp.Color = Color.OrangeRed
        dp.SetValueXY(d, v)
        Try
            Me.chartPrice.Series(name).Points.Add(dp)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim filtered As List(Of StockPriceList)
        filtered = (From t In csvList
                    Where t.証券コード.ToString.Contains(Me.txtFilter.Text) OrElse t.企業名.ToString.Contains(Me.txtFilter.Text)
                    Select t).ToList()

        Me.dgvList.DataSource = filtered
    End Sub
    Private Sub dgvList_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellEnter
        If e.RowIndex = -1 Then
            Return
        End If
        Debug.WriteLine(Me.dgvList.Item(0, e.RowIndex).Value)
        If dispCode <> Convert.ToDecimal(Me.dgvList.Item(0, e.RowIndex).Value) Then
            dispCode = Convert.ToDecimal(Me.dgvList.Item(0, e.RowIndex).Value)
            DisplayChart(dispCode)
        Else
            Return
        End If
    End Sub

    Private Sub Chk5_CheckedChanged(sender As Object, e As EventArgs) Handles chk5.CheckedChanged, chk25.CheckedChanged, chk75.CheckedChanged, chk200.CheckedChanged
        DisplayChart(dispCode)
    End Sub

    Private Sub BtnOneYear_Click(sender As Object, e As EventArgs) Handles btnOneYear.Click
        Me.dtp終了.Value = Now.Date
        Me.dtp開始.Value = Now.Date.AddYears(-1)
        Me.DisplayChart(dispCode)
    End Sub
    Private Sub BtnThreeYear_Click(sender As Object, e As EventArgs) Handles btnThreeYear.Click
        Me.dtp終了.Value = Now.Date
        Me.dtp開始.Value = Now.Date.AddYears(-3)
        Me.DisplayChart(dispCode)
    End Sub
    Private Sub BtnFiveYear_Click(sender As Object, e As EventArgs) Handles btnFiveYear.Click
        Me.dtp終了.Value = Now.Date
        Me.dtp開始.Value = Now.Date.AddYears(-5)
        Me.DisplayChart(dispCode)
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim bl As New StockPriceBL
        Dim filter As List(Of StockPriceBI)
        filter = bl.SelectFilter()
        Dim filterList = (From p In filter
                          Where Me.dtp開始.Value.Date <= p.日付 AndAlso p.日付 <= dtp終了.Value.Date
                          Select p.証券コード).Distinct().ToList()

        Dim filtered As List(Of StockPriceList)
        filtered = (From t In csvList
                    Join u In filterList
                            On t.証券コード Equals u
                    Select t).ToList()

        Me.dgvList.DataSource = filtered

    End Sub
End Class