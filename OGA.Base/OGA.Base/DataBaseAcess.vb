Imports Dapper
Imports System.Data.SQLite
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel

Public Class DataBaseAcess
    Implements IDisposable

    Private conn As Common.DbConnection

    Protected ReadOnly Property SqlConn As Common.DbConnection
        Get
            Return conn
        End Get
    End Property

    Public Sub New()
        conn = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SQLite").CreateConnection()
        Dim exeFileMap As New ExeConfigurationFileMap()
        exeFileMap.ExeConfigFilename = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Sqlite.DB.Config")
        Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None)
        conn.ConnectionString = config.AppSettings.Settings("ConnectionString").Value
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

#Region " DBSelect"
    Protected Function DBSelect(Of T)(sql As String) As (DBResult, List(Of T))
        Return DBSelect(Of T)(sql, Nothing)
    End Function
    Protected Function DBSelect(Of T)(sql As String, param As Object) As (DBResult, List(Of T))
        Dim result As New DBResult
        Dim list As New List(Of T)
        Try
            list = Me.conn.Query(Of T)(sql:=sql, param:=param).ToList()
            result.ReturnCd = DBResult.ReturnCds._NORMAL
            result.Message = ""
        Catch ex As SQLite.SQLiteException
            result.ReturnCd = DBResult.ReturnCds._ERROR
            result.Message = ex.Message
        Catch ex As Exception
            Throw
        End Try
        Return (result, list)
    End Function

#End Region

#Region " DBExecute"
    Protected Function DBExecute(sql As String) As DBResult
        Return DBExecute(sql, Nothing)
    End Function
    Protected Function DBExecute(sql As String, param As Object) As DBResult
        Dim result As New DBResult
        Try
            conn.Execute(sql:=sql, param:=param)
            result.ReturnCd = DBResult.ReturnCds._NORMAL
            result.Message = ""
            Return result
        Catch ex As SQLite.SQLiteException
            result.ReturnCd = DBResult.ReturnCds._ERROR
            result.Message = ex.Message
            Return result
        Catch ex As Exception
            Throw
        End Try
    End Function

    Protected Friend Function ServerDate() As DateTime
        Dim result As (dbresult As DBResult, list As List(Of DateTime))
        result = Me.DBSelect(Of DateTime)("SELECT DATETIME('now', '+9 hours')", Nothing)
        If result.dbresult.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return Now
        Else
            If result.list.Count = 0 Then
                Return Now
            Else
                Return result.list(0)
            End If
        End If
    End Function


#End Region

    Protected Function ListToDataTable(Of T)(list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' 重複する呼び出しを検出するには

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                If conn IsNot Nothing Then
                    If conn.State <> ConnectionState.Closed Then
                        conn.Close()
                    End If
                    conn.Dispose()
                End If
            End If

            ' TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下の Finalize() をオーバーライドします。
            ' TODO: 大きなフィールドを null に設定します。


        End If
        disposedValue = True
    End Sub

    ' TODO: 上の Dispose(disposing As Boolean) にアンマネージ リソースを解放するコードが含まれる場合にのみ Finalize() をオーバーライドします。
    Protected Overrides Sub Finalize()
        ' このコードを変更しないでください。クリーンアップ コードを上の Dispose(disposing As Boolean) に記述します。
        MyBase.Finalize()
    End Sub

    ' このコードは、破棄可能なパターンを正しく実装できるように Visual Basic によって追加されました。
    Public Sub Dispose() Implements IDisposable.Dispose
        ' このコードを変更しないでください。クリーンアップ コードを上の Dispose(disposing As Boolean) に記述します。
        Dispose(True)
        ' TODO: 上の Finalize() がオーバーライドされている場合は、次の行のコメントを解除してください。
        GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class
