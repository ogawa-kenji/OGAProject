Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports NLog
Imports OGA.Utility

<ToolboxItem(True)>
Public Class BaseNumber
    Inherits BaseText

    Public Sub New()
        MyBase.New()
        Initialize()
    End Sub

    Public Sub New(container As IContainer)
        MyBase.New(container)
        Initialize()
    End Sub

#Region " ImeMode"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("ImeMode")>
    Public Shadows Property ImeMode As ImeMode
        Get
            Return MyBase.ImeMode
        End Get
        Set(value As ImeMode)
            MyBase.ImeMode = value
        End Set
    End Property

    ''' <summary>
    ''' ReadOnlyの既定値
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Function ShouldSerializeImeMode() As Boolean
        Return Not ImeMode.Equals(ImeMode.Disable)
    End Function
    ''' <summary>
    ''' ReadOnlyのリセット値
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shadows Sub ResetImeMode()
        Me.ImeMode = ImeMode.Disable
    End Sub
#End Region

#Region " Multiline"
    ''' <summary>
    ''' Multilineプロパティ
    ''' Browsable属性をFalseにしてプロパティウィンドウから消す
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <DisplayName("Multiline")>
    Public Shadows Property Multiline As Boolean
        Get
            Return MyBase.Multiline
        End Get
        Set(value As Boolean)
            MyBase.Multiline = value
        End Set
    End Property
#End Region

#Region " NumValue"
    Private _NumValue As Decimal?
    ''' <summary>
    ''' 文字数
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("NumValue")>
    <Category("独自プロパティ")>
    <Description("テキストに入力された文字列の数値を取得／設定")>
    Public Property NumValue As Decimal?
        Get
            Dim returnNum As Decimal? = Nothing
            Dim num As Decimal
            If Decimal.TryParse(Me.Text, num) Then
                returnNum = num
            End If
            _NumValue = returnNum
            Return _NumValue
        End Get
        Set(value As Decimal?)
            _NumValue = value
            If _NumValue.HasValue Then
                Dim decStr As String = StrDup(DecimalPlaces, "#")
                Me.Text = _NumValue.Value.ToString("#,##0." & decStr).TrimEnd("."c)
            Else
                Me.Text = ""
            End If
        End Set
    End Property
#End Region

#Region " DecimalPlaces"
    Private _DecimalPlacese As Integer
    ''' <summary>
    ''' 小数部桁数
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("DecimalPlaces")>
    <Category("独自プロパティ")>
    <Description("小数部の桁数を取得／設定")>
    Public Property DecimalPlaces As Integer
        Get
            Return _DecimalPlacese
        End Get
        Set(value As Integer)
            If value < 0 Then
                _DecimalPlacese = 0
            Else
                _DecimalPlacese = value
            End If
        End Set
    End Property
#End Region

#Region " IntegerPlaces"
    Private _IntegerPlaces As Integer
    ''' <summary>
    ''' 整数部桁数
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("IntegerPlaces")>
    <Category("独自プロパティ")>
    <Description("整数部の桁数を取得／設定")>
    Public Property IntegerPlaces As Integer
        Get
            Return _IntegerPlaces
        End Get
        Set(value As Integer)
            If value < 0 Then
                _IntegerPlaces = 0
            Else
                _IntegerPlaces = value
            End If
        End Set
    End Property
#End Region

    Protected Overrides Sub OnEnter(e As EventArgs)
        Dim num As Decimal
        If Decimal.TryParse(Me.Text, num) Then
            Me.Text = num.ToString()
        End If
        MyBase.OnEnter(e)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        If Me.NumValue.HasValue AndAlso Me.NumValue.Value < 0 Then
            Me.ForeColor = Color.Red
        Else
            Me.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Initialize()
        Me.ImeMode = ImeMode.Disable
    End Sub

    Protected Overrides Sub OnValidated(e As EventArgs)
        MyBase.OnValidated(e)
        Dim num As Decimal
        If Decimal.TryParse(Me.Text, num) Then
            Dim decStr As String = StrDup(DecimalPlaces, "#")
            Me.Text = num.ToString("#,##0." & decStr).TrimEnd("."c)
        Else
            Me.Text = ""
        End If
    End Sub

End Class
