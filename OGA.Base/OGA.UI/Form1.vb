Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bl As New OGA.BL.TargetBL
        bl.CreateTable()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim util As New Utility.FinanceUtil
        util.Get企業情報(3465)
        'util.Get企業情報(9999)
        util.Get株価(3465, Now.AddDays(-50), Now)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bl As New BL.UtilityBL
        bl.Update企業情報()

    End Sub
End Class
