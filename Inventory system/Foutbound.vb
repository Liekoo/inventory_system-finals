Public Class Foutbound

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblcustomers' table. You can move, or remove it, as needed.
        Me.TblcustomersTableAdapter.Fill(Me.TarubnewDataSet.tblcustomers)
        '  'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        ' Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbladptoutprint' table. You can move, or remove it, as needed.
        Me.TbladptoutprintTableAdapter.Fillbyprint(Me.TarubnewDataSet.tbladptoutprint)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        ' Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        '   Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        ' Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        '  Me.TbladptoutprintTableAdapter.Fillbyprint(Me.TarubnewDataSet.tbladptoutprint)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbladptoutprint' table. You can move, or remove it, as needed.
        '   Me.TbladptoutprintTableAdapter.Fillbyprint(Me.TarubnewDataSet.tbladptoutprint)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        '   Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        '    Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        Label7.Text = TblstocksBindingSource.Count
        Panel4.Hide()
        TextBox1.Hide()

        ComboBox1.DataSource = TblcustomersBindingSource
        ComboBox1.DisplayMember = "CustomersID"
        ComboBox1.ValueMember = "CustomersID"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbloutboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TbloutboundingBindingSource.Current.ITEM("productcode") = TextBox2.Text
        TbloutboundingBindingSource.Current.ITEM("qty_out") = Qty_outTextBox.Text
        TbloutboundingBindingSource.Current.ITEM("date_out") = Now
        TbloutboundingBindingSource.Current.ITEM("CustomersID") = ComboBox1.Text

        Me.Validate()
        Me.TbloutboundingBindingSource.EndEdit()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Foutbounddel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TbladptoutprintTableAdapter.Fillbyprint(Me.TarubnewDataSet.tbladptoutprint)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        print1.Show()
        Me.TbladptoutprintTableAdapter.Fillbyprint(Me.TarubnewDataSet.tbladptoutprint)
        print1.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  TextBox1.Show()
        '   Panel4.Visible = True
        Panel4.Show()
        TextBox1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.TbladptoutprintTableAdapter.FillByprodname0(Me.TarubnewDataSet.tbladptoutprint, TextBox1.Text + "%")

    End Sub

    Private Sub TbloutboundingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbloutboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.TblstocksTableAdapter.FillBystocks(Me.TarubnewDataSet.tblstocks, TextBox2.Text)
        TbloutboundingBindingSource.AddNew()
    End Sub

    Private Sub StocksTextBox_TextChanged(sender As Object, e As EventArgs) Handles StocksTextBox.TextChanged

    End Sub
End Class