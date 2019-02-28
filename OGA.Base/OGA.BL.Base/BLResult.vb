Public Class BLResult
    Public Enum ReturnCds As Integer
        _NORMAL
        _WARNING
        _ERROR
    End Enum

    Public Property ReturnCd As ReturnCds
    Public Property Message As String

End Class
