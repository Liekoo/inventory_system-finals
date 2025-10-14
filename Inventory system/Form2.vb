Public Class Form2

    Private Sub TblitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        Label3.Text = TblitemsBindingSource.Count
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Perform search using LIKE with % wildcards
        Me.TblitemsTableAdapter.Search(Me.Database1DataSet.tblitems,
                                       "%" & TextBox1.Text & "%",
                                       "%" & TextBox1.Text & "%")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'remove item button'
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblitemsBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblitemsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
            Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        End If

        Label3.Text = TblitemsBindingSource.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add new item button'
        Form3.Show()
        Form3.TblitemsBindingSource.AddNew()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblitemsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblitemsBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'view users'
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_5(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        'exit button'
        End
    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_6(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_7(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TblitemsBindingNavigatorSaveItem_Click_8(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
   
End Class
