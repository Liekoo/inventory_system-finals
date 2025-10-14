Public Class Form7

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        TextBox3.Text = TextBox1.Text * TextBox2.Text
    End Sub
End Class