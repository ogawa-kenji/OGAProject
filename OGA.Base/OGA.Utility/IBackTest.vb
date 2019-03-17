Imports OGA.BI

Public Interface IBackTest

    Property 対象 As List(Of 移動平均)
    Property 売買回数 As Integer
    Property 現金 As Decimal
    Property 株数 As Decimal
    Property 評価額 As Decimal
    Property 買値 As Decimal
    Property 売値 As Decimal
    Property CanBuy As Boolean
    Property 経過日数 As Decimal
    Property テスト結果 As List(Of バックテスト)


    Function CheckBuyRule(日付 As DateTime) As Boolean
    Function CheckSellRule(日付 As DateTime) As Boolean
    Sub Buy(日付 As DateTime)
    Sub Sell(日付 As DateTime)
    Sub TestAdd(日付 As DateTime)
    Sub Calc()

End Interface
