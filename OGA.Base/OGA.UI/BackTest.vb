Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.FileIO
Imports OGA.BI
Imports OGA.BL

Public Class BackTest
    Private Sub BackTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parser = New TextFieldParser(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "StockCodeList.txt"))
        parser.TextFieldType = FieldType.Delimited
        parser.SetDelimiters(",")
        parser.HasFieldsEnclosedInQuotes = False
        parser.TrimWhiteSpace = False

        Dim codes As New List(Of Decimal)
        While Not parser.EndOfData
            Dim row As String() = parser.ReadFields()
            codes.Add(Convert.ToDecimal(row(0)))
        End While

        Dim bl As New StockPriceBL
        For Each code In codes
            Await Task.Run(
                Sub()
                    Dim buySell As New OGA.Utility.BuyAndSell1(bl.SelectBackTest(code))
                    buySell.Calc()
                    Me.Invoke(
                        Sub()
                            Me.TextBox2.Text = Me.TextBox2.Text & code & " " & buySell.現金 & Environment.NewLine
                            Me.TextBox2.ScrollToCaret()
                        End Sub
                    )
                End Sub
           )
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bl As New StockPriceBL
        Dim buySell As New OGA.Utility.BuyAndSell1(bl.SelectBackTest(5721))
        buySell.Calc()
        Me.TextBox2.Text = buySell.履歴.ToString()
    End Sub
End Class