Public Class Fstocks

    Private Sub TblstocksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    Private Sub Fstocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add()
        TblstocksBindingSource.AddNew()

        Dim x As Integer
        Dim y As Integer
        x = TblstocksBindingSource.Count
        If x <= 9 Then
            y = "000" & x
        ElseIf x <= 99 Then
            y = "00" & x
        End If

        ProductcodeTextBox.Text = "202511-19-" & y

        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 8, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = ProductcodeTextBox.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, ProductcodeTextBox.Text))
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblstocksBindingSource.RemoveCurrent()
    End Sub

    Private Sub ProductcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductcodeTextBox.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        print2.Show()
        print2.tblstocksTableAdapter.FillById(print2.tarubnewDataSet.tblstocks, TblstocksBindingSource.Current.item("stocksID"))
        print2.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        print2.Show()
        print2.tblstocksTableAdapter.Fill(print2.tarubnewDataSet.tblstocks)
        print2.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'two parameters search
        Me.TblstocksTableAdapter.FillByname(Me.TarubnewDataSet.tblstocks,
                                                TextBox1.Text + "%",
                                                TextBox1.Text + "%")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub
End Class