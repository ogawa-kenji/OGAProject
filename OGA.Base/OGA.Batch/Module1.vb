Imports System.Text
Imports Microsoft.VisualBasic.FileIO
Imports OGA.BI
Imports OGA.BL
Imports OGA.Utility
Imports System.IO

Module Module1

    Sub Main()
        Dim bl As New StockPriceBL
        bl.CreateTable()

        UpdateStockPrice()


        Console.ReadLine()
    End Sub

    Private Async Function UpdateStockPrice() As Task
        Dim parser = New TextFieldParser(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "StockCodeList.txt"))
        parser.TextFieldType = FieldType.Delimited
        parser.SetDelimiters(",")
        parser.HasFieldsEnclosedInQuotes = False
        parser.TrimWhiteSpace = False

        Dim codes As New List(Of Decimal)
        While Not parser.EndOfData
            Dim row As String() = parser.ReadFields()
            codes.Add(row(0))
        End While

        Dim stw As New Stopwatch
        stw.Start()

        Try

            Dim bl As New BL.StockPriceBL
            Dim prices As List(Of 株価)
            Dim beginDt As DateTime = DateSerial(2009, 1, 1)
            Dim endDt As DateTime = Now.Date
            Dim ut As New Utility.FinanceUtil
            Dim utBl As New UtilityBL

            For Each r In codes
                prices = bl.SelectStockPrice(r)
                If prices.Count = 0 Then
                    beginDt = DateSerial(2010, 1, 1)
                Else
                    beginDt = prices.Max(Function(d) d.日付).AddDays(1)
                End If
                If beginDt > endDt Then
                    Continue For
                End If
                Dim tmpDt = beginDt
                Dim isNext As Boolean = True
                While tmpDt <= endDt
                    If tmpDt.DayOfWeek = DayOfWeek.Sunday OrElse tmpDt.DayOfWeek = DayOfWeek.Saturday Then
                    Else
                        isNext = False
                        Exit While
                    End If
                    tmpDt = tmpDt.AddDays(1)
                End While
                If isNext Then
                    Continue For
                End If
                prices = ut.Get株価(r, beginDt, endDt)
                If prices.Count = 0 Then
                    Continue For
                End If
                bl.UpdateStockPrice(prices)
                Console.WriteLine(stw.ElapsedMilliseconds & " " & prices(0).証券コード & " " & prices(0).企業名)
                stw.Reset()
                stw.Start()
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            stw.Stop()
        End Try


    End Function


End Module
