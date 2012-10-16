Public Class Form1
    Dim mycar As Car



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mycar = New Car("Black", "Liberty", 2007, 100000)
        Dim arrCars As ArrayList = New ArrayList()
        arrCars.Add(mycar)
        arrCars.Add(New Car("Black", "Camry", 2001, 99000))
        arrCars.Add(New Car("Gold", "Envoy", 2002, 88000))

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        mycar.Drive(100)
        Label1.Text = mycar.getMiles()
    End Sub
End Class
