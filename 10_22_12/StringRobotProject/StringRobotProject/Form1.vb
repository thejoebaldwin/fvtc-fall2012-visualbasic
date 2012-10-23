Public Class Form1
    Public myRobot As StringRobot

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myRobot = New StringRobot("")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            MessageBox.Show(myRobot.ReverseString)
        Catch ex As EmptyStringException
            MessageBox.Show("Hey pal, string robot likes long words. Please?")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MessageBox.Show(myRobot.Word)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        myRobot.Encrypt()
        Button2.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        myRobot.Decrypt()
        Button2.Enabled = True
        Button4.Enabled = False
    End Sub
End Class
