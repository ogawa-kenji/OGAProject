Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base

Public Class UtilityDA
    Inherits DataBaseAcess

    Public Function Update企業情報(companies As List(Of 企業情報)) As DBResult
        Dim result = Me.DBExecute("DELETE FROM 企業情報 WHERE 証券コード = :証券コード", companies)
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return result
        End If

        Dim stb As New StringBuilder
        stb.AppendLine("INSERT INTO 企業情報 VALUES ")
        stb.AppendLine("( ")
        stb.AppendLine("     :証券コード ")
        stb.AppendLine("   , :企業名 ")
        stb.AppendLine("   , :特色 ")
        stb.AppendLine("   , :連結事業 ")
        stb.AppendLine("   , :本社所在地 ")
        stb.AppendLine("   , :業種分類 ")
        stb.AppendLine("   , :設立年月日 ")
        stb.AppendLine("   , :市場名 ")
        stb.AppendLine("   , :上場年月日 ")
        stb.AppendLine("   , :決算 ")
        stb.AppendLine("   , :単元株数 ")
        stb.AppendLine("   , :従業員数_単独 ")
        stb.AppendLine("   , :従業員数_連結 ")
        stb.AppendLine("   , :平均年収 ")
        stb.AppendLine(") ")

        Return Me.DBExecute(stb.ToString(), companies)

    End Function

    Public Function Update株価(prices As List(Of 株価)) As DBResult
        'Dim result = Me.DBExecute("DELETE FROM 株価 WHERE 証券コード = :証券コード AND 日付 = :日付", prices)
        'If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
        '    Return result
        'End If

        Dim stb As New StringBuilder
        stb.AppendLine("INSERT OR REPLACE INTO 株価 VALUES ")
        stb.AppendLine("( ")
        stb.AppendLine("     :証券コード ")
        stb.AppendLine("   , :企業名 ")
        stb.AppendLine("   , :日付 ")
        stb.AppendLine("   , :始値 ")
        stb.AppendLine("   , :高値 ")
        stb.AppendLine("   , :安値 ")
        stb.AppendLine("   , :終値 ")
        stb.AppendLine("   , :出来高 ")
        stb.AppendLine("   , :調整後終値 ")
        stb.AppendLine(") ")

        Return Me.DBExecute(stb.ToString(), prices)
    End Function


    Public Function Delete情報(証券コード As Decimal) As DBResult
        Dim result = Me.DBExecute("DELETE FROM ターゲット WHERE 証券コード = :証券コード", New With {.証券コード = 証券コード})
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return result
        End If
        result = Me.DBExecute("DELETE FROM 企業情報 WHERE 証券コード = :証券コード", New With {.証券コード = 証券コード})
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return result
        End If
        result = Me.DBExecute("DELETE FROM 株価 WHERE 証券コード = :証券コード", New With {.証券コード = 証券コード})
        If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
            Return result
        End If
        Return result
    End Function

End Class
