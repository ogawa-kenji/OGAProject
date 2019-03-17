Imports System.Windows.Forms.DataVisualization.Charting
Imports OGA.BI
Imports OGA.BL

Public Class ChartForm

    Private targets As New List(Of ターゲット)
    Private dispCode As Decimal = 0

    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtp開始.Value = CDate("2010/01/01")
        Me.dtp終了.Value = Now.Date

        Dim companybl As New BL.CompanyBL
        Dim companies = companybl.Select企業情報()
        Me.dgv企業情報.AutoGenerateColumns = False
        Me.dgv企業情報.DataSource = companies

        Dim targetbl As New BL.TargetBL
        targets = targetbl.Getターゲット


        '' チャート設定の初期化
        '' Series(系列)、Titles(タイトル)、ChatAreas(チャートエリア)、Legends(凡例)
        chartPrice.Series.Clear()
        chartPrice.Legends.Clear()
        chartPrice.ChartAreas.Clear()
        chartPrice.Titles.Clear()

        Dim title = New Title("株価")
        chartPrice.Titles.Add(title)

        Dim seriesLine As New Series()
        seriesLine.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        seriesLine.BorderWidth = 2
        seriesLine.XValueType = ChartValueType.Date        '' X軸は日付
        seriesLine.YValueType = ChartValueType.Int64
        seriesLine.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesLine)

        Dim seriesColumn As New Series()
        seriesColumn.ChartArea = "出来高"
        seriesColumn.ChartType = SeriesChartType.Column
        seriesColumn.BorderWidth = 2
        seriesColumn.XValueType = ChartValueType.Date        '' X軸は日付
        seriesColumn.YValueType = ChartValueType.Int64
        seriesColumn.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesColumn)



        Dim seriesAverage5 As New Series()
        seriesAverage5.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        seriesAverage5.BorderWidth = 1
        seriesAverage5.XValueType = ChartValueType.Date        '' X軸は日付
        seriesAverage5.YValueType = ChartValueType.Int64
        seriesAverage5.Color = Color.Green
        seriesAverage5.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesAverage5)

        Dim seriesAverage25 As New Series()
        seriesAverage25.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        seriesAverage25.BorderWidth = 1
        seriesAverage25.XValueType = ChartValueType.Date        '' X軸は日付
        seriesAverage25.YValueType = ChartValueType.Int64
        seriesAverage25.Color = Color.Orange
        seriesAverage25.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesAverage25)

        Dim seriesAverage75 As New Series()
        seriesAverage75.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        seriesAverage75.BorderWidth = 1
        seriesAverage75.XValueType = ChartValueType.Date        '' X軸は日付
        seriesAverage75.YValueType = ChartValueType.Int64
        seriesAverage75.Color = Color.Red
        seriesAverage75.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesAverage75)


        Dim area = New ChartArea("株価")
        area.AxisX.IsLabelAutoFit = False
        area.AxisX.IsMarginVisible = False

        chartPrice.ChartAreas.Add(area)

        Dim areaColumn = New ChartArea("出来高")
        '' Y軸を合わせる処置
        areaColumn.AlignWithChartArea = "株価"
        areaColumn.AxisX.IsMarginVisible = False
        'areaColumn.AxisX.IsLabelAutoFit = False
        'areaColumn.AxisX.MaximumAutoSize = 20
        chartPrice.ChartAreas.Add(areaColumn)







    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        For Each s In chartPrice.Series
            s.Points.Clear()
        Next

        Dim q = From t In targets
                Where t.証券コード > dispCode
                Order By t.証券コード
                Select t

        If q.Count = 0 Then
            dispCode = 9999
            Me.TextBox1.Text = dispCode.ToString()
            Return
        End If

        dispCode = q.FirstOrDefault().証券コード
        DisplayChart(dispCode)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        For Each s In chartPrice.Series
            s.Points.Clear()
        Next

        Dim q = From t In targets
                Where t.証券コード < dispCode
                Order By t.証券コード Descending
                Select t

        If q.Count = 0 Then
            dispCode = 0
            Me.TextBox1.Text = dispCode.ToString()
            Return
        End If

        dispCode = q.FirstOrDefault().証券コード
        DisplayChart(dispCode)

    End Sub

    Private Sub DisplayChart(証券コード As Decimal)
        For Each s In chartPrice.Series
            s.Points.Clear()
        Next
        Dim pricebl As New PriceBL
        Dim prices As List(Of 移動平均)
        prices = pricebl.Select移動平均(証券コード)

        prices = (From p In prices
                  Where Me.dtp開始.Value.Date <= p.日付 AndAlso p.日付 <= dtp終了.Value.Date
                  Select p).ToList()

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

        If xMin > prices.Min(Function(d) d.移動平均5) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均5))
        End If
        If xMin > prices.Min(Function(d) d.移動平均25) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均25))
        End If
        If xMin > prices.Min(Function(d) d.移動平均75) Then
            xMin = Convert.ToDecimal(prices.Min(Function(d) d.移動平均75))
        End If

        '' 上下5％の空きを作る
        Me.chartPrice.ChartAreas(0).AxisY.Maximum = xMax * 1.05
        Me.chartPrice.ChartAreas(0).AxisY.Minimum = xMin * 0.95

        For Each r In prices
            '' 折れ線グラフのポイントを設定
            dp = New DataPoint
            dp.SetValueXY(r.日付, r.調整後終値)
            Me.chartPrice.Series(0).Points.Add(dp)

            '' 移動平均5
            If r.移動平均5.HasValue Then
                dpAvg5 = New DataPoint
                dpAvg5.SetValueXY(r.日付, r.移動平均5)
                Me.chartPrice.Series(2).Points.Add(dpAvg5)
            End If

            '' 移動平均25
            If r.移動平均25.HasValue Then
                dpAvg25 = New DataPoint
                dpAvg25.SetValueXY(r.日付, r.移動平均25)
                Me.chartPrice.Series(3).Points.Add(dpAvg25)
            End If

            '' 移動平均75
            If r.移動平均75.HasValue Then
                dpAvg75 = New DataPoint
                dpAvg75.SetValueXY(r.日付, r.移動平均75)
                Me.chartPrice.Series(4).Points.Add(dpAvg75)
            End If

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

            dpCol = New DataPoint
            dpCol.SetValueXY(r.日付, r.出来高)
            Me.chartPrice.Series(1).Points.Add(dpCol)
        Next
        If prices.Count > 0 Then
            Me.TextBox1.Text = String.Format("{0} {1}", prices(0).証券コード, prices(0).企業名)
        Else
            Me.TextBox1.Text = 証券コード.ToString()
        End If
    End Sub

    Private Sub dgv企業情報_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            Dim companies As List(Of 企業情報) = CType(Me.dgv企業情報.DataSource, List(Of 企業情報))
            dispCode = companies(e.RowIndex).証券コード
            DisplayChart(dispCode)
        End If
    End Sub


End Class