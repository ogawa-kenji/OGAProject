Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base
Public Class PriceDA
    Inherits DataBaseAcess

    Public Function Select株価(証券コード As Decimal) As (DBResult, List(Of 株価))
        Return Me.DBSelect(Of 株価)("SELECT * FROM 株価 WHERE 証券コード = :証券コード ORDER BY 証券コード", New With {.証券コード = 証券コード})
    End Function
End Class
