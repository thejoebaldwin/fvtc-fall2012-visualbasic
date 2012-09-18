Imports System.IO
Imports System.Text


Public Class Form1
    Private theDictionary As String

    Private Function getDictionaryString() As String
        Dim fileReader As New System.IO.StreamReader("../../dictionary.txt")
        Dim sbDictionary As StringBuilder = New StringBuilder()

        Do While fileReader.Peek() <> -1
            sbDictionary.Append(fileReader.ReadLine())
            sbDictionary.Append(",")
        Loop
        Return sbDictionary.ToString()
    End Function

 


  
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        theDictionary = getDictionaryString()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtWord_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWord.TextChanged
        ListBox1.Items.Clear()

        'declare variables
        Dim word As String

        'get input
        word = txtWord.Text.ToLower().Trim()


        
        Dim arrWords As String() = theDictionary.Split(",")
        'loop through all the words in the dictionary

        Dim subWord As String
        If word.Length > 3 Then
            subWord = Microsoft.VisualBasic.Left(word, 4)
        Else
            subWord = String.Empty
        End If

        For Each dictionaryWord As String In arrWords
            If subWord <> String.Empty Then
                If dictionaryWord.StartsWith(subWord) Then
                    ListBox1.Items.Add(dictionaryWord)
                End If
            Else
                'if word is 3 letters or less, look for exact match
                If word = dictionaryWord Then
                    ListBox1.Items.Add(dictionaryWord)
                End If
            End If
        Next
    End Sub
End Class
