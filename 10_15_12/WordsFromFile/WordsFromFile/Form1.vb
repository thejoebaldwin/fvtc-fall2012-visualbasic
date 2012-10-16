Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'read file
        Dim reader As StreamReader = File.OpenText("../../words.txt")
        Dim fileContents As String = reader.ReadToEnd
        reader.Close()
        'split on comma
        Dim words As String() = fileContents.Split(",")
        'get random index
        Dim r As Random = New Random()
        Dim randomIndex = r.Next(0, words.Length)
        'display the word
        MessageBox.Show(words(randomIndex))
        Application.Exit()
    End Sub
End Class
