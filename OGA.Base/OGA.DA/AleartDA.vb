﻿Imports System.Text
Imports OGA.BI
Imports OGA.DA.Base
Public Class AleartDA
    Inherits DataBaseAcess

    Public Function Selectアラート() As (DBResult, List(Of アラート))
        Dim stbSql As New StringBuilder
        stbSql.Append(" SELECT   ")
        stbSql.Append("        証券コード  ")
        stbSql.Append("      , 企業名  ")
        stbSql.Append("      , 出来高  ")
        stbSql.Append("      , 調整後終値  ")
        stbSql.Append("      , 前日出来高  ")
        stbSql.Append("      , CAST(前日株価 AS REAL) AS 前日株価 ")
        stbSql.Append("      , CASE WHEN 移動平均5件数  = 5  THEN 移動平均5  ELSE NULL END AS 移動平均5  ")
        stbSql.Append("      , CASE WHEN 移動平均25件数 = 25 THEN 移動平均25 ELSE NULL END AS 移動平均25  ")
        stbSql.Append("      , CASE WHEN 移動平均75件数 = 75 THEN 移動平均75 ELSE NULL END AS 移動平均75  ")
        stbSql.Append("      , (CAST( (出来高 - 前日出来高) AS REAL ) / 前日出来高)  AS 出来高増減率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 前日株価) AS REAL ) / 前日株価)  AS 株価増減率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均5) AS REAL ) / 移動平均5)  AS 移動平均5乖離率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均25) AS REAL ) / 移動平均25)  AS 移動平均25乖離率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均75) AS REAL ) / 移動平均75)  AS 移動平均75乖離率  ")
        stbSql.Append("  FROM   ")
        stbSql.Append("       (   ")
        stbSql.Append("        SELECT   ")
        stbSql.Append("               証券コード  ")
        stbSql.Append("             , 企業名  ")
        stbSql.Append("             , 日付  ")
        stbSql.Append("             , 出来高  ")
        stbSql.Append("             , CAST(調整後終値 AS REAL) AS 調整後終値  ")
        stbSql.Append("             , LAG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日株価  ")
        stbSql.Append("             , LAG(出来高)       OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日出来高  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4  PRECEDING AND CURRENT ROW) AS 移動平均5  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4  PRECEDING AND CURRENT ROW) AS 移動平均5件数  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24 PRECEDING AND CURRENT ROW) AS 移動平均25  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24 PRECEDING AND CURRENT ROW) AS 移動平均25件数  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74 PRECEDING AND CURRENT ROW) AS 移動平均75  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74 PRECEDING AND CURRENT ROW) AS 移動平均75件数  ")
        stbSql.Append("          FROM 株価  ")
        stbSql.Append("       ) AS TBL   ")
        stbSql.Append(" WHERE 日付 = (SELECT MAX(日付) FROM 株価)  ")
        Return Me.DBSelect(Of アラート)(stbSql.ToString())
    End Function

    Public Function Selectアラート(日付 As DateTime) As (DBResult, List(Of アラート))
        Dim stbSql As New StringBuilder
        stbSql.Append(" SELECT   ")
        stbSql.Append("        証券コード  ")
        stbSql.Append("      , 企業名  ")
        stbSql.Append("      , 出来高  ")
        stbSql.Append("      , 調整後終値  ")
        stbSql.Append("      , 前日出来高  ")
        stbSql.Append("      , CAST(前日株価 AS REAL) AS 前日株価  ")
        stbSql.Append("      , CASE WHEN 移動平均5件数  = 5  THEN 移動平均5  ELSE NULL END AS 移動平均5  ")
        stbSql.Append("      , CASE WHEN 移動平均25件数 = 25 THEN 移動平均25 ELSE NULL END AS 移動平均25  ")
        stbSql.Append("      , CASE WHEN 移動平均75件数 = 75 THEN 移動平均75 ELSE NULL END AS 移動平均75  ")
        stbSql.Append("      , (CAST( (出来高 - 前日出来高) AS REAL ) / 前日出来高)  AS 出来高増減率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 前日株価) AS REAL ) / 前日株価)  AS 株価増減率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均5) AS REAL ) / 移動平均5)  AS 移動平均5乖離率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均25) AS REAL ) / 移動平均25)  AS 移動平均25乖離率  ")
        stbSql.Append("      , (CAST( (調整後終値 - 移動平均75) AS REAL ) / 移動平均75)  AS 移動平均75乖離率  ")
        stbSql.Append("  FROM   ")
        stbSql.Append("       (   ")
        stbSql.Append("        SELECT   ")
        stbSql.Append("               証券コード  ")
        stbSql.Append("             , 企業名  ")
        stbSql.Append("             , 日付  ")
        stbSql.Append("             , 出来高  ")
        stbSql.Append("             , CAST(調整後終値 AS REAL) AS 調整後終値  ")
        stbSql.Append("             , LAG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日株価  ")
        stbSql.Append("             , LAG(出来高)       OVER(PARTITION BY 証券コード ORDER BY 日付) AS 前日出来高  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4  PRECEDING AND CURRENT ROW) AS 移動平均5  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 4  PRECEDING AND CURRENT ROW) AS 移動平均5件数  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24 PRECEDING AND CURRENT ROW) AS 移動平均25  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 24 PRECEDING AND CURRENT ROW) AS 移動平均25件数  ")
        stbSql.Append("             , AVG(調整後終値)   OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74 PRECEDING AND CURRENT ROW) AS 移動平均75  ")
        stbSql.Append("             , COUNT(調整後終値) OVER(PARTITION BY 証券コード ORDER BY 日付 ROWS BETWEEN 74 PRECEDING AND CURRENT ROW) AS 移動平均75件数  ")
        stbSql.Append("          FROM 株価  ")
        stbSql.Append("       ) AS TBL   ")
        stbSql.Append(" WHERE 日付 = (SELECT MAX(日付) FROM 株価 WHERE 日付 <= :日付)  ")
        Return Me.DBSelect(Of アラート)(stbSql.ToString(), New With {.日付 = 日付})
    End Function
End Class
