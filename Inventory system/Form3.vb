Public Class Form3

    Private Sub TblstocksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbladptmain' table. You can move, or remove it, as needed.
        'Me.TbladptmainTableAdapter.Fillbythree(Me.TarubnewDataSet.tbladptmain)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbinbounding' table. You can move, or remove it, as needed.
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblusers' table. You can move, or remove it, as needed.
        Me.TblusersTableAdapter.Fill(Me.TarubnewDataSet.tblusers)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblcustomers' table. You can move, or remove it, as needed.
        Me.TblcustomersTableAdapter.Fill(Me.TarubnewDataSet.tblcustomers)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks1' table. You can move, or remove it, as needed.
        Me.Tblstocks1TableAdapter.Fillzero(Me.TarubnewDataSet.tblstocks1)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
        Me.Tblstocks1TableAdapter.Fillzero(Me.TarubnewDataSet.tblstocks1)
        Label7.Text = TblstocksBindingSource.Count
        Label6.Text = TblcustomersBindingSource.Count
        Label8.Text = TblusersBindingSource.Count
        Label9.Text = TbinboundingBindingSource.Count
        Label11.Text = TbloutboundingBindingSource.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Tblstocks1TableAdapter.Fillzero(Me.TarubnewDataSet.tblstocks1)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class