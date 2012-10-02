Public Class Form1

    Dim counter As Integer = 0
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


        'Label1.Text = counter
        'counter += 1
        Label1.Text = DateAndTime.Now

        TextBox1.Location = New Point(TextBox1.Location.X + 1, TextBox1.Location.Y)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("clicked!")
    End Sub
End Class
