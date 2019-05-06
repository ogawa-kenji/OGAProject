Public Class ルール
    Public Class ルール1
        Public Property 移動平均5増減率 As Decimal
        Public Property 移動平均75増減率 As Decimal
        Public Property 売経過日数 As Decimal
        Public Property 期間開始 As DateTime
        Public Property 期間終了 As DateTime
    End Class

    Public Class ルール4
        Public Property 移動平均5開始増減率 As Decimal
        Public Property 移動平均5終了増減率 As Decimal
        Public Property 移動平均25開始増減率 As Decimal
        Public Property 移動平均25終了増減率 As Decimal
        Public Property 移動平均75開始増減率 As Decimal
        Public Property 移動平均75終了増減率 As Decimal
        Public Property 売経過日数 As Decimal
        Public Property 期間開始 As DateTime
        Public Property 期間終了 As DateTime
    End Class


    Public Class ルール5
        Public Property 移動平均5開始増減率 As Decimal?
        Public Property 移動平均5終了増減率 As Decimal?
        Public Property 移動平均25開始増減率 As Decimal?
        Public Property 移動平均25終了増減率 As Decimal?
        Public Property 移動平均75開始増減率 As Decimal?
        Public Property 移動平均75終了増減率 As Decimal?
        Public Property 期間開始 As DateTime
        Public Property 期間終了 As DateTime
    End Class

End Class
