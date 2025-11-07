Imports MessagingToolkit.Barcode
Public Class Fpstocks1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = IDTextBox.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, IDTextBox.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TblstocksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add
        TblstocksBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'save button
        Me.Validate()
        Me.TblstocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'del
        TblstocksBindingSource.RemoveCurrent()
    End Sub

    Private Sub ProductcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductcodeTextBox.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = ProductcodeTextBox.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, ProductcodeTextBox.Text))
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Perform search using LIKE with % wildcards
        Me.TblstocksTableAdapter.Search(Me.TarubnewDataSet.tblstocks,
                                       "%" & TextBox1.Text & "%")

        '  this is for other parameter search "%" & ComboBox1.Text & "%")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        print2.Show()
        Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
        print2.ReportViewer1.RefreshReport()
    End Sub
End Class