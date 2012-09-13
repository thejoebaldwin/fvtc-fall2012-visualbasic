Imports System.IO
Imports System.Text

Public Class Form1
    Private theDictionary As String

    Private Function getDictionaryString()
        Dim fileReader As New System.IO.StreamReader("../../dictionary.txt")
        Dim sbDictionary As StringBuilder = New StringBuilder()
        Do While fileReader.Peek() <> -1
            sbDictionary.Append(fileReader.ReadLine())
            sbDictionary.Append(",")
        Loop
        Return sbDictionary.ToString()
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = String.Empty

        theDictionary = getDictionaryString()


    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSpellCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnSpellCheck.Click

        Dim searchWord As String = txtWord.Text.ToLower().Trim()

        Dim splitString As String() = {","}

        Dim arrWords As String() = theDictionary.Split(splitString, StringSplitOptions.RemoveEmptyEntries)

        ListBox1.Items.Clear()


        For i As Integer = 0 To arrWords.Length - 1

            Dim dictionaryString As String = arrWords(i)

        Next


        For Each dictionaryString As String In arrWords
            Dim shorterString As String = searchWord.Substring(1, searchWord.Length - 1)

            If dictionaryString = searchWord Then
                ListBox1.Items.Add(dictionaryString)
            ElseIf dictionaryString.Contains(shorterString) And dictionaryString.Length <= searchWord.Length + 2 Then
                ListBox1.Items.Add(dictionaryString)
            End If
        Next

        'If (theDictionary.IndexOf(searchWord) > -1) Then
        '    lblResult.Text = "Spelling Correct!"
        'Else
        '    lblResult.Text = "Not Spelled Correctly"
        'End If


    End Sub
End Class
