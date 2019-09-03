Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base
Public Class StockPriceDA
    Inherits DataBaseAcess

    Public Function CreateTable() As Boolean

        Dim resultCnt As (dbresult As DBResult, list As List(Of Decimal))
        resultCnt = Me.DBSelect(Of Decimal)("SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name = :name ", New With {.name = "StockPrice"})
        If resultCnt.dbresult.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return False
        End If
        If resultCnt.list(0) = 1 Then
            Return False
        End If

        Dim result As DBResult
        Dim stb As New StringBuilder
        stb.AppendLine("CREATE TABLE StockPrice")
        stb.AppendLine("(")
        stb.AppendLine("     証券コード  NUMERIC")
        stb.AppendLine("   , 企業名      TEXT")
        stb.AppendLine("   , 日付        TEXT")
        stb.AppendLine("   , 始値        NUMERIC")
        stb.AppendLine("   , 高値        NUMERIC")
        stb.AppendLine("   , 安値        NUMERIC")
        stb.AppendLine("   , 終値        NUMERIC")
        stb.AppendLine("   , 出来高      NUMERIC")
        stb.AppendLine("   , 調整後終値  NUMERIC")
        stb.AppendLine("   , PRIMARY KEY(証券コード,日付) ")
        stb.AppendLine(")")
        result = Me.DBExecute(stb.ToString)
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return False
        End If
        Return True
    End Function

End Class
