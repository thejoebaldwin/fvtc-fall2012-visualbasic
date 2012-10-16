Public Class Car

    Private _color As String
    Private _model As String
    Private _year As Integer
    Private _miles As Integer

    Public Sub Drive(milesDriven As Integer)
        If (milesDriven > 0) Then
            _miles += milesDriven
        End If
    End Sub

    Public Function getMiles() As Integer
        Return _miles
    End Function

    Public Sub New(carColor As String, carModel As String, carYear As Integer, carMiles As Integer)
        _color = carColor
        _model = carModel
        _year = carYear
        _miles = carMiles
    End Sub

    Public Sub New()
        'empty constructor
    End Sub

End Class
