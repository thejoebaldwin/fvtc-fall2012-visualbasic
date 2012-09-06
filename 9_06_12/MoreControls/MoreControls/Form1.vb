
Option Strict On

Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged


        Dim selectedDate As Date = DateAndTime.Now





        'MessageBox.Show(selectedDate.ToString())

        'month 9 - day 6
        'month "September" day "6th"


        selectedDate = DateTimePicker1.Value
        lblDate.Text = selectedDate.ToString("MM----------dd------------yyyy")

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = String.Empty
        lblNumberValue.Text = String.Empty
        DateTimePicker1.Value = DateAndTime.Now.AddDays(7)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    'Private Sub TextBox1_Click(sender As System.Object, e As System.EventArgs) Handles TextBox1.Click
    '    MessageBox.Show("Enter your first name!")
    'End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_Click(sender As System.Object, e As System.EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub DateTimePicker1_MouseHover(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.MouseHover

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(NumericUpDown1.Value.ToString())
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged

        Dim quantity As Double = NumericUpDown1.Value

        Dim total As Double = quantity * 10.99

        lblNumberValue.Text = total.ToString("c")
    End Sub
End Class
