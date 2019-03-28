<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackTestForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgv企業情報 = New System.Windows.Forms.DataGridView()
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均5増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.売経過日数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.期間開始 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.期間終了 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.評価額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.現金 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.株数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.買値 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.売値 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chartPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.btnCondition = New System.Windows.Forms.Button()
        Me.rdo5 = New System.Windows.Forms.RadioButton()
        Me.rdo75 = New System.Windows.Forms.RadioButton()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv企業情報
        '
        Me.dgv企業情報.AllowUserToAddRows = False
        Me.dgv企業情報.AllowUserToDeleteRows = False
        Me.dgv企業情報.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv企業情報.ColumnHeadersHeight = 40
        Me.dgv企業情報.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.証券コード, Me.企業名, Me.移動平均5増減率, Me.売経過日数, Me.期間開始, Me.期間終了, Me.評価額})
        Me.dgv企業情報.Location = New System.Drawing.Point(12, 12)
        Me.dgv企業情報.Name = "dgv企業情報"
        Me.dgv企業情報.RowHeadersVisible = False
        Me.dgv企業情報.RowTemplate.Height = 24
        Me.dgv企業情報.Size = New System.Drawing.Size(485, 527)
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
        '移動平均5増減率
        '
        Me.移動平均5増減率.HeaderText = "移動平均5増減率"
        Me.移動平均5増減率.Name = "移動平均5増減率"
        Me.移動平均5増減率.Width = 50
        '
        '売経過日数
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.売経過日数.DefaultCellStyle = DataGridViewCellStyle1
        Me.売経過日数.HeaderText = "売経過日数"
        Me.売経過日数.Name = "売経過日数"
        Me.売経過日数.Width = 50
        '
        '期間開始
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.期間開始.DefaultCellStyle = DataGridViewCellStyle2
        Me.期間開始.HeaderText = "期間開始"
        Me.期間開始.Name = "期間開始"
        Me.期間開始.Width = 70
        '
        '期間終了
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.期間終了.DefaultCellStyle = DataGridViewCellStyle3
        Me.期間終了.HeaderText = "期間終了"
        Me.期間終了.Name = "期間終了"
        Me.期間終了.Width = 70
        '
        '評価額
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.評価額.DefaultCellStyle = DataGridViewCellStyle4
        Me.評価額.HeaderText = "評価額"
        Me.評価額.Name = "評価額"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.現金, Me.株数, Me.買値, Me.売値})
        Me.DataGridView1.Location = New System.Drawing.Point(503, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(172, 173)
        Me.DataGridView1.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "日付"
        Me.DataGridViewTextBoxColumn1.HeaderText = "日付"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "評価額"
        Me.DataGridViewTextBoxColumn2.HeaderText = "評価額"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        '現金
        '
        Me.現金.DataPropertyName = "現金"
        Me.現金.HeaderText = "現金"
        Me.現金.Name = "現金"
        '
        '株数
        '
        Me.株数.DataPropertyName = "株数"
        Me.株数.HeaderText = "株数"
        Me.株数.Name = "株数"
        '
        '買値
        '
        Me.買値.DataPropertyName = "買値"
        Me.買値.HeaderText = "買値"
        Me.買値.Name = "買値"
        '
        '売値
        '
        Me.売値.DataPropertyName = "売値"
        Me.売値.HeaderText = "売値"
        Me.売値.Name = "売値"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView2.Location = New System.Drawing.Point(681, 366)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(406, 173)
        Me.DataGridView2.TabIndex = 7
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "日付"
        Me.DataGridViewTextBoxColumn3.HeaderText = "日付"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "評価額"
        Me.DataGridViewTextBoxColumn4.HeaderText = "評価額"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "現金"
        Me.DataGridViewTextBoxColumn5.HeaderText = "現金"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "株数"
        Me.DataGridViewTextBoxColumn6.HeaderText = "株数"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "買値"
        Me.DataGridViewTextBoxColumn7.HeaderText = "買値"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "売値"
        Me.DataGridViewTextBoxColumn8.HeaderText = "売値"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
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
        Me.chartPrice.Location = New System.Drawing.Point(503, 39)
        Me.chartPrice.Name = "chartPrice"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPrice.Series.Add(Series1)
        Me.chartPrice.Size = New System.Drawing.Size(584, 321)
        Me.chartPrice.TabIndex = 8
        Me.chartPrice.Text = "Chart1"
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(503, 12)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(340, 22)
        Me.txtCondition.TabIndex = 9
        Me.txtCondition.Text = "G:\src\ルール1条件.csv"
        '
        'btnCondition
        '
        Me.btnCondition.Location = New System.Drawing.Point(850, 12)
        Me.btnCondition.Name = "btnCondition"
        Me.btnCondition.Size = New System.Drawing.Size(93, 23)
        Me.btnCondition.TabIndex = 10
        Me.btnCondition.Text = "条件読込"
        Me.btnCondition.UseVisualStyleBackColor = True
        '
        'rdo5
        '
        Me.rdo5.AutoSize = True
        Me.rdo5.Checked = True
        Me.rdo5.Location = New System.Drawing.Point(950, 15)
        Me.rdo5.Name = "rdo5"
        Me.rdo5.Size = New System.Drawing.Size(36, 19)
        Me.rdo5.TabIndex = 11
        Me.rdo5.TabStop = True
        Me.rdo5.Text = "5"
        Me.rdo5.UseVisualStyleBackColor = True
        '
        'rdo75
        '
        Me.rdo75.AutoSize = True
        Me.rdo75.Location = New System.Drawing.Point(1041, 13)
        Me.rdo75.Name = "rdo75"
        Me.rdo75.Size = New System.Drawing.Size(44, 19)
        Me.rdo75.TabIndex = 12
        Me.rdo75.Text = "75"
        Me.rdo75.UseVisualStyleBackColor = True
        '
        'BackTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 551)
        Me.Controls.Add(Me.rdo75)
        Me.Controls.Add(Me.rdo5)
        Me.Controls.Add(Me.btnCondition)
        Me.Controls.Add(Me.txtCondition)
        Me.Controls.Add(Me.chartPrice)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgv企業情報)
        Me.Name = "BackTestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackTestForm"
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv企業情報 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents 現金 As DataGridViewTextBoxColumn
    Friend WithEvents 株数 As DataGridViewTextBoxColumn
    Friend WithEvents 買値 As DataGridViewTextBoxColumn
    Friend WithEvents 売値 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents chartPrice As DataVisualization.Charting.Chart
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents btnCondition As Button
    Friend WithEvents 証券コード As DataGridViewTextBoxColumn
    Friend WithEvents 企業名 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均5増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 売経過日数 As DataGridViewTextBoxColumn
    Friend WithEvents 期間開始 As DataGridViewTextBoxColumn
    Friend WithEvents 期間終了 As DataGridViewTextBoxColumn
    Friend WithEvents 評価額 As DataGridViewTextBoxColumn
    Friend WithEvents rdo5 As RadioButton
    Friend WithEvents rdo75 As RadioButton
End Class
