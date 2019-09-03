Imports System.Transactions
Imports OGA.BI
Imports OGA.DA
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
End Class
