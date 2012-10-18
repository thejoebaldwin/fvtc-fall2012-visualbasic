Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 25
        Dim s As String = "Hello There"
        Dim b As Boolean = False
        Dim obj As Object = New Object
        MessageBox.Show(obj.GetType().ToString())

    End Sub
End Class
