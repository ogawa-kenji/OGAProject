﻿Public Class MenuForm
    Private Sub lblUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblUpdate.LinkClicked
        Dim frm As New UpdateForm
        frm.Show(Me)
    End Sub

    Private Sub lblChart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChart.LinkClicked
        Dim frm As New ChartForm
        frm.Show(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New Form1
        frm.Show(Me)
    End Sub

    Private Sub lblBackTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBackTest.LinkClicked
        Dim frm As New BackTestForm
        frm.Show(Me)
    End Sub

    Private Sub lblAleart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAleart.LinkClicked
        Dim frm As New AlertForm
        frm.Show(Me)
    End Sub
End Class