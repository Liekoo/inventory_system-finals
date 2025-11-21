Imports MessagingToolkit.Barcode
Public Class Fpstocks1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarubnewDataSet.tblstocks' table. You can move, or remove it, as needed.
        '   Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
        '  Me.Close()
    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)
        '  Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        'Generator.BackColor = Color.White
        '  Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        '  Generator.IncludeLabel = True
        '  Generator.CustomLabel = IDTextBox.Text
        '  Try
        '       PictureBox2.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, IDTextBox.Text))
        '   Catch ex As Exception
        '    End Try
    End Sub

    Private Sub TblstocksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        '     Me.Validate()
        '    Me.TblstocksBindingSource.EndEdit()
        '   Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)

    End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'add
    '     TblstocksBindingSource.AddNew()

    '     Dim x As Integer
    '    Dim y As Integer
    '   x = TblstocksBindingSource.Count
    '   If x <= 9 Then
    'y = "000" & x
    '   ElseIf x <= 99 Then
    ' y = "00" & x
    '   End If
    '
    '  ProductcodeTextBox.Text = "20251118" & y

    '   Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    '  Generator.BackColor = Color.White
    '  Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
    '  Generator.IncludeLabel = True
    ' Generator.CustomLabel = ProductcodeTextBox.Text
    '  Try
    'PictureBox2.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, ProductcodeTextBox.Text))
    '   Catch ex As Exception
    '   End Try

    ' End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'save button
        '   '  Me.Validate()
        '  Me.TblstocksBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.TarubnewDataSet)
        '  Me.TblstocksTableAdapter.Fill(Me.TarubnewDataSet.tblstocks)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'del
        '  TblstocksBindingSource.RemoveCurrent()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Perform search using LIKE with % wildcards
        '  Me.TblstocksTableAdapter.FillByname(Me.TarubnewDataSet.tblstocks, TextBox1.Text + "%")
        ' Me.TblstocksTableAdapter.FillBygroup(Me.TarubnewDataSet.tblstocks, TextBox1.Text + "%")
        '   Me.TblstocksTableAdapter.FillByname(Me.TarubnewDataSet.tblstocks,
        '                        "%" & TextBox1.Text & "%")
        '  Me.TblstocksTableAdapter.FillByname(Me.TarubnewDataSet.tblstocks,
        '                       "%" & TextBox1.Text & "%",
        '                           "%" & TextBox1.Text & "%")

        '  this is for other parameter search "%" & ComboBox1.Text & "%")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Form2.Show()
        '  Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        print2.Show()
        '  print2.tblstocksTableAdapter.FillById(print2.tarubnewDataSet.tblstocks, TblstocksBindingSource.Current.item("ID"))
        print2.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        print2.Show()
        print2.tblstocksTableAdapter.Fill(print2.tarubnewDataSet.tblstocks)
        print2.ReportViewer1.RefreshReport()
    End Sub

    '  Private Sub ProductnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductnameTextBox.TextChanged
    'Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    ' Generator.BackColor = Color.White
    '  Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
    '  Generator.IncludeLabel = True
    '  Generator.CustomLabel = ProductnameTextBox.Text
    '   Try
    '      PictureBox2.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, ProductnameTextBox.Text))
    '  Catch ex As Exception
    ' End Try
    '  End Sub
End Class