Imports OGA.BI
Imports OGA.DA
Public Class AleartBL
    Public Function Selectアラート() As List(Of アラート)
        Using da As New AleartDA
            Return da.Selectアラート().Item2
        End Using
    End Function
    Public Function Selectアラート(日付 As DateTime) As List(Of アラート)
        Using da As New AleartDA
            Return da.Selectアラート(日付).Item2
        End Using
    End Function
End Class
