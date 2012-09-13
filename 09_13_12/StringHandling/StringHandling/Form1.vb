Public Class Form1

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        initializeNumericUpDown()
    End Sub

    Public Sub initializeNumericUpDown()
        NumericUpDown1.Maximum = TextBox1.Text.Length
        NumericUpDown1.Value = TextBox1.Text.Length
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        initializeNumericUpDown()
    End Sub
End Class
