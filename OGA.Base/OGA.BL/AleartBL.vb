Imports OGA.BI
Imports OGA.DA
Public Class AleartBL
    Public Function Selectアラート() As List(Of アラート)
        Using da As New AleartDA
            Return da.Selectアラート().Item2
        End Using
    End Function
End Class
