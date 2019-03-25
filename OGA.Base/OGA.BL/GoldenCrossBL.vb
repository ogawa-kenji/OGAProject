Imports OGA.BI
Imports OGA.DA
Public Class GoldenCrossBL
    Public Function Selectゴールデンクロス() As List(Of ゴールデンクロス)
        Using da As New GoldenCrossDA
            Return da.Selectゴールデンクロス().Item2
        End Using
    End Function
End Class
