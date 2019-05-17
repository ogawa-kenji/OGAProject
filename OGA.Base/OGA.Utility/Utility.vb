Public Class Utility
    Public Shared Function IsDigit(value As String) As Boolean
        Return Decimal.TryParse(value, Nothing)
    End Function

    Public Shared Function NumberPlaces(value As Decimal) As (Integer, Integer)
        Dim str As String = value.ToString()
        If str.Contains(".") Then
            ' 小数部の後ろの0は除く
            str = str.TrimEnd("0")
        End If
        Dim integerPlaces As Integer = 0
        Dim decimalPlaces As Integer = 0
        Dim split As String() = str.Split("."c)
        ' 整数部の桁数
        integerPlaces = split(0).Length
        If split.Length > 1 Then
            ' 小数部の桁数
            decimalPlaces = split(1).Length
        End If
        Return (integerPlaces, decimalPlaces)
    End Function
End Class
