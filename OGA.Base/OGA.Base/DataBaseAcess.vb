Imports Dapper
Imports System.Data.SQLite
Imports System.Configuration


Public Class DataBaseAcess
    Implements IDisposable

    Private conn As Common.DbConnection

    Public Sub New()
        conn = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SQLite").CreateConnection()
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        conn.Open()
    End Sub

    Public Sub Connect()

    End Sub

    Public Function DBSelect(sql As String, param As Object)

    End Function

    Public Function DBExecute(sql As String, param As Object) As DBResult
        Dim result As New DBResult
        Try
            conn.Execute(sql:=sql, param:=param)
            result.ReturnCd = DBResult.ReturnCds._NORMAL
            result.Message = ""
            Return result
        Catch ex As Exception
            result.ReturnCd = DBResult.ReturnCds._ERROR
            result.Message = ex.Message
            Throw
        End Try
    End Function



#Region "IDisposable Support"
    Private disposedValue As Boolean ' 重複する呼び出しを検出するには



    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: マネージ状態を破棄します (マネージ オブジェクト)。
            End If

            ' TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下の Finalize() をオーバーライドします。
            ' TODO: 大きなフィールドを null に設定します。
            If conn IsNot Nothing Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Dispose()
            End If

        End If
        disposedValue = True
    End Sub

    ' TODO: 上の Dispose(disposing As Boolean) にアンマネージ リソースを解放するコードが含まれる場合にのみ Finalize() をオーバーライドします。
    'Protected Overrides Sub Finalize()
    '    ' このコードを変更しないでください。クリーンアップ コードを上の Dispose(disposing As Boolean) に記述します。
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' このコードは、破棄可能なパターンを正しく実装できるように Visual Basic によって追加されました。
    Public Sub Dispose() Implements IDisposable.Dispose
        ' このコードを変更しないでください。クリーンアップ コードを上の Dispose(disposing As Boolean) に記述します。
        Dispose(True)
        ' TODO: 上の Finalize() がオーバーライドされている場合は、次の行のコメントを解除してください。
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class
