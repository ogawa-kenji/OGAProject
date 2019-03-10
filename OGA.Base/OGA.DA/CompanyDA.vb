Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base
Public Class CompanyDA
    Inherits DataBaseAcess

    Public Function Select企業情報() As (DBResult, List(Of 企業情報))
        Return Me.DBSelect(Of 企業情報)("SELECT * FROM 企業情報 ORDER BY 証券コード")
    End Function
End Class
