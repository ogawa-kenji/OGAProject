<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockPriceChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk25 = New System.Windows.Forms.CheckBox()
        Me.chk75 = New System.Windows.Forms.CheckBox()
        Me.chk200 = New System.Windows.Forms.CheckBox()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.chartPrice.Location = New System.Drawing.Point(206, 43)
        Me.chartPrice.Name = "chartPrice"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPrice.Series.Add(Series1)
        Me.chartPrice.Size = New System.Drawing.Size(582, 570)
        Me.chartPrice.TabIndex = 3
        Me.chartPrice.Text = "Chart1"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvList.ColumnHeadersHeight = 40
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.証券コード, Me.企業名})
        Me.dgvList.Location = New System.Drawing.Point(13, 43)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowTemplate.Height = 24
        Me.dgvList.Size = New System.Drawing.Size(187, 570)
        Me.dgvList.TabIndex = 4
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
        Me.dtp開始.Location = New System.Drawing.Point(206, 12)
        Me.dtp開始.Name = "dtp開始"
        Me.dtp開始.Size = New System.Drawing.Size(127, 22)
        Me.dtp開始.TabIndex = 5
        '
        'dtp終了
        '
        Me.dtp終了.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp終了.Location = New System.Drawing.Point(368, 12)
        Me.dtp終了.Name = "dtp終了"
        Me.dtp終了.Size = New System.Drawing.Size(127, 22)
        Me.dtp終了.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "～"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(13, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(187, 22)
        Me.txtFilter.TabIndex = 7
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(501, 14)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(37, 19)
        Me.chk5.TabIndex = 8
        Me.chk5.Text = "5"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk25
        '
        Me.chk25.AutoSize = True
        Me.chk25.Location = New System.Drawing.Point(544, 14)
        Me.chk25.Name = "chk25"
        Me.chk25.Size = New System.Drawing.Size(45, 19)
        Me.chk25.TabIndex = 8
        Me.chk25.Text = "25"
        Me.chk25.UseVisualStyleBackColor = True
        '
        'chk75
        '
        Me.chk75.AutoSize = True
        Me.chk75.Location = New System.Drawing.Point(595, 14)
        Me.chk75.Name = "chk75"
        Me.chk75.Size = New System.Drawing.Size(45, 19)
        Me.chk75.TabIndex = 8
        Me.chk75.Text = "75"
        Me.chk75.UseVisualStyleBackColor = True
        '
        'chk200
        '
        Me.chk200.AutoSize = True
        Me.chk200.Location = New System.Drawing.Point(646, 14)
        Me.chk200.Name = "chk200"
        Me.chk200.Size = New System.Drawing.Size(53, 19)
        Me.chk200.TabIndex = 8
        Me.chk200.Text = "200"
        Me.chk200.UseVisualStyleBackColor = True
        '
        'StockPriceChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 625)
        Me.Controls.Add(Me.chk200)
        Me.Controls.Add(Me.chk75)
        Me.Controls.Add(Me.chk25)
        Me.Controls.Add(Me.chk5)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp終了)
        Me.Controls.Add(Me.dtp開始)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.chartPrice)
        Me.Name = "StockPriceChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "チャートフォーム"
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chartPrice As DataVisualization.Charting.Chart
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents 証券コード As DataGridViewTextBoxColumn
    Friend WithEvents 企業名 As DataGridViewTextBoxColumn
    Friend WithEvents dtp開始 As DateTimePicker
    Friend WithEvents dtp終了 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk25 As CheckBox
    Friend WithEvents chk75 As CheckBox
    Friend WithEvents chk200 As CheckBox
End Class
