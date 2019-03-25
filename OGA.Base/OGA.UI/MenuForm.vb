Public Class MenuForm
    Private Sub lblUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblUpdate.LinkClicked
        Dim frm As New UpdateForm
        frm.Show()
    End Sub

    Private Sub lblChart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChart.LinkClicked
        Dim frm As New ChartForm
        frm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub lblBackTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBackTest.LinkClicked
        Dim frm As New BackTestForm
        frm.Show()
    End Sub

    Private Sub lblAleart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAleart.LinkClicked
        Dim frm As New AlertForm
        frm.Show()
    End Sub

    Private Sub lblGoldenCross_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoldenCross.LinkClicked
        Dim frm As New GCForm
        frm.Show()
    End Sub
End Class