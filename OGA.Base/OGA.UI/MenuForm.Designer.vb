<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.lblUpdate = New System.Windows.Forms.LinkLabel()
        Me.lblChart = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblBackTest = New System.Windows.Forms.LinkLabel()
        Me.lblAleart = New System.Windows.Forms.LinkLabel()
        Me.lblGoldenCross = New System.Windows.Forms.LinkLabel()
        Me.lblBackTest2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Location = New System.Drawing.Point(13, 13)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(81, 15)
        Me.lblUpdate.TabIndex = 0
        Me.lblUpdate.TabStop = True
        Me.lblUpdate.Text = "更新フォーム"
        '
        'lblChart
        '
        Me.lblChart.AutoSize = True
        Me.lblChart.Location = New System.Drawing.Point(13, 47)
        Me.lblChart.Name = "lblChart"
        Me.lblChart.Size = New System.Drawing.Size(96, 15)
        Me.lblChart.TabIndex = 0
        Me.lblChart.TabStop = True
        Me.lblChart.Text = "チャートフォーム"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 84)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 15)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "テストフォーム"
        '
        'lblBackTest
        '
        Me.lblBackTest.AutoSize = True
        Me.lblBackTest.Location = New System.Drawing.Point(13, 123)
        Me.lblBackTest.Name = "lblBackTest"
        Me.lblBackTest.Size = New System.Drawing.Size(116, 15)
        Me.lblBackTest.TabIndex = 2
        Me.lblBackTest.TabStop = True
        Me.lblBackTest.Text = "バックテストフォーム"
        '
        'lblAleart
        '
        Me.lblAleart.AutoSize = True
        Me.lblAleart.Location = New System.Drawing.Point(13, 162)
        Me.lblAleart.Name = "lblAleart"
        Me.lblAleart.Size = New System.Drawing.Size(95, 15)
        Me.lblAleart.TabIndex = 3
        Me.lblAleart.TabStop = True
        Me.lblAleart.Text = "アラートフォーム"
        '
        'lblGoldenCross
        '
        Me.lblGoldenCross.AutoSize = True
        Me.lblGoldenCross.Location = New System.Drawing.Point(14, 206)
        Me.lblGoldenCross.Name = "lblGoldenCross"
        Me.lblGoldenCross.Size = New System.Drawing.Size(142, 15)
        Me.lblGoldenCross.TabIndex = 4
        Me.lblGoldenCross.TabStop = True
        Me.lblGoldenCross.Text = "ゴールデンクロスフォーム"
        '
        'lblBackTest2
        '
        Me.lblBackTest2.AutoSize = True
        Me.lblBackTest2.Location = New System.Drawing.Point(171, 123)
        Me.lblBackTest2.Name = "lblBackTest2"
        Me.lblBackTest2.Size = New System.Drawing.Size(124, 15)
        Me.lblBackTest2.TabIndex = 5
        Me.lblBackTest2.TabStop = True
        Me.lblBackTest2.Text = "バックテスト2フォーム"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBackTest2)
        Me.Controls.Add(Me.lblGoldenCross)
        Me.Controls.Add(Me.lblAleart)
        Me.Controls.Add(Me.lblBackTest)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblChart)
        Me.Controls.Add(Me.lblUpdate)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpdate As LinkLabel
    Friend WithEvents lblChart As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblBackTest As LinkLabel
    Friend WithEvents lblAleart As LinkLabel
    Friend WithEvents lblGoldenCross As LinkLabel
    Friend WithEvents lblBackTest2 As LinkLabel
End Class
