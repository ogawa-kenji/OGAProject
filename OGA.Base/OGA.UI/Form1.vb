Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.FileIO
Imports OGA.BI
Imports OGA.BL
Imports OGA.Utility

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pricebl As New PriceBL
        Dim prices As List(Of 移動平均)
        prices = pricebl.Select移動平均(1775)

        Dim beginDate As DateTime = Now.Date.AddMonths(-120)
        Dim endDate As DateTime = prices(prices.Count - 1).日付
        Dim rule As New Rule1(prices, -0.5D, 30D, beginDate, endDate)
        While beginDate <= endDate
            If rule.CheckBuyRule(beginDate) Then
                rule.Buy(beginDate)
            End If
            If rule.CheckSellRule(beginDate) Then
                rule.Sell(beginDate)
            End If
            rule.経過日数 += 1
            rule.TestAdd(beginDate)
            beginDate = beginDate.AddDays(1)
        End While

        Debug.WriteLine(String.Format("{0} 評価:{1} 現金:{2} 株数:{3}",
                                          beginDate.ToString("yyyy/MM/dd"),
                                          rule.評価額,
                                          rule.現金,
                                          rule.株数))


    End Sub

    Private Sub BaseText1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.BaseText3.ReadOnly = Not Me.BaseText3.ReadOnly
    End Sub

    Private Sub BtnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        Dim lstCsv As New List(Of CSV_BI)
        Using parser As New TextFieldParser(Me.txtCSV.Text, Encoding.GetEncoding("UTF-8"))
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")
            parser.HasFieldsEnclosedInQuotes = True
            parser.TrimWhiteSpace = False

            While Not parser.EndOfData

                Dim row As String() = parser.ReadFields()
                Dim csv As New CSV_BI
                csv.EventName = row(0)
                csv.FormName = row(1)
                csv.ControlName = row(2)
                csv.ControlText = row(3)
                lstCsv.Add(csv)

            End While

        End Using

        dgvCSV.DataSource = lstCsv


    End Sub

    Public Class CSV_BI
        Public Property EventName As String
        Public Property FormName As String
        Public Property ControlName As String
        Public Property ControlText As String
    End Class

    Private Sub BaseNumber1_TextChanged(sender As Object, e As EventArgs) Handles BaseNumber1.TextChanged

    End Sub

    Private Sub BaseNumber1_Validating(sender As Object, e As CancelEventArgs) Handles BaseNumber1.Validating
        Utility.Utility.NumberPlaces(BaseNumber1.NumValue.Value)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim util As New FinanceUtil
        Dim lst As New List(Of 株価)
        For i As Integer = 4000 To 9999
            lst = util.Get株価(i, Now.AddDays(-7), Now)
            If lst.Count > 0 Then
                Debug.WriteLine(lst(0).証券コード & " " & lst(0).企業名)
            End If
        Next

    End Sub
End Class
