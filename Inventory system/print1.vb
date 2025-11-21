Public Class print1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tarubnewDataSet.tbladptoutprint' table. You can move, or remove it, as needed.
        Me.tbladptoutprintTableAdapter.Fillbyprint(Me.tarubnewDataSet.tbladptoutprint)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class