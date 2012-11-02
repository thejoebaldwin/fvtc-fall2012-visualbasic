Public Class Candy
    'name
    'flavor
    'quantity
    Private _name As String
    Private _flavor As String
    Private _quantity As Integer


    Public Sub New()
        _quantity = 1
    End Sub

    Public Sub New(ByVal candyQuantity As Integer)
        _quantity = candyQuantity
    End Sub


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Flavor As String
        Get
            Return _flavor
        End Get
        Set(ByVal value As String)
            _flavor = value
        End Set
    End Property


    Public ReadOnly Property Quantity As Integer
        Get
            Return _quantity
        End Get
    End Property

    Public Sub AddOne()
        _quantity += 1
    End Sub

    Public Sub EatOne()
        _quantity -= 1
    End Sub

End Class
