Public Class Form4

    Private Sub TblusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.tblusers' table. You can move, or remove it, as needed.
        ' Me.TblusersTableAdapter.Fill(Me.Database1DataSet1.tblusers)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet1.tblusers)
        MsgBox("You are now Registered, Contact admin for tutorials")
    End Sub
End Class