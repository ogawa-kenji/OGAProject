Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As New DataBaseAcess
        Dim stb As New System.Text.StringBuilder()
        stb.AppendLine("CREATE TABLE ターゲット ")
        stb.AppendLine("( ")
        stb.AppendLine("  証券コード NUMERIC ")
        stb.AppendLine(") ")


        db.DBExecute(stb.ToString(), Nothing)


    End Sub
End Class
