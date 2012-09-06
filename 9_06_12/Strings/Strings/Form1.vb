Public Class Form1

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        Dim password As String = "Password"
        Dim input As String = txtString.Text
        Dim message As String
        Dim success As Boolean = True

        If (input = password) Then
            message = "Password Match"
            success = False
        ElseIf (input.ToLower() = password.ToLower()) Then
            message = "Check your case"
            success = False
        ElseIf (input.Replace(" ", "") = password) Then
            message = "No spaces in your password"
            success = True
        ElseIf (input.Trim(" ") = password) Then
            message = "Please enter your password without spaces"
            success = False
        ElseIf (input.Contains(password)) Then
            message = "Close! You typed extra letters in the beginning and/or end of the password"
            success = False
        ElseIf (input.Length > password.Length) Then
            message = "Too many letters"
            success = False
        Else
            message = "Incorrect Password"
            success = False
        End If


        If (Not success) Then
            lblText.Text = addNewLine(message)
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If


    End Sub


    Private Function addNewLine(message As String)
        Dim newMessage As String = message
        If (newMessage.Length > 35) Then


            Dim insertIndex As Integer = newMessage.IndexOf(" ", 35)
            newMessage = newMessage.Insert(insertIndex, ControlChars.NewLine)

            'Dim lastHalfMessage As String = newMessage.Substring(35)
            'insertIndex = lastHalfMessage.IndexOf(" ")
            'insertIndex = 25 + insertIndex

        End If


        Return newMessage
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblText.Text = String.Empty
    End Sub
End Class
