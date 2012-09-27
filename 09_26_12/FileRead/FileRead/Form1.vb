
Imports System.IO

Public Class Form1

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs)






    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filePath As String = OpenFileDialog1.FileName

            ToolStripStatusLabel1.Text = filePath

            Dim arrPath As String() = filePath.Split("\")
            Dim fileName As String = arrPath(arrPath.Length - 1)
            Me.Text = fileName
            Dim reader As StreamReader = File.OpenText(filePath)

            Dim fileContents As String = reader.ReadToEnd()




            TextBox1.Text = fileContents


            Dim dummy As Integer = 1 + 1
            'do here means file was selected

        Else


        End If
    End Sub
End Class
