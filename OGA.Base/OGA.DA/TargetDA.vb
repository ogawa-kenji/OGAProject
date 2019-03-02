Imports System.Text
Imports OGA.DA.Base
Public Class TargetDA
    Inherits DataBaseAcess

    Private TableName As String = "ターゲット"

    Public Function SearchTable() As Boolean
        Dim result As (dbresult As DBResult, list As List(Of Decimal))
        result = Me.DBSelect(Of Decimal)("SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name = :name ", New With {.name = TableName})
        If result.dbresult.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return False
        End If
        If result.list.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function CreateTable() As Boolean
        Dim result As DBResult
        Dim stb As New StringBuilder
        stb.AppendLine("CREATE TABLE ターゲット")
        stb.AppendLine("(")
        stb.AppendLine("     証券コード  NUMERIC")
        stb.AppendLine("   , PRIMARY KEY(証券コード) ")
        stb.AppendLine(")")
        result = Me.DBExecute(stb.ToString)
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return False
        End If
        Return True
    End Function


End Class
