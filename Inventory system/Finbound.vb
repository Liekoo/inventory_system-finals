Public Class Finbound

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblcustomers' table. You can move, or remove it, as needed.
        Me.TblcustomersTableAdapter.Fill(Me.TarubnewDataSet.tblcustomers)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblcustomers1' table. You can move, or remove it, as needed.
        Me.TblcustomersTableAdapter.Fill(Me.TarubnewDataSet.tblcustomers)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbloutbounding' table. You can move, or remove it, as needed.
        Me.TbloutboundingTableAdapter.Fill(Me.TarubnewDataSet.tbloutbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbladptinprint' table. You can move, or remove it, as needed.
        Me.TbladptinprintTableAdapter.Fillbyprint2(Me.TarubnewDataSet.tbladptinprint)


        ComboBox1.DataSource = TblcustomersBindingSource
        ComboBox1.DisplayMember = "CustomersID"
        ComboBox1.ValueMember = "CustomersID"

        'TODO: This line of code loads data into the 'TarubnewDataSet.tbinbounding' table. You can move, or remove it, as needed.
        '    Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        '    Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)


        '     Me.TbladptinprintTableAdapter.Fillbyprint2(Me.TarubnewDataSet.tbladptinprint)
        TextBox1.Hide()
        Panel4.Hide()
        Label3.Text = TblstocksBindingSource.Count
    End Sub

    Private Sub QtyTextBox_TextChanged_1(sender As Object, e As EventArgs)
        'this is qty*price=totalprice'
        'Total_priceTextBox.Text = Val(QtyTextBox.Text) * Val(PriceTextBox.Text)
    End Sub

    Private Sub TbinboundingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TbinboundingBindingSource.Current.ITEM("productcode") = TextBox2.Text
        TbinboundingBindingSource.Current.ITEM("price") = PriceTextBox.Text
        TbinboundingBindingSource.Current.ITEM("qty_in") = Qty_inTextBox.Text
        TbinboundingBindingSource.Current.ITEM("date_in") = Now
        TbinboundingBindingSource.Current.ITEM("CustomersID") = ComboBox1.Text

        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Finbounddel.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        print3.Show()
        Me.TbladptinprintTableAdapter.Fillbyprint2(Me.TarubnewDataSet.tbladptinprint)
        print3.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.TbladptinprintTableAdapter.FillByprodname1(Me.TarubnewDataSet.tbladptinprint, TextBox1.Text + "%")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '      TextBox1.Show()
        '    Panel4.Visible = True
        TextBox1.Show()
        Panel4.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TbladptinprintTableAdapter.Fillbyprint2(Me.TarubnewDataSet.tbladptinprint)
    End Sub

    Private Sub TblstocksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    Private Sub Qty_inTextBox_TextChanged(sender As Object, e As EventArgs) Handles Qty_inTextBox.TextChanged
        ' lets comment this because we want to add logs and query StocksTextBox.Text = Val(StocksTextBox.Text) + Val(Qty_inTextBox.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.TblstocksTableAdapter.FillBystocks(Me.TarubnewDataSet.tblstocks, TextBox2.Text)
        TbinboundingBindingSource.AddNew()
    End Sub

    Private Sub CustomersIDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class