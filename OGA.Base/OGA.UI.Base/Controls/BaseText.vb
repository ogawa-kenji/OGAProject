Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxItem("TextBox")>
Public Class BaseText
    Inherits System.Windows.Forms.TextBox

    Private _InitBaseBackColor As System.Drawing.Color = System.Drawing.SystemColors.Window
    Private _InitFocusBackColor As System.Drawing.Color = System.Drawing.Color.LightBlue
    Private _InitReadOnlyBackColor As System.Drawing.Color = System.Drawing.SystemColors.ControlDark
    Private _InitFont As Font
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

    Protected Overrides Sub OnEnter(e As EventArgs)
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
                alreadyFocused = True
            End If
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
    End Sub

    Private Sub Initialize()
        Me.BaseBackColor = _InitBaseBackColor
        Me.FocusBackColor = _InitFocusBackColor
        Me.ReadOnlyBackColor = _InitReadOnlyBackColor
    End Sub

End Class
