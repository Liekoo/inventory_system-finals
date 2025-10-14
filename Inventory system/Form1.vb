Public Class Form1
    Public x As Integer
    Public y As String
    Private Sub TblusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.tblusers' table. You can move, or remove it, as needed.
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet.tblusers)
        ' this button is for testing/debuggin purposese only'
        Button3.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TblusersTableAdapter.Login(Me.Database1DataSet.tblusers, TextBox1.Text, TextBox2.Text)
        If TblusersBindingSource.Count = 1 Then
            Form2.Show()
            Dim role As String = TblusersBindingSource.Current("username").ToString()

            Form2.Show()
            If role = "user" Then
                'hide button for user acct'
                Form2.Button6.Visible = False
            Else
                'this block is exec when logged in as admin'
                MsgBox("Logged In As admin")
            End If
            Me.Close()
        Else
            MsgBox("wrong username or password!")
            x = x + 1
            y = ""
            If x >= 3 Then
                MsgBox("Incorrect login for three times, program will now close")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Contact admin for registering new users")
    End Sub

    Private Sub TblusersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class
