Public Class AlertForm
    Private Sub AlertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim aleartbl As New OGA.BL.AleartBL
        Dim alearts = aleartbl.Selectアラート()

        Dim price1 = (From a In alearts
                      Order By a.株価増減率 Ascending
                      Select a).Take(10)

        Dim price2 = (From a In alearts
                      Order By a.株価増減率 Descending
                      Select a).Take(10)

        Me.dgv株価増減マイナス.AutoGenerateColumns = False
        Me.dgv株価増減マイナス.DataSource = price1.ToList()

        Me.dgv株価増減プラス.AutoGenerateColumns = False
        Me.dgv株価増減プラス.DataSource = price2.ToList()

        Dim trade1 = (From a In alearts
                      Order By a.出来高増減率 Ascending
                      Select a).Take(10)

        Dim trade2 = (From a In alearts
                      Order By a.出来高増減率 Descending
                      Select a).Take(10)

        Me.dgv出来高増減マイナス.AutoGenerateColumns = False
        Me.dgv出来高増減マイナス.DataSource = trade1.ToList()

        Me.dgv出来高増減プラス.AutoGenerateColumns = False
        Me.dgv出来高増減プラス.DataSource = trade2.ToList()

        Dim avarage5_1 = (From a In alearts
                          Order By a.移動平均5乖離率 Ascending
                          Select a).Take(10)

        Dim avarage5_2 = (From a In alearts
                          Order By a.移動平均5乖離率 Descending
                          Select a).Take(10)

        Me.dgv移動平均5乖離率マイナス.AutoGenerateColumns = False
        Me.dgv移動平均5乖離率マイナス.DataSource = avarage5_1.ToList()

        Me.dgv移動平均5乖離率プラス.AutoGenerateColumns = False
        Me.dgv移動平均5乖離率プラス.DataSource = avarage5_2.ToList()

        Dim avarage25_1 = (From a In alearts
                           Order By a.移動平均25乖離率 Ascending
                           Select a).Take(10)

        Dim avarage25_2 = (From a In alearts
                           Order By a.移動平均25乖離率 Descending
                           Select a).Take(10)

        Me.dgv移動平均25乖離率マイナス.AutoGenerateColumns = False
        Me.dgv移動平均25乖離率マイナス.DataSource = avarage25_1.ToList()

        Me.dgv移動平均25乖離率プラス.AutoGenerateColumns = False
        Me.dgv移動平均25乖離率プラス.DataSource = avarage25_2.ToList()

        Dim avarage75_1 = (From a In alearts
                           Order By a.移動平均75乖離率 Ascending
                           Select a).Take(10)

        Dim avarage75_2 = (From a In alearts
                           Order By a.移動平均75乖離率 Descending
                           Select a).Take(10)

        Me.dgv移動平均75乖離率マイナス.AutoGenerateColumns = False
        Me.dgv移動平均75乖離率マイナス.DataSource = avarage75_1.ToList()

        Me.dgv移動平均75乖離率プラス.AutoGenerateColumns = False
        Me.dgv移動平均75乖離率プラス.DataSource = avarage75_2.ToList()



    End Sub
End Class