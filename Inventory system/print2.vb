Public Class print2


    Private Sub print2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        Me.tblstocksTableAdapter.Fill(Me.tarubnewDataSet.tblstocks)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class