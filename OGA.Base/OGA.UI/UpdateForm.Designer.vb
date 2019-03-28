<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn企業情報更新 = New System.Windows.Forms.Button()
        Me.txt更新時間 = New System.Windows.Forms.RichTextBox()
        Me.btn株価更新 = New System.Windows.Forms.Button()
        Me.btn個別更新 = New System.Windows.Forms.Button()
        Me.txt証券コード = New System.Windows.Forms.TextBox()
        Me.btn個別削除 = New System.Windows.Forms.Button()
        Me.txt削除証券コード = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn企業情報更新
        '
        Me.btn企業情報更新.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn企業情報更新.Location = New System.Drawing.Point(13, 13)
        Me.btn企業情報更新.Name = "btn企業情報更新"
        Me.btn企業情報更新.Size = New System.Drawing.Size(227, 47)
        Me.btn企業情報更新.TabIndex = 0
        Me.btn企業情報更新.Text = "企業情報更新"
        Me.btn企業情報更新.UseVisualStyleBackColor = True
        '
        'txt更新時間
        '
        Me.txt更新時間.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt更新時間.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt更新時間.Location = New System.Drawing.Point(246, 13)
        Me.txt更新時間.Name = "txt更新時間"
        Me.txt更新時間.Size = New System.Drawing.Size(610, 216)
        Me.txt更新時間.TabIndex = 1
        Me.txt更新時間.Text = ""
        '
        'btn株価更新
        '
        Me.btn株価更新.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn株価更新.Location = New System.Drawing.Point(13, 66)
        Me.btn株価更新.Name = "btn株価更新"
        Me.btn株価更新.Size = New System.Drawing.Size(227, 47)
        Me.btn株価更新.TabIndex = 2
        Me.btn株価更新.Text = "株価更新"
        Me.btn株価更新.UseVisualStyleBackColor = True
        '
        'btn個別更新
        '
        Me.btn個別更新.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn個別更新.Location = New System.Drawing.Point(12, 119)
        Me.btn個別更新.Name = "btn個別更新"
        Me.btn個別更新.Size = New System.Drawing.Size(141, 47)
        Me.btn個別更新.TabIndex = 3
        Me.btn個別更新.Text = "個別更新"
        Me.btn個別更新.UseVisualStyleBackColor = True
        '
        'txt証券コード
        '
        Me.txt証券コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt証券コード.Location = New System.Drawing.Point(159, 124)
        Me.txt証券コード.MaxLength = 4
        Me.txt証券コード.Name = "txt証券コード"
        Me.txt証券コード.Size = New System.Drawing.Size(81, 37)
        Me.txt証券コード.TabIndex = 4
        '
        'btn個別削除
        '
        Me.btn個別削除.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn個別削除.Location = New System.Drawing.Point(13, 172)
        Me.btn個別削除.Name = "btn個別削除"
        Me.btn個別削除.Size = New System.Drawing.Size(141, 47)
        Me.btn個別削除.TabIndex = 3
        Me.btn個別削除.Text = "個別削除"
        Me.btn個別削除.UseVisualStyleBackColor = True
        '
        'txt削除証券コード
        '
        Me.txt削除証券コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt削除証券コード.Location = New System.Drawing.Point(160, 177)
        Me.txt削除証券コード.MaxLength = 4
        Me.txt削除証券コード.Name = "txt削除証券コード"
        Me.txt削除証券コード.Size = New System.Drawing.Size(81, 37)
        Me.txt削除証券コード.TabIndex = 4
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 241)
        Me.Controls.Add(Me.txt削除証券コード)
        Me.Controls.Add(Me.txt証券コード)
        Me.Controls.Add(Me.btn個別削除)
        Me.Controls.Add(Me.btn個別更新)
        Me.Controls.Add(Me.btn株価更新)
        Me.Controls.Add(Me.txt更新時間)
        Me.Controls.Add(Me.btn企業情報更新)
        Me.Name = "UpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "更新"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn企業情報更新 As Button
    Friend WithEvents txt更新時間 As RichTextBox
    Friend WithEvents btn株価更新 As Button
    Friend WithEvents btn個別更新 As Button
    Friend WithEvents txt証券コード As TextBox
    Friend WithEvents btn個別削除 As Button
    Friend WithEvents txt削除証券コード As TextBox
End Class
