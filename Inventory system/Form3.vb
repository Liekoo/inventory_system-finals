Public Class Form3

    Private Sub TblitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.tblitems' table. You can move, or remove it, as needed.
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)

    End Sub

    Private Sub QtyTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub QtyTextBox_TextChanged_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub QtyTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles QtyTextBox.TextChanged, PriceTextBox.TextChanged
        'this is qty*price=totalprice'
        Total_priceTextBox.Text = Val(QtyTextBox.Text) * Val(PriceTextBox.Text)
    End Sub
End Class