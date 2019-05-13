Imports System.Text
Imports NLog

Public Class LogUtil
    Private Shared _logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared Function LogText(formName As String,
                                    controlName As String,
                                    controlText As String,
                                    <System.Runtime.CompilerServices.CallerMemberName> Optional callerMemberName As String = Nothing) As String
        Try
            Dim stb As New StringBuilder
            stb.Append(String.Format("""{0}"",""{1}"",""{2}"",""{3}""", callerMemberName, formName, controlName, controlText))
            Return stb.ToString()
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Shared Sub LogInfo(text As String)
        Try
            _logger.Info(text)
        Catch ex As Exception
            Return
        End Try
    End Sub
    Public Shared Sub LogError(text As String)
        Try
            _logger.Error(text)
        Catch ex As Exception
            Return
        End Try
    End Sub

End Class
