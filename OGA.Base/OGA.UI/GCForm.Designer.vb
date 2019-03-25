<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GCForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv企業情報 = New System.Windows.Forms.DataGridView()
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chartPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvゴールデンクロス = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp終了 = New System.Windows.Forms.DateTimePicker()
        Me.dtp開始 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvゴールデンクロス, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv企業情報
        '
        Me.dgv企業情報.AllowUserToAddRows = False
        Me.dgv企業情報.AllowUserToDeleteRows = False
        Me.dgv企業情報.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv企業情報.ColumnHeadersHeight = 40
        Me.dgv企業情報.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.証券コード, Me.企業名})
        Me.dgv企業情報.Location = New System.Drawing.Point(12, 12)
        Me.dgv企業情報.Name = "dgv企業情報"
        Me.dgv企業情報.RowHeadersVisible = False
        Me.dgv企業情報.RowTemplate.Height = 24
        Me.dgv企業情報.Size = New System.Drawing.Size(171, 524)
        Me.dgv企業情報.TabIndex = 5
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
        'chartPrice
        '
        Me.chartPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.chartPrice.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartPrice.Legends.Add(Legend2)
        Me.chartPrice.Location = New System.Drawing.Point(189, 195)
        Me.chartPrice.Name = "chartPrice"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartPrice.Series.Add(Series2)
        Me.chartPrice.Size = New System.Drawing.Size(832, 341)
        Me.chartPrice.TabIndex = 6
        Me.chartPrice.Text = "Chart1"
        '
        'dgvゴールデンクロス
        '
        Me.dgvゴールデンクロス.AllowUserToAddRows = False
        Me.dgvゴールデンクロス.AllowUserToDeleteRows = False
        Me.dgvゴールデンクロス.AllowUserToResizeColumns = False
        Me.dgvゴールデンクロス.AllowUserToResizeRows = False
        Me.dgvゴールデンクロス.ColumnHeadersHeight = 40
        Me.dgvゴールデンクロス.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.日付})
        Me.dgvゴールデンクロス.Location = New System.Drawing.Point(189, 12)
        Me.dgvゴールデンクロス.Name = "dgvゴールデンクロス"
        Me.dgvゴールデンクロス.RowHeadersVisible = False
        Me.dgvゴールデンクロス.RowTemplate.Height = 24
        Me.dgvゴールデンクロス.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvゴールデンクロス.Size = New System.Drawing.Size(280, 177)
        Me.dgvゴールデンクロス.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "証券コード"
        Me.DataGridViewTextBoxColumn1.HeaderText = "証券コード"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "企業名"
        Me.DataGridViewTextBoxColumn2.HeaderText = "企業名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        '日付
        '
        Me.日付.DataPropertyName = "日付"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.日付.DefaultCellStyle = DataGridViewCellStyle2
        Me.日付.HeaderText = "日付"
        Me.日付.Name = "日付"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(608, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "～"
        '
        'dtp終了
        '
        Me.dtp終了.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp終了.Location = New System.Drawing.Point(637, 167)
        Me.dtp終了.Name = "dtp終了"
        Me.dtp終了.Size = New System.Drawing.Size(127, 22)
        Me.dtp終了.TabIndex = 8
        '
        'dtp開始
        '
        Me.dtp開始.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp開始.Location = New System.Drawing.Point(475, 167)
        Me.dtp開始.Name = "dtp開始"
        Me.dtp開始.Size = New System.Drawing.Size(127, 22)
        Me.dtp開始.TabIndex = 9
        '
        'GCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 548)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp終了)
        Me.Controls.Add(Me.dtp開始)
        Me.Controls.Add(Me.dgvゴールデンクロス)
        Me.Controls.Add(Me.chartPrice)
        Me.Controls.Add(Me.dgv企業情報)
        Me.Name = "GCForm"
        Me.Text = "ゴールデンクロス"
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvゴールデンクロス, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv企業情報 As DataGridView
    Friend WithEvents 証券コード As DataGridViewTextBoxColumn
    Friend WithEvents 企業名 As DataGridViewTextBoxColumn
    Friend WithEvents chartPrice As DataVisualization.Charting.Chart
    Friend WithEvents dgvゴールデンクロス As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents 日付 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp終了 As DateTimePicker
    Friend WithEvents dtp開始 As DateTimePicker
End Class
