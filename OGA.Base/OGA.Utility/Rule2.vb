Imports OGA.BI
Imports OGA.Utility

Public Class Rule2
    Implements IBackTest

    Private ルール_移動平均75増減率 As Decimal
    Private ルール_売経過日数 As Decimal
    Private ルール_期間開始 As DateTime
    Private ルール_期間終了 As DateTime

    Public Sub New(target As List(Of 移動平均),
                   移動平均75増減率 As Decimal,
                   売経過日数 As Decimal,
                   期間開始 As DateTime,
                   期間終了 As DateTime)

        対象 = target
        現金 = 1000000
        株数 = 0
        評価額 = 現金
        買値 = 0
        売値 = 0
        CanBuy = True
        テスト結果 = New List(Of バックテスト)
        ルール_移動平均75増減率 = 移動平均75増減率
        ルール_売経過日数 = 売経過日数
        ルール_期間開始 = 期間開始
        ルール_期間終了 = 期間終了
    End Sub

    Public Property 対象 As List(Of 移動平均) Implements IBackTest.対象
    Public Property 売買回数 As Integer Implements IBackTest.売買回数
    Public Property 現金 As Decimal Implements IBackTest.現金
    Public Property 株数 As Decimal Implements IBackTest.株数
    Public Property 評価額 As Decimal Implements IBackTest.評価額
    Public Property 買値 As Decimal Implements IBackTest.買値
    Public Property 売値 As Decimal Implements IBackTest.売値
    Public Property CanBuy As Boolean Implements IBackTest.CanBuy
    Public Property 経過日数 As Decimal Implements IBackTest.経過日数
    Public Property テスト結果 As List(Of バックテスト) Implements IBackTest.テスト結果

    Public Sub Buy(日付 As DateTime) Implements IBackTest.Buy
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault

        If q Is Nothing Then
            '' 売買できる日ではない
            Return
        End If

        '' 購入可能な株数を算出
        株数 = Math.Floor(現金 / 100 / q.調整後終値) * 100
        '' 購入したら現金から差っ引く
        現金 = 現金 - q.調整後終値 * 株数
        買値 = q.調整後終値
        売値 = 0
        経過日数 = 0
        CanBuy = False
        売買回数 = 売買回数 + 1
    End Sub

    Public Sub Sell(日付 As DateTime) Implements IBackTest.Sell
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault

        If q Is Nothing Then
            '' 売買できる日ではない
            Return
        End If
        '' 持ち株を売る
        現金 = 現金 + q.調整後終値 * 株数
        株数 = 0
        買値 = 0
        売値 = q.調整後終値
        経過日数 = 0
        CanBuy = True
        売買回数 = 売買回数 + 1
    End Sub

    Public Sub TestAdd(日付 As Date) Implements IBackTest.TestAdd
        '' 評価額の計算とテスト結果の整備
        Dim test As New バックテスト
        test.日付 = 日付
        test.株数 = Me.株数
        test.現金 = Me.現金
        test.買値 = Me.買値
        test.売値 = Me.売値

        Dim price = (From p In 対象
                     Where p.日付 = 日付
                     Select p).FirstOrDefault

        If price IsNot Nothing Then
            test.証券コード = price.証券コード
            test.企業名 = price.企業名
            test.始値 = price.始値
            test.安値 = price.安値
            test.高値 = price.高値
            test.終値 = price.終値
            test.調整後終値 = price.調整後終値
            test.移動平均5 = price.移動平均5
            test.移動平均25 = price.移動平均25
            test.移動平均75 = price.移動平均75
        End If

        Dim q = (From p In 対象
                 Where p.日付 <= 日付
                 Order By p.日付 Descending
                 Select p).FirstOrDefault

        If q Is Nothing Then
            Me.評価額 = Me.現金
        Else
            Me.評価額 = Me.現金 + Me.株数 * q.調整後終値
        End If
        test.評価額 = Me.評価額

        If Me.テスト結果.Count <> 0 Then
            If Me.テスト結果(Me.テスト結果.Count - 1).株数 = 0 Then
                If Me.株数 > 0 Then
                    test.株買 = True
                End If
            Else
                If Me.株数 = 0 Then
                    test.株売 = True
                End If
            End If
        End If

        Me.テスト結果.Add(test)

    End Sub

    Public Function CheckBuyRule(日付 As DateTime) As Boolean Implements IBackTest.CheckBuyRule
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault

        If q Is Nothing Then
            '' 売買できる日ではない
            Return False
        End If

        If CanBuy = False Then
            '' 買えない
            Return False
        End If

        '' 購入ルール
        '' 移動平均5 の乖離率がマイナス5％以下で買い
        'If (q.調整後終値 - q.移動平均5) / q.移動平均5 <= -0.05 Then
        '    Return True
        'End If
        If ルール_移動平均75増減率 >= 0 Then
            If (q.調整後終値 - q.移動平均75) / q.移動平均75 >= ルール_移動平均75増減率 Then
                Return True
            End If
        Else
            If (q.調整後終値 - q.移動平均75) / q.移動平均75 <= ルール_移動平均75増減率 Then
                Return True
            End If
        End If

        Return False

    End Function

    Public Function CheckSellRule(日付 As DateTime) As Boolean Implements IBackTest.CheckSellRule
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault

        If q Is Nothing Then
            '' 売買できる日ではない
            Return False
        End If

        If CanBuy Then
            '' 売れない
            Return False
        End If

        '' 売りルール
        If 経過日数 >= ルール_売経過日数 Then
            経過日数 = 0
            Return True
        End If

        Return False
    End Function

    Public Sub Calc() Implements IBackTest.Calc
        Dim beginDate As DateTime = ルール_期間開始
        Dim endDate As DateTime = ルール_期間終了
        While beginDate <= endDate
            If Me.CheckBuyRule(beginDate) Then
                Me.Buy(beginDate)
            End If
            If Me.CheckSellRule(beginDate) Then
                Me.Sell(beginDate)
            End If
            Me.経過日数 += 1
            Me.TestAdd(beginDate)
            beginDate = beginDate.AddDays(1)
        End While
    End Sub


End Class
