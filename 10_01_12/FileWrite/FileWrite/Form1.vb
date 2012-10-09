Imports System.IO


Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        Dim fileContents As String = TextBox1.Text


        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim filePath As String = SaveFileDialog1.FileName
            If File.Exists(filePath) Then
                File.WriteAllText(filePath, fileContents)
            Else
                Dim writer As StreamWriter = File.CreateText(filePath)
                writer.WriteLine(fileContents)
                writer.Close()
            End If
        End If







    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SaveFileDialog1.Filter = "text files|*.txt"
    End Sub
End Class
