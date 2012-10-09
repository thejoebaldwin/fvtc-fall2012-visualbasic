Public Class Form1

    Dim secretWord As String = "aardvark"
    Dim arrLettersGuessed As ArrayList

    Private Sub btnGuess_Click(sender As System.Object, e As System.EventArgs) Handles btnGuess.Click

        Dim guess As String = txtGuess.Text
        arrLettersGuessed.Add(guess)

        txtLettersGuessed.Clear()

        For i As Integer = 0 To arrLettersGuessed.Count - 1
            txtLettersGuessed.Text = txtLettersGuessed.Text & " " & arrLettersGuessed(i)
        Next
        updateDisplayWord()

        'If secretWord.Contains(guess) Then
        '    MessageBox.Show("correct!")
        'Else
        '    MessageBox.Show("no!")
        'End If

    End Sub


    Private Sub updateDisplayWord()
        Dim displayWord As String = String.Empty
        For i As Integer = 0 To secretWord.Length - 1
            Dim checkLetter As String = secretWord(i)
            If (arrLettersGuessed.Contains(checkLetter)) Then
                displayWord = displayWord & checkLetter
            Else
                displayWord = displayWord & "*"
            End If
        Next
        txtSecretWord.Text = displayWord
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'txtSecretWord.Text = secretWord
        arrLettersGuessed = New ArrayList()
        updateDisplayWord()
    End Sub
End Class
