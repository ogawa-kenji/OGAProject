Imports System.Windows.Forms.DataVisualization.Charting
Imports OGA.BI
Imports OGA.BL

Public Class ChartForm

    Private targets As New List(Of ターゲット)
    Private dispCode As Decimal = 0

    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim seriesLine As New Series()
        seriesLine.ChartType = SeriesChartType.Line        '' 折れ線のグラフ
        seriesLine.BorderWidth = 2
        seriesLine.XValueType = ChartValueType.Date        '' X軸は日付
        seriesLine.YValueType = ChartValueType.Int64
        seriesLine.IsVisibleInLegend = False

        chartPrice.Series.Add(seriesLine)

        Dim area = New ChartArea()

        chartPrice.ChartAreas.Add(area)


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        chartPrice.Series(0).Points.Clear()

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

        Dim pricebl As New PriceBL
        Dim prices As List(Of 株価)
        prices = pricebl.Select株価(dispCode)

        Dim dp As DataPoint
        For Each r In prices
            dp = New DataPoint
            dp.SetValueXY(r.日付, r.調整後終値)
            Me.chartPrice.Series(0).Points.Add(dp)
        Next

        If prices.Count > 0 Then
            Me.TextBox1.Text = String.Format("{0} {1}", prices(0).証券コード, prices(0).企業名)
        Else
            Me.TextBox1.Text = dispCode.ToString()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        chartPrice.Series(0).Points.Clear()

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

        Dim pricebl As New PriceBL
        Dim prices As List(Of 株価)
        prices = pricebl.Select株価(dispCode)

        Dim dp As DataPoint
        For Each r In prices
            dp = New DataPoint
            dp.SetValueXY(r.日付, r.調整後終値)
            Me.chartPrice.Series(0).Points.Add(dp)
        Next

        If prices.Count > 0 Then
            Me.TextBox1.Text = String.Format("{0} {1}", prices(0).証券コード, prices(0).企業名)
        Else
            Me.TextBox1.Text = dispCode.ToString()
        End If
    End Sub

    Private Sub DisplayChar(証券コード As Decimal)
        chartPrice.Series(0).Points.Clear()
        Dim pricebl As New PriceBL
        Dim prices As List(Of 株価)
        prices = pricebl.Select株価(証券コード)
        Dim dp As DataPoint
        For Each r In prices
            dp = New DataPoint
            dp.SetValueXY(r.日付, r.調整後終値)
            Me.chartPrice.Series(0).Points.Add(dp)
        Next
        If prices.Count > 0 Then
            Me.TextBox1.Text = String.Format("{0} {1}", prices(0).証券コード, prices(0).企業名)
        Else
            Me.TextBox1.Text = 証券コード.ToString()
        End If
    End Sub

    Private Sub dgv企業情報_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellContentClick

    End Sub

    Private Sub dgv企業情報_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv企業情報.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            Dim companies As List(Of 企業情報) = CType(Me.dgv企業情報.DataSource, List(Of 企業情報))
            DisplayChar(companies(e.RowIndex).証券コード)
        End If
    End Sub
End Class