Public Class Finbound

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbinbounding' table. You can move, or remove it, as needed.
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)

        ' Label3.Text = TblitemsBindingSource.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
    End Sub

    Private Sub QtyTextBox_TextChanged_1(sender As Object, e As EventArgs)
        'this is qty*price=totalprice'
        'Total_priceTextBox.Text = Val(QtyTextBox.Text) * Val(PriceTextBox.Text)
    End Sub

    Private Sub TbinboundingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TbinboundingBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TbinboundingBindingSource.RemoveCurrent()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class