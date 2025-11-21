Public Class Finbounddel

    Private Sub TbinboundingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    Private Sub Finbounddel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tbinbounding' table. You can move, or remove it, as needed.
        Me.TbinboundingTableAdapter.Fill(Me.TarubnewDataSet.tbinbounding)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbinboundingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TbinboundingBindingSource.RemoveCurrent()
    End Sub
End Class