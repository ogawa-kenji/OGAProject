Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.FileIO
Imports OGA.BI
Imports OGA.BL
Imports OGA.Utility

Public Class CheckForm
    Private Sub BackTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim companybl As New BL.CompanyBL
        Dim companies = companybl.Select企業情報()
        Me.dgv企業情報.AutoGenerateColumns = False
        Me.dgv企業情報.DataSource = companies


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

        Dim seriesPoint As New Series()
        seriesPoint.ChartType = SeriesChartType.Point        '' ポイント
        seriesPoint.XValueType = ChartValueType.Date        '' X軸は日付
        seriesPoint.YValueType = ChartValueType.Int64
        seriesPoint.Color = Color.DarkOrange
        'seriesPoint.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesPoint)

        Dim area = New ChartArea("株価")
        'area.AxisX.IsLabelAutoFit = False
        'area.AxisX.IsMarginVisible = False

        chartPrice.ChartAreas.Add(area)

    End Sub

    Private Sub Rule4(証券コード As Decimal, rowIdx As Integer)

        If Me.dgv企業情報.Rows(rowIdx).Cells(2).Value Is Nothing Then
            Return
        End If

        Dim pricebl As New PriceBL
        Dim prices As List(Of 移動平均)
        prices = pricebl.Select移動平均(証券コード)
        Dim beginDate As DateTime = Now.AddYears(-3).Date
        Dim endDate As DateTime = prices(prices.Count - 1).日付

        Dim condition As New ルール.ルール4
        Try
            condition.移動平均5開始増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(2).Value)
            condition.移動平均5終了増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(3).Value)
            condition.移動平均25開始増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(4).Value)
            condition.移動平均25終了増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(5).Value)
            condition.移動平均75開始増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(6).Value)
            condition.移動平均75終了増減率 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(7).Value)
            condition.売経過日数 = Convert.ToDecimal(Me.dgv企業情報.Rows(rowIdx).Cells(8).Value)
            condition.期間開始 = Convert.ToDateTime(Me.dgv企業情報.Rows(rowIdx).Cells(9).Value)
            condition.期間終了 = Convert.ToDateTime(Me.dgv企業情報.Rows(rowIdx).Cells(10).Value)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return
        End Try

        Dim rule As New Rule4(prices, condition)
        rule.Calc()

        Debug.WriteLine(String.Format("{0} 評価:{1} 現金:{2} 株数:{3} 回数:{4}",
                                          beginDate.ToString("yyyy/MM/dd"),
                                          rule.評価額,
                                          rule.現金,
                                          rule.株数,
                                          rule.売買回数))



        DisplayChart(rule.テスト結果)

    End Sub



    Private Sub dgv企業情報_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            Dim companies As List(Of 企業情報) = CType(Me.dgv企業情報.DataSource, List(Of 企業情報))
            Rule4(companies(e.RowIndex).証券コード, e.RowIndex)
        End If
    End Sub



    Private Sub DisplayChart(backTest As List(Of バックテスト))
        For Each s In chartPrice.Series
            s.Points.Clear()
        Next

        Dim dp As DataPoint
        Dim dpAvg5 As DataPoint
        Dim dpAvg25 As DataPoint
        Dim dpAvg75 As DataPoint
        Dim dpBuySell As DataPoint

        Dim q = (From t In backTest
                 Where t.調整後終値 <> 0
                 Select t).ToList()


        Dim xMin As Decimal = q.Min(Function(d) d.調整後終値)
        Dim xMax As Decimal = q.Max(Function(d) d.調整後終値)

        If xMax < q.Max(Function(d) d.移動平均5) Then
            xMax = Convert.ToDecimal(q.Max(Function(d) d.移動平均5))
        End If
        If xMax < q.Max(Function(d) d.移動平均25) Then
            xMax = Convert.ToDecimal(q.Max(Function(d) d.移動平均25))
        End If
        If xMax < q.Max(Function(d) d.移動平均75) Then
            xMax = Convert.ToDecimal(q.Max(Function(d) d.移動平均75))
        End If

        If xMin > q.Min(Function(d) d.移動平均5) Then
            xMin = Convert.ToDecimal(q.Min(Function(d) d.移動平均5))
        End If
        If xMin > q.Min(Function(d) d.移動平均25) Then
            xMin = Convert.ToDecimal(q.Min(Function(d) d.移動平均25))
        End If
        If xMin > q.Min(Function(d) d.移動平均75) Then
            xMin = Convert.ToDecimal(q.Min(Function(d) d.移動平均75))
        End If

        '' 上下5％の空きを作る
        Me.chartPrice.ChartAreas(0).AxisY.Maximum = xMax * 1.05
        Me.chartPrice.ChartAreas(0).AxisY.Minimum = xMin * 0.95

        For Each r In backTest
            '' 折れ線グラフのポイントを設定
            If r.調整後終値 = 0 Then
                Continue For
            End If

            dp = New DataPoint
            dp.SetValueXY(r.日付, r.調整後終値)
            Me.chartPrice.Series(0).Points.Add(dp)

            '' 移動平均5
            If r.移動平均5.HasValue Then
                dpAvg5 = New DataPoint
                dpAvg5.SetValueXY(r.日付, r.移動平均5)
                Me.chartPrice.Series(1).Points.Add(dpAvg5)
            End If

            '' 移動平均25
            If r.移動平均25.HasValue Then
                dpAvg25 = New DataPoint
                dpAvg25.SetValueXY(r.日付, r.移動平均25)
                Me.chartPrice.Series(2).Points.Add(dpAvg25)
            End If

            '' 移動平均75
            If r.移動平均75.HasValue Then
                dpAvg75 = New DataPoint
                dpAvg75.SetValueXY(r.日付, r.移動平均75)
                Me.chartPrice.Series(3).Points.Add(dpAvg75)
            End If

            '' 買・売ポイント
            If r.株買 Then
                dpBuySell = New DataPoint
                dpBuySell.SetValueXY(r.日付, r.調整後終値)
                dpBuySell.Label = "買"
                Me.chartPrice.Series(4).Points.Add(dpBuySell)
            End If
            If r.株売 Then
                dpBuySell = New DataPoint
                dpBuySell.SetValueXY(r.日付, r.調整後終値)
                dpBuySell.Label = "売"
                Me.chartPrice.Series(4).Points.Add(dpBuySell)
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

        Next

    End Sub


End Class