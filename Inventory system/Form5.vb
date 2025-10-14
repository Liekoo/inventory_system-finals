Public Class Form5

    Private Sub TblusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.tblusers' table. You can move, or remove it, as needed.
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet1.tblusers)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblusersBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblusersBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblusersBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblusersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)
            Me.TblusersTableAdapter.Fill(Me.Database1DataSet1.tblusers)
        End If
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblusersBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet1.tblusers)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class