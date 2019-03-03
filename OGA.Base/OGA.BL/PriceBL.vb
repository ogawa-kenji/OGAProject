Imports OGA.BI
Imports OGA.DA

Public Class PriceBL
    Public Function Select株価(証券コード As Decimal) As List(Of 株価)
        Using da As New PriceDA
            Return da.Select株価(証券コード).Item2
        End Using
    End Function
End Class
