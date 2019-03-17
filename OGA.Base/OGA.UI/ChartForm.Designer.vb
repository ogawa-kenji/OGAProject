<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.chartPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgv企業情報 = New System.Windows.Forms.DataGridView()
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(325, 22)
        Me.TextBox1.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "◀"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(64, 14)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(45, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "▶"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'chartPrice
        '
        Me.chartPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chartPrice.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartPrice.Legends.Add(Legend1)
        Me.chartPrice.Location = New System.Drawing.Point(190, 43)
        Me.chartPrice.Name = "chartPrice"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPrice.Series.Add(Series1)
        Me.chartPrice.Size = New System.Drawing.Size(598, 395)
        Me.chartPrice.TabIndex = 3
        Me.chartPrice.Text = "Chart1"
        '
        'dgv企業情報
        '
        Me.dgv企業情報.AllowUserToAddRows = False
        Me.dgv企業情報.AllowUserToDeleteRows = False
        Me.dgv企業情報.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv企業情報.ColumnHeadersHeight = 40
        Me.dgv企業情報.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.証券コード, Me.企業名})
        Me.dgv企業情報.Location = New System.Drawing.Point(13, 43)
        Me.dgv企業情報.Name = "dgv企業情報"
        Me.dgv企業情報.RowHeadersVisible = False
        Me.dgv企業情報.RowTemplate.Height = 24
        Me.dgv企業情報.Size = New System.Drawing.Size(171, 395)
        Me.dgv企業情報.TabIndex = 4
        '
        '証券コード
        '
        Me.証券コード.DataPropertyName = "証券コード"
        Me.証券コード.HeaderText = "証券コード"
        Me.証券コード.Name = "証券コード"
        Me.証券コード.ReadOnly = True
        Me.証券コード.Width = 50
        '
        '企業名
        '
        Me.企業名.DataPropertyName = "企業名"
        Me.企業名.HeaderText = "企業名"
        Me.企業名.Name = "企業名"
        Me.企業名.ReadOnly = True
        '
        'dtp開始
        '
        Me.dtp開始.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp開始.Location = New System.Drawing.Point(447, 15)
        Me.dtp開始.Name = "dtp開始"
        Me.dtp開始.Size = New System.Drawing.Size(127, 22)
        Me.dtp開始.TabIndex = 5
        '
        'dtp終了
        '
        Me.dtp終了.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp終了.Location = New System.Drawing.Point(609, 15)
        Me.dtp終了.Name = "dtp終了"
        Me.dtp終了.Size = New System.Drawing.Size(127, 22)
        Me.dtp終了.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(580, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "～"
        '
        'ChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp終了)
        Me.Controls.Add(Me.dtp開始)
        Me.Controls.Add(Me.dgv企業情報)
        Me.Controls.Add(Me.chartPrice)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ChartForm"
        Me.Text = "チャートフォーム"
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents chartPrice As DataVisualization.Charting.Chart
    Friend WithEvents dgv企業情報 As DataGridView
    Friend WithEvents 証券コード As DataGridViewTextBoxColumn
    Friend WithEvents 企業名 As DataGridViewTextBoxColumn
    Friend WithEvents dtp開始 As DateTimePicker
    Friend WithEvents dtp終了 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
