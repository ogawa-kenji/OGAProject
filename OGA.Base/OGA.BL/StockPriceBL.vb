Imports System.Transactions
Imports OGA.BI
Imports OGA.DA
Imports OGA.DA.Base
Public Class StockPriceBL
    Inherits BL.Base.BLBase

    Public Function CreateTable() As Boolean
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Dim da As New StockPriceDA
            If da.CreateTable() Then
                scope.Complete()
                Return True
            End If
        End Using
        Return False
    End Function
    Public Function SelectStockPrice(証券コード As Decimal) As List(Of 株価)
        Using da As New StockPriceDA
            Return da.SelectStockPrice(証券コード).Item2
        End Using
    End Function

    Public Function UpdateStockPrice(prices As List(Of 株価)) As Boolean
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Using da As New StockPriceDA
                Dim dbresult = da.UpdateStockPrice(prices)
                If dbresult.ReturnCd = DBResult.ReturnCds._NORMAL Then
                    scope.Complete()
                Else
                    Return False
                End If
            End Using
        End Using
        Return True
    End Function

    Public Function SelectBackTest(証券コード As Decimal) As List(Of StockPriceBI)
        Using da As New StockPriceDA
            Return da.SelectBackText(証券コード).Item2
        End Using
    End Function


End Class
