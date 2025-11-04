Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        '          Me.Panel1.Hide()
        Panel1.Controls.Clear()
        Form3.TopLevel = False
        Form3.Parent = Panel1
        Form3.Dock = DockStyle.Fill
        Form3.Show()
        Me.Panel1.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'remove item button'
        '   If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
        '    TblitemsBindingSource.RemoveCurrent()
        '     Me.Validate()
        '   Me.TblitemsBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        '  Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        '  End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'add new item button'
        Finbound.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        'exit button'
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Controls.Clear()
        Fuser.TopLevel = False
        Fuser.Parent = Panel1
        Fuser.Dock = DockStyle.Fill
        Fuser.Show()
        Label4.Hide()
        Me.Panel1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Controls.Clear()
        Fpstocks1.TopLevel = False
        Fpstocks1.Parent = Panel1
        Fpstocks1.Dock = DockStyle.Fill
        Fpstocks1.Show()
        Label4.Hide()
        Me.Panel1.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel1.Controls.Clear()
        Fcustomer.TopLevel = False
        Fcustomer.Parent = Panel1
        Fcustomer.Dock = DockStyle.Fill
        Fcustomer.Show()
        Label4.Hide()
        Me.Panel1.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel1.Controls.Clear()
        Finbound.TopLevel = False
        Finbound.Parent = Panel1
        Finbound.Dock = DockStyle.Fill
        Finbound.Show()
        Label4.Hide()
        Me.Panel1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Controls.Clear()
        Foutbound.TopLevel = False
        Foutbound.Parent = Panel1
        Foutbound.Dock = DockStyle.Fill
        Foutbound.Show()
        Label4.Hide()
        Me.Panel1.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel1.Controls.Clear()
        Form3.TopLevel = False
        Form3.Parent = Panel1
        Form3.Dock = DockStyle.Fill
        Form3.Show()
        Me.Panel1.Show()
    End Sub
End Class
