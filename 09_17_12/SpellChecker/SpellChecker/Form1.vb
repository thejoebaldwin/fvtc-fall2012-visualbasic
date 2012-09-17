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

 


  
End Class
