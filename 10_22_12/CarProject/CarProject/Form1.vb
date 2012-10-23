Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim myCar As Car = New Car()
        Dim myCar As Car = New Car(2002, "Gold", "Envoy", 120000)

        myCar._color = "XXXXXX"
        myCar.setColor("XXXXXX")
        myCar.Color = "Purple"
        'not possible with car
        'myCar._year = 2007

    End Sub
End Class
