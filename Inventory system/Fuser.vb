Public Class Fuser

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblusers' table. You can move, or remove it, as needed.
        Me.TblusersTableAdapter.Fill(Me.TarubnewDataSet.tblusers)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TblusersBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblusersBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblusersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
            Me.TblusersTableAdapter.Fill(Me.TarubnewDataSet.tblusers)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblusersBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TblusersTableAdapter.Fill(Me.TarubnewDataSet.tblusers)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TblusersBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged

    End Sub
End Class