<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackTestForm2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv企業情報 = New System.Windows.Forms.DataGridView()
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
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均開始5増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均5終了増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均25開始増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均25終了増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均75開始増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.移動平均75終了増減率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.売経過日数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.期間開始 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.期間終了 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.評価額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv企業情報.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.証券コード, Me.企業名, Me.移動平均開始5増減率, Me.移動平均5終了増減率, Me.移動平均25開始増減率, Me.移動平均25終了増減率, Me.移動平均75開始増減率, Me.移動平均75終了増減率, Me.売経過日数, Me.期間開始, Me.期間終了, Me.評価額})
        Me.dgv企業情報.Location = New System.Drawing.Point(12, 12)
        Me.dgv企業情報.Name = "dgv企業情報"
        Me.dgv企業情報.RowHeadersVisible = False
        Me.dgv企業情報.RowTemplate.Height = 24
        Me.dgv企業情報.Size = New System.Drawing.Size(663, 527)
        Me.dgv企業情報.TabIndex = 5
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
        Me.chartPrice.Location = New System.Drawing.Point(681, 41)
        Me.chartPrice.Name = "chartPrice"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPrice.Series.Add(Series1)
        Me.chartPrice.Size = New System.Drawing.Size(406, 319)
        Me.chartPrice.TabIndex = 8
        Me.chartPrice.Text = "Chart1"
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(681, 12)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(162, 22)
        Me.txtCondition.TabIndex = 9
        Me.txtCondition.Text = "G:\src\ルール2_1条件.csv"
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
        '移動平均開始5増減率
        '
        Me.移動平均開始5増減率.HeaderText = "5開始"
        Me.移動平均開始5増減率.Name = "移動平均開始5増減率"
        Me.移動平均開始5増減率.Width = 45
        '
        '移動平均5終了増減率
        '
        Me.移動平均5終了増減率.HeaderText = "移動平均5終了増減率"
        Me.移動平均5終了増減率.Name = "移動平均5終了増減率"
        Me.移動平均5終了増減率.Width = 45
        '
        '移動平均25開始増減率
        '
        Me.移動平均25開始増減率.HeaderText = "移動平均25開始増減率"
        Me.移動平均25開始増減率.Name = "移動平均25開始増減率"
        Me.移動平均25開始増減率.Width = 45
        '
        '移動平均25終了増減率
        '
        Me.移動平均25終了増減率.HeaderText = "移動平均25終了増減率"
        Me.移動平均25終了増減率.Name = "移動平均25終了増減率"
        Me.移動平均25終了増減率.Width = 45
        '
        '移動平均75開始増減率
        '
        Me.移動平均75開始増減率.HeaderText = "移動平均75開始増減率"
        Me.移動平均75開始増減率.Name = "移動平均75開始増減率"
        Me.移動平均75開始増減率.Width = 45
        '
        '移動平均75終了増減率
        '
        Me.移動平均75終了増減率.HeaderText = "移動平均75終了増減率"
        Me.移動平均75終了増減率.Name = "移動平均75終了増減率"
        Me.移動平均75終了増減率.Width = 45
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
        'BackTestForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 551)
        Me.Controls.Add(Me.btnCondition)
        Me.Controls.Add(Me.txtCondition)
        Me.Controls.Add(Me.chartPrice)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.dgv企業情報)
        Me.Name = "BackTestForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackTestForm"
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv企業情報 As DataGridView
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
    Friend WithEvents 移動平均開始5増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均5終了増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均25開始増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均25終了増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均75開始増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 移動平均75終了増減率 As DataGridViewTextBoxColumn
    Friend WithEvents 売経過日数 As DataGridViewTextBoxColumn
    Friend WithEvents 期間開始 As DataGridViewTextBoxColumn
    Friend WithEvents 期間終了 As DataGridViewTextBoxColumn
    Friend WithEvents 評価額 As DataGridViewTextBoxColumn
End Class
