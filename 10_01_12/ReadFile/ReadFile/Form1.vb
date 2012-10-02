
Imports System.IO

Public Class Form1

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click

        openFile()


    End Sub


    Private Sub openFile()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim filePath As String = OpenFileDialog1.FileName
            'lblFileName.Text = filePath

            Me.Text = Microsoft.VisualBasic.Right(filePath, filePath.Length - (filePath.LastIndexOf("\") + 1)) & " - Not Notepad"
            ToolStripStatusLabel1.Text = filePath

            Dim reader As StreamReader = File.OpenText(filePath)
            Dim fileContents As String = reader.ReadToEnd
            fileContents = fileContents.Replace("$", "a")
            fileContents = fileContents.Replace("!", "e")
            fileContents = fileContents.Replace("#", "i")
            fileContents = fileContents.Replace("^", "o")
            fileContents = fileContents.Replace("@", "u")

            txtContents.Text = fileContents

        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = String.Empty
        Me.Text = "Not Notepad"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        openFile()
    End Sub
End Class
