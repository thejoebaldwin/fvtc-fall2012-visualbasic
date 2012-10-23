Public Class Form1

    Public startTime As Date
    Public stopTime As Date

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        startTime = DateAndTime.Now
        'set the start time back one hour, two minutes to test out elapsed time formatting
        startTime = startTime.AddHours(-1)
        startTime = startTime.AddMinutes(-2)
        'enable the start button, disable the stop button
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        stopTime = DateAndTime.Now
        Dim t As TimeSpan = stopTime - startTime
        MessageBox.Show(t.Hours.ToString().PadLeft(2, "0") & ":" & t.Minutes.ToString().PadLeft(2, "0") & ":" & t.Seconds.ToString().PadLeft(2, "0"), "Elapsed Time")
        'disable the start button, enable the stop button
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

   
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'disable the stop button
        Button1.Enabled = False
    End Sub
End Class
