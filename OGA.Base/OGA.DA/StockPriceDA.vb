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

    Public Function SelectStockPrice(証券コード As Decimal) As (DBResult, List(Of 株価))
        Return Me.DBSelect(Of 株価)("SELECT * FROM StockPrice WHERE 証券コード = :証券コード ORDER BY 証券コード", New With {.証券コード = 証券コード})
    End Function

    Public Function UpdateStockPrice(prices As List(Of 株価)) As DBResult
        'Dim result = Me.DBExecute("DELETE FROM 株価 WHERE 証券コード = :証券コード AND 日付 = :日付", prices)
        'If result.ReturnCd <> DBResult.ReturnCds._NORMAL Then
        '    Return result
        'End If

        Dim stb As New StringBuilder
        stb.AppendLine("INSERT OR REPLACE INTO StockPrice VALUES ")
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

    Public Function SelectBackText(証券コード As Decimal) As (DBResult, List(Of StockPriceBI))
        Dim stbSql As New StringBuilder
        stbSql.Append("  SELECT  ")
        stbSql.Append("         証券コード ")
        stbSql.Append("       , 企業名 ")
        stbSql.Append("       , 日付 ")
        stbSql.Append("       , 出来高 ")
        stbSql.Append("       , CAST(調整後終値 AS REAL) AS 調整後終値 ")
        stbSql.Append("       , 前日出来高 ")
        stbSql.Append("       , CAST(前日株価 AS REAL) AS 前日株価 ")
        stbSql.Append("       , CASE WHEN 移動平均5件数   = 5   THEN CAST(移動平均5   AS REAL) ELSE NULL END AS 移動平均5 ")
        stbSql.Append("       , CASE WHEN 移動平均25件数  = 25  THEN CAST(移動平均25  AS REAL) ELSE NULL END AS 移動平均25 ")
        stbSql.Append("       , CASE WHEN 移動平均75件数  = 75  THEN CAST(移動平均75  AS REAL) ELSE NULL END AS 移動平均75 ")
        stbSql.Append("       , CASE WHEN 移動平均200件数 = 200 THEN CAST(移動平均200 AS REAL) ELSE NULL END AS 移動平均200 ")
        stbSql.Append("       , ROUND(CAST( (出来高     - 前日出来高)  AS REAL ) / 前日出来高,5)  AS 出来高増減率 ")
        stbSql.Append("       , ROUND(CAST( (調整後終値 - 前日株価)    AS REAL ) / 前日株価,5)    AS 株価増減率 ")
        stbSql.Append("       , CASE WHEN 移動平均5件数   = 5   THEN CAST( (調整後終値 - 移動平均5)   AS REAL ) / 移動平均5   ELSE NULL END AS 移動平均5乖離率 ")
        stbSql.Append("       , CASE WHEN 移動平均25件数  = 25  THEN CAST( (調整後終値 - 移動平均25)  AS REAL ) / 移動平均25  ELSE NULL END AS 移動平均25乖離率 ")
        stbSql.Append("       , CASE WHEN 移動平均75件数  = 75  THEN CAST( (調整後終値 - 移動平均75)  AS REAL ) / 移動平均75  ELSE NULL END AS 移動平均75乖離率 ")
        stbSql.Append("       , CASE WHEN 移動平均200件数 = 200 THEN CAST( (調整後終値 - 移動平均200) AS REAL ) / 移動平均200 ELSE NULL END AS 移動平均200乖離率 ")
        stbSql.Append("   FROM  ")
        stbSql.Append("        (  ")
        stbSql.Append("         SELECT  ")
        stbSql.Append("                証券コード ")
        stbSql.Append("              , 企業名 ")
        stbSql.Append("              , 日付 ")
        stbSql.Append("              , 出来高 ")
        stbSql.Append("              , 調整後終値 ")
        stbSql.Append("              , LAG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日株価 ")
        stbSql.Append("              , LAG(出来高)       OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日出来高 ")
        stbSql.Append("              , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4   PRECEDING AND CURRENT ROW) AS 移動平均5 ")
        stbSql.Append("              , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4   PRECEDING AND CURRENT ROW) AS 移動平均5件数 ")
        stbSql.Append("              , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24  PRECEDING AND CURRENT ROW) AS 移動平均25 ")
        stbSql.Append("              , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24  PRECEDING AND CURRENT ROW) AS 移動平均25件数 ")
        stbSql.Append("              , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74  PRECEDING AND CURRENT ROW) AS 移動平均75 ")
        stbSql.Append("              , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74  PRECEDING AND CURRENT ROW) AS 移動平均75件数 ")
        stbSql.Append("              , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 199 PRECEDING AND CURRENT ROW) AS 移動平均200 ")
        stbSql.Append("              , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 199 PRECEDING AND CURRENT ROW) AS 移動平均200件数 ")
        stbSql.Append("           FROM StockPrice ")
        stbSql.Append("          WHERE 証券コード = :証券コード ")
        stbSql.Append("        ) AS TBL  ")
        stbSql.Append("   ORDER BY 証券コード ")
        stbSql.Append("          , 日付 ")
        Return Me.DBSelect(Of StockPriceBI)(stbSql.ToString(), New With {.証券コード = 証券コード})
    End Function
End Class
