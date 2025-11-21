Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        '          Me.Panel1.Hide()
        'Panel5.Controls.Clear()
        'Form3.TopLevel = False
        'Form3.Parent = Panel5
        'Form3.Dock = DockStyle.Fill
        'Form3.Show()
        'Me.Panel5.Show()
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

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        'exit button'
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel7.Controls.Clear()
        Fuser.TopLevel = False
        Fuser.Parent = Panel7
        Fuser.Dock = DockStyle.Fill
        Fuser.Show()
        Label1.Text = "Manage Users"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel7.Controls.Clear()
        Fstocks.TopLevel = False
        Fstocks.Parent = Panel7
        Fstocks.Dock = DockStyle.Fill
        Fstocks.Show()
        'Fstocks.Label1.Hide()
        Label1.Text = "Manage Products"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel7.Controls.Clear()
        Fcustomer.TopLevel = False
        Fcustomer.Parent = Panel7
        Fcustomer.Dock = DockStyle.Fill
        Fcustomer.Show()
        Fcustomer.Label4.Hide()
        Label1.Text = "Manage Customers"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel7.Controls.Clear()
        Finbound.TopLevel = False
        Finbound.Parent = Panel7
        Finbound.Dock = DockStyle.Fill
        Finbound.Show()
        Label1.Text = "Manage Inbounding Products"
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Panel7.Controls.Clear()
        Foutbound.TopLevel = False
        Foutbound.Parent = Panel7
        Foutbound.Dock = DockStyle.Fill
        Foutbound.Show()
        Foutbound.Label1.Hide()
        Label1.Text = "Manage Outbounding Products"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Me.Button15.BackColor = Color.Pink
        Panel7.Controls.Clear()
        Form3.TopLevel = False
        Form3.Parent = Panel7
        Form3.Dock = DockStyle.Fill
        Form3.Show()
        Label1.Text = "Dashboard"
    End Sub

End Class

