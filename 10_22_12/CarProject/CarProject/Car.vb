Public Class Car

    Private _model As String
    Public _year As Double
    Public _color As String
    Private _miles As Double

    'default contructor
    Public Sub New()
        _model = "No Model"
        _year = 0
        _color = "grey"
        _miles = 0
    End Sub

    Public Sub New(carYear As Double, carColor As String, carModel As String, carMiles As Double)
        _year = carYear
        _color = carColor
        _model = carModel
        _miles = carMiles
    End Sub

    Public Function getYear() As Double
        Return _year
    End Function

    Public ReadOnly Property Year As Double
        Get
            Return _year
        End Get

    End Property

    'readonly attribute
    'Public Sub setYear(value As Double)
    '    _year = value
    'End Sub

    ''' <summary>
    ''' Color of the car
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Color As String
        Get

            Return _color
        End Get
        Set(value As String)

            Select Case value
                Case "Red"
                    _color = value
                Case "Yellow"
                    _color = value
                Case "Blue"
                    _color = value
                Case "Black"
                    _color = value
            End Select

        End Set
    End Property


    Public Function getColor() As String
        Return _color
    End Function

    Public Sub setColor(value As String)
        Select Case value
            Case "Red"
                _color = value
            Case "Yellow"
                _color = value
            Case "Blue"
                _color = value
            Case "Black"
                _color = value
        End Select


    End Sub

    Public Function getModel() As String
        Return _model
    End Function

    Public Function getMiles() As Double
        Return _miles
    End Function



End Class
