Public Class print3

    Private Sub print3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tarubnewDataSet.tbladptinprint' table. You can move, or remove it, as needed.
        Me.tbladptinprintTableAdapter.Fillbyprint2(Me.tarubnewDataSet.tbladptinprint)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class