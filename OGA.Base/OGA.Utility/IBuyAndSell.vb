Imports OGA.BI
Public Interface IBuyAndSell

    Property 対象 As List(Of StockPriceBI)
    Property 売買回数 As Integer
    Property 現金 As Decimal
    Property 株数 As Decimal
    Property 評価額 As Decimal
    Property 買値 As Decimal
    Property 売値 As Decimal
    Property 日付 As DateTime
    Property CanSell As Boolean
    Sub Buy(日付 As DateTime)
    Sub Sell(日付 As DateTime)
    Sub Calc()

End Interface
