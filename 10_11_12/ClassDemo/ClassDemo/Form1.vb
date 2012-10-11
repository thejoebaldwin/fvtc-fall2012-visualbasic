Public Class Form1

    Dim joesEnvoy As Car

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        joesEnvoy = New Car()
        joesEnvoy.Color = "Gold"
        joesEnvoy.Model = "Envoy"
        joesEnvoy.Year = 2012
        lblMiles.Text = joesEnvoy.Miles


    End Sub

    Private Sub btnDrive_Click(sender As System.Object, e As System.EventArgs) Handles btnDrive.Click
        joesEnvoy.Drive(50)

        lblMiles.Text = joesEnvoy.Miles
    End Sub
End Class
