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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.dgvCSV = New System.Windows.Forms.DataGridView()
        Me.BaseNumber1 = New OGA.UI.Base.BaseNumber(Me.components)
        Me.BaseText5 = New OGA.UI.Base.BaseText(Me.components)
        Me.txtCSV = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText4 = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText3 = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText2 = New OGA.UI.Base.BaseText(Me.components)
        Me.BaseText1 = New OGA.UI.Base.BaseText(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(445, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(870, 43)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(75, 23)
        Me.btnCSV.TabIndex = 10
        Me.btnCSV.Text = "CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'dgvCSV
        '
        Me.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSV.Location = New System.Drawing.Point(339, 72)
        Me.dgvCSV.Name = "dgvCSV"
        Me.dgvCSV.RowTemplate.Height = 24
        Me.dgvCSV.Size = New System.Drawing.Size(669, 339)
        Me.dgvCSV.TabIndex = 11
        '
        'BaseNumber1
        '
        Me.BaseNumber1.DecimalPlaces = 5
        Me.BaseNumber1.ForeColor = System.Drawing.Color.Black
        Me.BaseNumber1.IntegerPlaces = 0
        Me.BaseNumber1.Location = New System.Drawing.Point(43, 321)
        Me.BaseNumber1.Name = "BaseNumber1"
        Me.BaseNumber1.NumValue = New Decimal(New Integer() {-539246433, 2, 0, 0})
        Me.BaseNumber1.Size = New System.Drawing.Size(199, 24)
        Me.BaseNumber1.TabIndex = 13
        Me.BaseNumber1.Text = "12,345,655,455"
        Me.BaseNumber1.WordWrap = False
        '
        'BaseText5
        '
        Me.BaseText5.Location = New System.Drawing.Point(394, 415)
        Me.BaseText5.Name = "BaseText5"
        Me.BaseText5.Size = New System.Drawing.Size(159, 24)
        Me.BaseText5.TabIndex = 12
        Me.BaseText5.WordWrap = False
        '
        'txtCSV
        '
        Me.txtCSV.Location = New System.Drawing.Point(445, 42)
        Me.txtCSV.Name = "txtCSV"
        Me.txtCSV.Size = New System.Drawing.Size(419, 24)
        Me.txtCSV.TabIndex = 9
        Me.txtCSV.WordWrap = False
        '
        'BaseText4
        '
        Me.BaseText4.Location = New System.Drawing.Point(339, 42)
        Me.BaseText4.Name = "BaseText4"
        Me.BaseText4.Size = New System.Drawing.Size(100, 24)
        Me.BaseText4.TabIndex = 8
        Me.BaseText4.Text = "𩸽𩸽"
        Me.BaseText4.WordWrap = False
        '
        'BaseText3
        '
        Me.BaseText3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BaseText3.BaseBackColor = System.Drawing.Color.Empty
        Me.BaseText3.Location = New System.Drawing.Point(526, 12)
        Me.BaseText3.Name = "BaseText3"
        Me.BaseText3.ReadOnly = True
        Me.BaseText3.Size = New System.Drawing.Size(100, 24)
        Me.BaseText3.TabIndex = 6
        Me.BaseText3.TabStop = False
        Me.BaseText3.Text = "123"
        Me.BaseText3.WordWrap = False
        '
        'BaseText2
        '
        Me.BaseText2.Location = New System.Drawing.Point(117, 12)
        Me.BaseText2.MaxLineCnt = New Decimal(New Integer() {5, 0, 0, 0})
        Me.BaseText2.Multiline = True
        Me.BaseText2.Name = "BaseText2"
        Me.BaseText2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BaseText2.Size = New System.Drawing.Size(194, 132)
        Me.BaseText2.TabIndex = 5
        Me.BaseText2.WordWrap = False
        '
        'BaseText1
        '
        Me.BaseText1.BaseBackColor = System.Drawing.Color.Empty
        Me.BaseText1.Location = New System.Drawing.Point(339, 12)
        Me.BaseText1.Name = "BaseText1"
        Me.BaseText1.Size = New System.Drawing.Size(100, 24)
        Me.BaseText1.TabIndex = 4
        Me.BaseText1.Text = "森鷗外"
        Me.BaseText1.WordWrap = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 128)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BaseNumber1)
        Me.Controls.Add(Me.BaseText5)
        Me.Controls.Add(Me.dgvCSV)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.txtCSV)
        Me.Controls.Add(Me.BaseText4)
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
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BaseText2 As Base.BaseText
    Friend WithEvents BaseText3 As Base.BaseText
    Friend WithEvents Button5 As Button
    Friend WithEvents BaseText4 As Base.BaseText
    Friend WithEvents BaseText1 As Base.BaseText
    Friend WithEvents txtCSV As Base.BaseText
    Friend WithEvents btnCSV As Button
    Friend WithEvents dgvCSV As DataGridView
    Friend WithEvents BaseText5 As Base.BaseText
    Friend WithEvents BaseNumber1 As Base.BaseNumber
    Friend WithEvents Button6 As Button
End Class
