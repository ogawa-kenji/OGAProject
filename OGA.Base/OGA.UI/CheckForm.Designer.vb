<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgv企業情報 = New System.Windows.Forms.DataGridView()
        Me.証券コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chartPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.cart出来高 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt移動平均5乖離率開始 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt移動平均5乖離率終了 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt移動平均25乖離率開始 = New System.Windows.Forms.TextBox()
        Me.txt移動平均25乖離率終了 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt移動平均75乖離率開始 = New System.Windows.Forms.TextBox()
        Me.txt移動平均75乖離率終了 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp終了 = New System.Windows.Forms.DateTimePicker()
        Me.dtp開始 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.cart出来高, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv企業情報.Size = New System.Drawing.Size(175, 527)
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
        ChartArea1.Name = "ChartArea1"
        Me.chartPrice.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartPrice.Legends.Add(Legend1)
        Me.chartPrice.Location = New System.Drawing.Point(3, 3)
        Me.chartPrice.Name = "chartPrice"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPrice.Series.Add(Series1)
        Me.chartPrice.Size = New System.Drawing.Size(888, 328)
        Me.chartPrice.TabIndex = 8
        Me.chartPrice.Text = "Chart1"
        '
        'splitContainer
        '
        Me.splitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer.Location = New System.Drawing.Point(193, 93)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.chartPrice)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.cart出来高)
        Me.splitContainer.Size = New System.Drawing.Size(894, 446)
        Me.splitContainer.SplitterDistance = 334
        Me.splitContainer.TabIndex = 11
        '
        'cart出来高
        '
        Me.cart出来高.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.cart出来高.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.cart出来高.Legends.Add(Legend2)
        Me.cart出来高.Location = New System.Drawing.Point(3, 3)
        Me.cart出来高.Name = "cart出来高"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.cart出来高.Series.Add(Series2)
        Me.cart出来高.Size = New System.Drawing.Size(888, 102)
        Me.cart出来高.TabIndex = 12
        Me.cart出来高.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "移動平均5乖離率"
        '
        'txt移動平均5乖離率開始
        '
        Me.txt移動平均5乖離率開始.Location = New System.Drawing.Point(331, 12)
        Me.txt移動平均5乖離率開始.Name = "txt移動平均5乖離率開始"
        Me.txt移動平均5乖離率開始.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均5乖離率開始.TabIndex = 0
        Me.txt移動平均5乖離率開始.Text = "-0.06"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "～"
        '
        'txt移動平均5乖離率終了
        '
        Me.txt移動平均5乖離率終了.Location = New System.Drawing.Point(465, 12)
        Me.txt移動平均5乖離率終了.Name = "txt移動平均5乖離率終了"
        Me.txt移動平均5乖離率終了.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均5乖離率終了.TabIndex = 13
        Me.txt移動平均5乖離率終了.Text = "-0.05"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "移動平均25乖離率"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "～"
        '
        'txt移動平均25乖離率開始
        '
        Me.txt移動平均25乖離率開始.Location = New System.Drawing.Point(331, 37)
        Me.txt移動平均25乖離率開始.Name = "txt移動平均25乖離率開始"
        Me.txt移動平均25乖離率開始.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均25乖離率開始.TabIndex = 13
        Me.txt移動平均25乖離率開始.Text = "-0.11"
        '
        'txt移動平均25乖離率終了
        '
        Me.txt移動平均25乖離率終了.Location = New System.Drawing.Point(465, 37)
        Me.txt移動平均25乖離率終了.Name = "txt移動平均25乖離率終了"
        Me.txt移動平均25乖離率終了.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均25乖離率終了.TabIndex = 13
        Me.txt移動平均25乖離率終了.Text = "-0.10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "移動平均75乖離率"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "～"
        '
        'txt移動平均75乖離率開始
        '
        Me.txt移動平均75乖離率開始.Location = New System.Drawing.Point(331, 65)
        Me.txt移動平均75乖離率開始.Name = "txt移動平均75乖離率開始"
        Me.txt移動平均75乖離率開始.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均75乖離率開始.TabIndex = 13
        Me.txt移動平均75乖離率開始.Text = "-0.16"
        '
        'txt移動平均75乖離率終了
        '
        Me.txt移動平均75乖離率終了.Location = New System.Drawing.Point(465, 65)
        Me.txt移動平均75乖離率終了.Name = "txt移動平均75乖離率終了"
        Me.txt移動平均75乖離率終了.Size = New System.Drawing.Size(100, 22)
        Me.txt移動平均75乖離率終了.TabIndex = 13
        Me.txt移動平均75乖離率終了.Text = "-0.15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(762, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "～"
        '
        'dtp終了
        '
        Me.dtp終了.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp終了.Location = New System.Drawing.Point(791, 12)
        Me.dtp終了.Name = "dtp終了"
        Me.dtp終了.Size = New System.Drawing.Size(127, 22)
        Me.dtp終了.TabIndex = 14
        '
        'dtp開始
        '
        Me.dtp開始.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp開始.Location = New System.Drawing.Point(629, 12)
        Me.dtp開始.Name = "dtp開始"
        Me.dtp開始.Size = New System.Drawing.Size(127, 22)
        Me.dtp開始.TabIndex = 15
        '
        'CheckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 551)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp終了)
        Me.Controls.Add(Me.dtp開始)
        Me.Controls.Add(Me.txt移動平均75乖離率終了)
        Me.Controls.Add(Me.txt移動平均25乖離率終了)
        Me.Controls.Add(Me.txt移動平均5乖離率終了)
        Me.Controls.Add(Me.txt移動平均75乖離率開始)
        Me.Controls.Add(Me.txt移動平均25乖離率開始)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt移動平均5乖離率開始)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.dgv企業情報)
        Me.Name = "CheckForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "チェックフォーム"
        CType(Me.dgv企業情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.cart出来高, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv企業情報 As DataGridView
    Friend WithEvents chartPrice As DataVisualization.Charting.Chart
    Friend WithEvents 証券コード As DataGridViewTextBoxColumn
    Friend WithEvents 企業名 As DataGridViewTextBoxColumn
    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents cart出来高 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents txt移動平均5乖離率開始 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt移動平均5乖離率終了 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt移動平均25乖離率開始 As TextBox
    Friend WithEvents txt移動平均25乖離率終了 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt移動平均75乖離率開始 As TextBox
    Friend WithEvents txt移動平均75乖離率終了 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp終了 As DateTimePicker
    Friend WithEvents dtp開始 As DateTimePicker
End Class
