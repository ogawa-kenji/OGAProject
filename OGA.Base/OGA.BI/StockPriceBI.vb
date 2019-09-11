Public Class StockPriceBI
    Public Property 証券コード As Decimal
    Public Property 企業名 As String
    Public Property 日付 As DateTime
    Public Property 出来高 As Decimal
    Public Property 調整後終値 As Decimal
    Public Property 前日出来高 As Decimal
    Public Property 前日株価 As Decimal
    Public Property 出来高増減率 As Double?
    Public Property 株価増減率 As Double?
    Public Property 移動平均5 As Double?
    Public Property 移動平均25 As Double?
    Public Property 移動平均75 As Double?
    Public Property 移動平均200 As Double?
    Public Property 移動平均5乖離率 As Double?
    Public Property 移動平均25乖離率 As Double?
    Public Property 移動平均75乖離率 As Double?
    Public Property 移動平均200乖離率 As Double?
End Class

Public Class StockPriceList
    Public Property 証券コード As Decimal
    Public Property 企業名 As String
End Class
