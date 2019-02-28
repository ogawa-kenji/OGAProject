Public Class DBResult

    Public Enum ReturnCds As Integer
        _NORMAL
        _WARNING
        _ERROR
    End Enum

    Public Property ReturnCd As ReturnCds
    Public Property AffectCnt As Decimal
    Public Property Message As String

End Class


