<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BaseText2 = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText1 = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText3 = New OGA.UI.Base.BaseText(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BaseText2
        '
        Me.BaseText2.Location = New System.Drawing.Point(549, 117)
        Me.BaseText2.Name = "BaseText2"
        Me.BaseText2.Size = New System.Drawing.Size(100, 22)
        Me.BaseText2.TabIndex = 5
        '
        'BaseText1
        '
        Me.BaseText1.BaseBackColor = System.Drawing.Color.Empty
        Me.BaseText1.Location = New System.Drawing.Point(503, 197)
        Me.BaseText1.Name = "BaseText1"
        Me.BaseText1.Size = New System.Drawing.Size(100, 22)
        Me.BaseText1.TabIndex = 4
        '
        'BaseText3
        '
        Me.BaseText3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BaseText3.BaseBackColor = System.Drawing.Color.Empty
        Me.BaseText3.Location = New System.Drawing.Point(503, 251)
        Me.BaseText3.Name = "BaseText3"
        Me.BaseText3.ReadOnly = True
        Me.BaseText3.Size = New System.Drawing.Size(100, 22)
        Me.BaseText3.TabIndex = 6
        Me.BaseText3.TabStop = False
        Me.BaseText3.Text = "123"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(391, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BaseText3)
        Me.Controls.Add(Me.BaseText2)
        Me.Controls.Add(Me.BaseText1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BaseText1 As Base.BaseText
    Friend WithEvents BaseText2 As Base.BaseText
    Friend WithEvents BaseText3 As Base.BaseText
    Friend WithEvents Button5 As Button
End Class
