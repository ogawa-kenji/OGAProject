Imports System.Windows.Forms.DataVisualization.Charting
Imports OGA.BI
Imports OGA.BL

Public Class GCForm
    Private targets As New List(Of ターゲット)
    Private dispCode As Decimal = 0
    Private goldencross As New List(Of ゴールデンクロス)

    Private Sub GCForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim golden As New BL.GoldenCrossBL
        goldencross = golden.Selectゴールデンクロス()
        Me.dgvゴールデンクロス.AutoGenerateColumns = False
        Me.dgvゴールデンクロス.DataSource = (From g In goldencross Order By g.日付 Descending Select g).Take(10).ToList()



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

        chartPrice.Series.Add(seriesPoint)

        Dim area = New ChartArea("株価")

        chartPrice.ChartAreas.Add(area)

        Me.dtp開始.Value = CDate("2010/01/01")
        Me.dtp終了.Value = Now.Date

        Dim companybl As New BL.CompanyBL
        Dim companies = companybl.Select企業情報()
        Me.dgv企業情報.AutoGenerateColumns = False
        Me.dgv企業情報.DataSource = companies

        Dim targetbl As New BL.TargetBL
        targets = targetbl.Getターゲット


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
        Dim dpGolden As DataPoint
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
            Dim q = (From g In goldencross
                     Where g.証券コード = r.証券コード And g.日付 = r.日付
                     Select g).FirstOrDefault

            If q IsNot Nothing Then
                dpGolden = New DataPoint
                dpGolden.SetValueXY(q.日付, q.調整後終値)
                dpGolden.Label = "GC"
                Me.chartPrice.Series(4).Points.Add(dpGolden)
            End If


        Next

    End Sub

    Private Sub chartPrice_Click(sender As Object, e As EventArgs) Handles chartPrice.Click

    End Sub

    Private Sub dgv企業情報_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellContentClick

    End Sub

    Private Sub dgv企業情報_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellClick

    End Sub

    Private Sub dgv企業情報_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellEnter
        If e.RowIndex <> -1 Then
            Dim companies As List(Of 企業情報) = CType(Me.dgv企業情報.DataSource, List(Of 企業情報))
            dispCode = companies(e.RowIndex).証券コード
            DisplayChart(dispCode)
        End If
    End Sub

    Private Sub dgv企業情報_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellLeave

    End Sub
End Class