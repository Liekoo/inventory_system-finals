Public Class Foutbound

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        Me.DataTable1TableAdapter.Fillbythree(Me.TarubnewDataSet.DataTable1)
        Label7.Text = TblstocksBindingSource.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TbloutboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TbloutboundingBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TbloutboundingBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.DataTable1TableAdapter.Fillbythree(Me.TarubnewDataSet.DataTable1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class