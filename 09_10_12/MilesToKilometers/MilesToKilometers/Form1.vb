Public Class Form1

    Private Const CONVERSION_RATE As Double =
        1.6023454564564565

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim milesToConvert As Double
        Double.TryParse(TextBox1.Text, milesToConvert)

        Label1.Text = milesToKilometers(milesToConvert)

    End Sub


    Private Sub clearForm()
        TextBox1.Clear()
    End Sub

    Private Function milesToKilometers(miles As Double) As Double
        Return miles * CONVERSION_RATE
    End Function

End Class
