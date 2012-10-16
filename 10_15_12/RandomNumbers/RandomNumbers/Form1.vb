Public Class Form1

    Private Sub btnRandom_Click(sender As System.Object, e As System.EventArgs) Handles btnRandom.Click

        Dim r As Random = New Random()
        Dim newRandom As Integer = r.Next(0, 10)
        'Dim newRandom As Integer = r.Next()
        'newRandom = newRandom Mod 10
        ListBox1.Items.Add(newRandom)



    End Sub
End Class
