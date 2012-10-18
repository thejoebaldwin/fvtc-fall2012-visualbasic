Public Class Form1

    Private myRobot As NumberRobot

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim number As Integer
        If Integer.TryParse(txtNumber.Text, number) Then
            myRobot.Add(number)
        Else
            MessageBox.Show("Enter valid number")
        End If
        txtNumber.Clear()
        txtNumber.Focus()
    End Sub

    Private Sub btnMaximum_Click(sender As System.Object, e As System.EventArgs) Handles btnMaximum.Click
        Try
            MessageBox.Show(myRobot.Maximum)
        Catch ex As NoNumbersException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myRobot = New NumberRobot()
    End Sub
End Class
