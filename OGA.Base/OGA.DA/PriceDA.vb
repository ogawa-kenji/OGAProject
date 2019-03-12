Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base
Public Class PriceDA
    Inherits DataBaseAcess

    Public Function Select株価(証券コード As Decimal) As (DBResult, List(Of 株価))
        Return Me.DBSelect(Of 株価)("SELECT * FROM 株価 WHERE 証券コード = :証券コード ORDER BY 証券コード", New With {.証券コード = 証券コード})
    End Function

    Public Function Select移動平均(証券コード As Decimal) As (DBResult, List(Of 移動平均))
        Dim stbSql As New StringBuilder
        stbSql.Append(" SELECT ")
        stbSql.Append("        証券コード")
        stbSql.Append("      , 企業名")
        stbSql.Append("      , 日付")
        stbSql.Append("      , 始値")
        stbSql.Append("      , 高値")
        stbSql.Append("      , 安値")
        stbSql.Append("      , 終値")
        stbSql.Append("      , 出来高")
        stbSql.Append("      , 調整後終値")
        stbSql.Append("      , CASE WHEN 移動平均5件数  = 5  THEN 移動平均5  ELSE NULL END AS 移動平均5")
        stbSql.Append("      , CASE WHEN 移動平均25件数 = 25 THEN 移動平均25 ELSE NULL END AS 移動平均25")
        stbSql.Append("      , CASE WHEN 移動平均75件数 = 75 THEN 移動平均75 ELSE NULL END AS 移動平均75")
        stbSql.Append("  FROM ")
        stbSql.Append("       ( ")
        stbSql.Append("        SELECT ")
        stbSql.Append("               *")
        stbSql.Append("             , AVG(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("                ROWS BETWEEN 4 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均5")
        stbSql.Append("             , COUNT(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("               ROWS BETWEEN 4 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均5件数")
        stbSql.Append("             , AVG(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("                ROWS BETWEEN 24 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均25")
        stbSql.Append("             , COUNT(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("               ROWS BETWEEN 24 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均25件数")
        stbSql.Append("             , AVG(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("                ROWS BETWEEN 74 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均75")
        stbSql.Append("             , COUNT(調整後終値) OVER(")
        stbSql.Append("               ORDER BY 日付")
        stbSql.Append("               ROWS BETWEEN 74 PRECEDING AND CURRENT ROW")
        stbSql.Append("               ) AS 移動平均75件数")
        stbSql.Append("          FROM 株価")
        stbSql.Append("         WHERE 証券コード = :証券コード")
        stbSql.Append("       ) AS TBL ")


        Return Me.DBSelect(Of 移動平均)(stbSql.ToString(), New With {.証券コード = 証券コード})
    End Function



End Class
