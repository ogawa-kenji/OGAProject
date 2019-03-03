Imports OGA.BI
Imports OGA.BL

Public Class UpdateForm
    Private Async Sub btn企業情報更新_Click(sender As Object, e As EventArgs) Handles btn企業情報更新.Click
        Dim stw As New Stopwatch
        stw.Start()
        Me.txt更新時間.Text = "企業情報更新開始"
        Me.btn企業情報更新.Enabled = False
        Try
            Await Task.Run(
            Sub()
                Dim bl As New BL.UtilityBL
                bl.Update企業情報()
            End Sub
            )

        Finally
            Me.btn企業情報更新.Enabled = True
            Me.txt更新時間.Text = "企業情報更新終了:" & stw.ElapsedMilliseconds & "ミリ秒"
            stw.Stop()
        End Try
    End Sub

    Private Async Sub btn株価更新_Click(sender As Object, e As EventArgs) Handles btn株価更新.Click
        Dim stw As New Stopwatch
        stw.Start()
        Me.txt更新時間.Text = "株価更新開始"
        Me.btn株価更新.Enabled = False
        Try
            Await Task.Run(
            Sub()
                Dim targetbl As New BL.TargetBL
                Dim companies = targetbl.Getターゲット
                Dim pricebl As New BL.PriceBL
                Dim prices As List(Of 株価)
                Dim beginDt As DateTime = DateSerial(2010, 1, 1)
                Dim endDt As DateTime = Now.Date
                Dim ut As New Utility.FinanceUtil
                Dim utBl As New UtilityBL

                For Each r In companies
                    prices = pricebl.Select株価(r.証券コード)
                    If prices.Count = 0 Then
                        beginDt = DateSerial(2010, 1, 1)
                    Else
                        beginDt = prices.Max(Function(d) d.日付).AddDays(1)
                    End If
                    utBl.Update株価(ut.Get株価(r.証券コード, beginDt, endDt))

                    Me.Invoke(
                        Sub()
                            Me.txt更新時間.Text = r.証券コード & " " & stw.ElapsedMilliseconds & "ミリ秒" & Environment.NewLine & Me.txt更新時間.Text
                        End Sub
                    )
                Next
            End Sub
            )

        Finally
            Me.btn株価更新.Enabled = True
            Me.txt更新時間.Text = "株価更新終了:" & stw.ElapsedMilliseconds & "ミリ秒" & Environment.NewLine & Me.txt更新時間.Text
            stw.Stop()
        End Try

    End Sub
End Class