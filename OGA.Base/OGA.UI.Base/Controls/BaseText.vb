Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports NLog
Imports OGA.Utility

<ToolboxItem(True)>
Public Class BaseText
    Inherits System.Windows.Forms.TextBox

    Private _InitBaseBackColor As System.Drawing.Color = System.Drawing.SystemColors.Window
    Private _InitFocusBackColor As System.Drawing.Color = System.Drawing.Color.LightBlue
    Private _InitReadOnlyBackColor As System.Drawing.Color = System.Drawing.SystemColors.ControlDark
    Private _InitFont As Font = New Font("ＭＳ ゴシック", 10)
    Private _InitMaxLineCnt As Decimal = 1
    Private alreadyFocused As Boolean


    Public Sub New()
        Initialize()
    End Sub

    Public Sub New(container As IContainer)
        Initialize()
    End Sub

#Region " BaseBackColor"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("BaseBackColor")>
    Public Property BaseBackColor As System.Drawing.Color
    ''' <summary>
    ''' BaseBackColorの既定値
    ''' </summary>
    ''' <returns></returns>
    Public Function ShouldSerializeBaseBackColor() As Boolean
        Return Not BaseBackColor.Equals(_InitBaseBackColor)
    End Function
    ''' <summary>
    ''' BaseBackColorのリセット値
    ''' </summary>
    Public Sub ResetBaseBackColor()
        BaseBackColor = _InitBaseBackColor
    End Sub
#End Region

#Region " FocusBackColor"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("FocusBackColor")>
    Public Property FocusBackColor As System.Drawing.Color
    ''' <summary>
    ''' FocusBackColorの既定値
    ''' </summary>
    ''' <returns></returns>
    Public Function ShouldSerializeFocusBackColor() As Boolean
        Return Not FocusBackColor.Equals(_InitFocusBackColor)
    End Function
    ''' <summary>
    ''' FocusBackColorのリセット値
    ''' </summary>
    Public Sub ResetFocusBackColor()
        FocusBackColor = _InitFocusBackColor
    End Sub
#End Region

#Region " ReadOnlyBackColor"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("ReadOnlyBackColor")>
    Public Property ReadOnlyBackColor As System.Drawing.Color
    ''' <summary>
    ''' ReadOnlyBackColorの既定値
    ''' </summary>
    ''' <returns></returns>
    Public Function ShouldSerializeReadOnlyBackColor() As Boolean
        Return Not ReadOnlyBackColor.Equals(_InitReadOnlyBackColor)
    End Function
    ''' <summary>
    ''' FocusBackColorのリセット値
    ''' </summary>
    Public Sub ResetReadOnlyBackColor()
        ReadOnlyBackColor = _InitReadOnlyBackColor
    End Sub
#End Region

#Region " ReadOnly"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("ReadOnly")>
    Public Shadows Property [ReadOnly] As Boolean
        Get
            Return MyBase.ReadOnly
        End Get
        Set(value As Boolean)
            '' 読取専用のときはTabStop=Falseにする
            MyBase.TabStop = Not value
            MyBase.ReadOnly = value
            If Me.ReadOnly = False Then
                If Me.Focused Then
                    '' フォーカス位置づいている
                    Me.BackColor = Me.FocusBackColor
                Else
                    '' フォーカス位置づいていない
                    Me.BackColor = Me.BaseBackColor
                End If
            Else
                Me.BackColor = Me.ReadOnlyBackColor
            End If
        End Set
    End Property

    ''' <summary>
    ''' ReadOnlyの既定値
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Function ShouldSerializeReadOnly() As Boolean
        Return Not [ReadOnly].Equals(False)
    End Function
    ''' <summary>
    ''' ReadOnlyのリセット値
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Sub ResetReadOnly()
        Me.ReadOnly = False
    End Sub
#End Region

#Region " Enabled"
    ''' <summary>
    ''' Enabledプロパティ
    ''' Browsable属性をFalseにしてプロパティウィンドウから消す
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <DisplayName("Enabled")>
    Public Shadows Property Enabled As Boolean
        Get
            Return MyBase.Enabled
        End Get
        Set(value As Boolean)
            MyBase.Enabled = value
        End Set
    End Property
#End Region

#Region " Multiline"
    ''' <summary>
    ''' Multilineプロパティ
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <DisplayName("Multiline")>
    Public Shadows Property Multiline As Boolean
        Get
            Return MyBase.Multiline
        End Get
        Set(value As Boolean)
            MyBase.WordWrap = False
            MyBase.Multiline = value
        End Set
    End Property
#End Region

#Region " Font"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("Font")>
    Public Shadows Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property

    ''' <summary>
    ''' ReadOnlyの既定値
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Function ShouldSerializeFont() As Boolean
        Return Not Font.Equals(_InitFont)
    End Function
#End Region

#Region " StrLength"
    ''' <summary>
    ''' 文字数
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("StrLength")>
    <Category("独自プロパティ")>
    <Description("テキストに入力された文字列の桁数を取得(サロゲートペア対応)")>
    Public Shadows ReadOnly Property StrLength As Decimal
        Get
            Return New System.Globalization.StringInfo(Me.Text).LengthInTextElements
        End Get
    End Property
#End Region

#Region " MaxLineCnt"
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DisplayName("MaxLineCnt")>
    Public Property MaxLineCnt As Decimal

    ''' <summary>
    ''' ReadOnlyの既定値
    ''' </summary>
    ''' <returns></returns>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Function ShouldSerializeMaxLineCnt() As Boolean
        Return Not MaxLineCnt.Equals(_InitMaxLineCnt)
    End Function
    ''' <summary>
    ''' ReadOnlyのリセット値
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Sub ResetMaxLineCnt()
        Me.MaxLineCnt = _InitMaxLineCnt
    End Sub
#End Region


    Protected Overrides Sub OnEnter(e As EventArgs)
        '' ログ出力
        LogUtil.LogInfo(LogUtil.LogText(Me.FindForm.Name, Me.Name, Me.Text))

        MyBase.OnEnter(e)
        If Me.ReadOnly = False Then
            '' 使用可能
            Me.BackColor = Me.FocusBackColor
            If MouseButtons = MouseButtons.None Then
                '' 全選択
                Me.SelectAll()
                alreadyFocused = True
            End If
        Else
            '' 読取専用
            Me.BackColor = Me.ReadOnlyBackColor
        End If
    End Sub

    ''' <summary>
    ''' OnMouseUp
    ''' マウスで選択時に全選択されないためMouseUpで全選択を処理する
    ''' </summary>
    ''' <param name="mevent"></param>
    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        If Me.ReadOnly = False Then
            If alreadyFocused = False AndAlso Me.SelectionLength = 0 Then
                '' 全選択
                Me.SelectAll()
            End If
            alreadyFocused = True
        End If
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        If Me.ReadOnly = False Then
            '' 使用可能
            Me.BackColor = Me.BaseBackColor
        Else
            '' 読取専用
            Me.BackColor = Me.ReadOnlyBackColor
        End If
        alreadyFocused = False

        '' ログ出力
        LogUtil.LogInfo(LogUtil.LogText(Me.FindForm.Name, Me.Name, Me.Text))
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        If Me.MultiLine AndAlso e.KeyChar = Chr(Keys.Enter) Then
            '' 最大行を超えない制限
            If Me.StrLength - New System.Globalization.StringInfo(Me.Text.Replace(Environment.NewLine, "")).LengthInTextElements >= (Me.MaxLineCnt - 1) * 2 Then
                e.Handled = True
                Return
            End If
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub Initialize()
        Me.BaseBackColor = _InitBaseBackColor
        Me.FocusBackColor = _InitFocusBackColor
        Me.ReadOnlyBackColor = _InitReadOnlyBackColor
        Me.Font = _InitFont
        Me.MaxLineCnt = _InitMaxLineCnt
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_PASTE As Integer = &H302

        Select Case m.Msg
            Case WM_PASTE
                '' 貼り付け
                Me.OnPaste(New System.EventArgs)
                Return

        End Select

        MyBase.WndProc(m)

    End Sub

    Protected Overridable Sub OnPaste(e As System.EventArgs)
        Dim cliplen = clipboardStrLength()
        Dim start = Me.SelectionStart
        Dim pasteStr As String = pasteText()
        If PasteCheck(pasteStr) = False Then
            Return
        End If
        Me.Text = pasteStr
        Me.SelectionStart = start + cliplen
    End Sub

    Protected Overridable Function PasteCheck(pasteStr As String) As Boolean
        If Me.Multiline Then
            '' 最大行を超えない制限
            If New System.Globalization.StringInfo(pasteStr).LengthInTextElements _
                - New System.Globalization.StringInfo(pasteStr.Replace(Environment.NewLine, "")).LengthInTextElements >= Me.MaxLineCnt * 2 Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Function clipboardStrLength() As Integer
        Dim strClipboard As String = ""
        'Dim iData As IDataObject = Clipboard.GetDataObject()
        'If iData.GetDataPresent(DataFormats.UnicodeText) Then
        '    strClipboard = Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString()
        'End If
        If (Clipboard.ContainsText) Then
            strClipboard = Clipboard.GetText
        End If
        Return New System.Globalization.StringInfo(strClipboard).LengthInTextElements
    End Function

    Protected Overridable Function pasteText() As String
        Dim strClipboard As String = ""
        'Dim iData As IDataObject = Clipboard.GetDataObject()
        'If iData.GetDataPresent(DataFormats.UnicodeText) Then
        '    strClipboard = Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString()
        'End If
        If (Clipboard.ContainsText) Then
            strClipboard = Clipboard.GetText
        End If
        Dim start = Me.SelectionStart
        Dim strText = Me.Text
        strText = strText.Remove(start, Me.SelectionLength)
        strText = strText.Insert(start, strClipboard)
        Return strText
    End Function

    'イベント順番
    'Enter Event
    'GotFocus Event
    'TextChanged Event
    'Leave Event
    'Validating Event
    'Validated Event
    'LostFocus Event

End Class
