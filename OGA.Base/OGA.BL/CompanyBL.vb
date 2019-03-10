Imports OGA.BI
Imports OGA.DA
Public Class CompanyBL
    Public Function Select企業情報() As List(Of 企業情報)
        Using da As New CompanyDA
            Return da.Select企業情報().Item2
        End Using
    End Function
End Class
