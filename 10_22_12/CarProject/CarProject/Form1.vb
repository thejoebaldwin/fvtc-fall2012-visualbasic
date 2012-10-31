Public Class Form1


    


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim myCar As Car = New Car()
        Dim myCar As Car = New Car(2002, "Gold", "Envoy", 120000)

        myCar._color = "XXXXXX"
        myCar.setColor("XXXXXX")
        myCar.Color = "Purple"
        'not possible with car
        'myCar._year = 2007
        Dim carCollection As Collection = New Collection()




    End Sub
End Class
