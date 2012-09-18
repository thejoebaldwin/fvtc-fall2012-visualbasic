Public Class Form1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDebug1.Text = String.Empty
        lblDebug2.Text = String.Empty
        lblDebug3.Text = String.Empty

        NumericUpDown1.Maximum = TextBox1.Text.Length
        NumericUpDown1.Value = TextBox1.Text.Length

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        NumericUpDown1.Maximum = TextBox1.Text.Length
        NumericUpDown1.Value = TextBox1.Text.Length
        'lblDebug1.Text = "Word length:" & TextBox1.Text.Length

    End Sub
End Class
