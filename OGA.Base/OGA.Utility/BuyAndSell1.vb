Imports System.Text
Imports OGA.BI
Imports OGA.Utility

Public Class BuyAndSell1
    Implements IBuyAndSell

    Public Property 履歴 As New StringBuilder

    Public Sub New(対象 As List(Of StockPriceBI))
        Me.対象 = 対象
        Me.CanSell = False        ' 買いから始める
        Me.現金 = 1000000         ' 100万スタート
        Me.株数 = 0               ' 0株
        Me.売買回数 = 0

    End Sub
    Public Property 対象 As List(Of StockPriceBI) Implements IBuyAndSell.対象
    Public Property 売買回数 As Integer Implements IBuyAndSell.売買回数
    Public Property 現金 As Decimal Implements IBuyAndSell.現金
    Public Property 株数 As Decimal Implements IBuyAndSell.株数
    Public Property 評価額 As Decimal Implements IBuyAndSell.評価額
    Public Property 買値 As Decimal Implements IBuyAndSell.買値
    Public Property 売値 As Decimal Implements IBuyAndSell.売値
    Public Property CanSell As Boolean Implements IBuyAndSell.CanSell
    Public Property 日付 As Date Implements IBuyAndSell.日付
    Public Sub Buy(日付 As Date) Implements IBuyAndSell.Buy
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault
        If q Is Nothing Then
            '' 売買できる日ではない
            Return
        End If

        If q.移動平均5乖離率.HasValue = False Then
            Return
        End If
        If q.移動平均75乖離率.HasValue = False Then
            Return
        End If

        ''買いルール
        If q.移動平均5乖離率 < -0.05 Then
            ' 移動平均5乖離率-5％以下
        Else
            Return
        End If
        If q.移動平均75乖離率 < -0.2 Then
            ' 移動平均75乖離率-20％以下
        Else
            Return
        End If

        '' ====================================================
        '’買い計算
        '' 購入可能な株数を算出
        株数 = Math.Floor(現金 / 100 / q.調整後終値) * 100
        If 株数 = 0 Then
            Return
        End If
        '' 購入したら現金から差っ引く
        現金 = 現金 - q.調整後終値 * 株数
        買値 = q.調整後終値
        売値 = 0
        売買回数 = 売買回数 + 1
        '' ====================================================
        履歴.AppendLine(String.Format("買" & vbTab & "{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}" & vbTab & "{4}" & vbTab & "{5}", q.証券コード, q.日付.ToString("yyyy/MM/dd"), q.調整後終値, 株数, 現金, q.調整後終値 * 株数))
        CanSell = True
    End Sub

    Public Sub Sell(日付 As Date) Implements IBuyAndSell.Sell
        Dim q = (From p In 対象
                 Where p.日付 = 日付
                 Select p).FirstOrDefault
        If q Is Nothing Then
            '' 売買できる日ではない
            Return
        End If

        ''売ルール
        If (q.調整後終値 - 買値) / 買値 >= 0.1 Or 対象.Max(Function(d) d.日付) = 日付 Then
            ' 買値より10％以上あがったら売り または 売れていない場合最終日で売り
        Else
            Return
        End If

        '' ====================================================
        '’売り計算
        '' 持ち株を売る
        現金 = 現金 + q.調整後終値 * 株数
        株数 = 0
        買値 = 0
        売値 = q.調整後終値
        売買回数 = 売買回数 + 1
        '' ====================================================
        履歴.AppendLine(String.Format("売" & vbTab & "{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}" & vbTab & "{4}" & vbTab & "{5}", q.証券コード, q.日付.ToString("yyyy/MM/dd"), q.調整後終値, 株数, 現金, q.調整後終値 * 株数))
        CanSell = False
    End Sub
    Public Sub Calc() Implements IBuyAndSell.Calc
        For Each r In 対象
            If CanSell = False Then
                Me.Buy(r.日付)
            Else
                Me.Sell(r.日付)
            End If
        Next
    End Sub
End Class
