
Public Class Ghost
    Inherits Composite

    Const _width As Single = 5
    Const _height As Single = 7
    Private _size As Single = 10
    Private _name As String

    Private _formWidthBounds, _formHeightBounds As Single
    Const increment As Single = 0.05
    Private _velocity_x, _velocity_y As Single


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Function wasClicked(x As Single, y As Single) As Boolean

        Dim current_center_x As Single = MyBase.X + Move_X
        Dim current_center_y As Single = MyBase.Y + Move_Y
        Dim x_min As Single = current_center_x - _width * _size / 2
        Dim x_max As Single = current_center_x + _width * _size / 2
        Dim y_min As Single = current_center_y - _height * _size / 2
        Dim y_max As Single = current_center_y + _height * _size / 2
        Dim isCollision As Boolean = False
        If y > y_min And y < y_max Then
            If x > x_min And x < x_max Then
                isCollision = True
            End If
        End If
        Return isCollision
    End Function

    Public Sub New(formWidth As Single, formHeight As Single, r As Random)
        MyBase.New(0, 0)

        _formHeightBounds = formHeight
        _formWidthBounds = formWidth

        _size = (r.Next Mod 5) + 5

        _x = r.Next() Mod (formWidth / 2)
        _y = r.Next() Mod (formHeight / 2)

        _velocity_x = (r.Next() Mod 20) + 5
        _velocity_y = (r.Next() Mod 20) + 5


        If r.Next() Mod 2 = 0 Then
            _velocity_x = _velocity_x * -1
        End If
        If r.Next() Mod 2 = 0 Then
            _velocity_y = _velocity_y * -1
        End If

        MyBase.collPolygons.Add(New Rectangle(0, 0, Color.White, _height * _size, _width * _size, "Body"))
        MyBase.collPolygons.Add(New Square(-(_width * _size / 2) + _size / 2, (_height / 2) * _size + _size / 2, Color.White, 1 * _size, "FootLeft"))
        MyBase.collPolygons.Add(New Square(2 * _size - (_width * _size / 2) + _size / 2, (_height / 2) * _size + _size / 2, Color.White, 1 * _size, "FootCenter"))
        MyBase.collPolygons.Add(New Square(4 * _size - (_width * _size / 2) + _size / 2, (_height / 2) * _size + _size / 2, Color.White, 1 * _size, "FootRight"))
        MyBase.collPolygons.Add(New Square(1 * _size - (_width * _size / 2) + _size / 2, -_size * 2, Color.Black, 1 * _size, "LeftEye"))
        MyBase.collPolygons.Add(New Square(3 * _size - (_width * _size / 2) + _size / 2, -_size * 2, Color.Black, 1 * _size, "RightEye"))
        MyBase.collPolygons.Add(New Rectangle(+2 * _size - (_width * _size / 2) + _size / 2, 0, Color.Black, 1.0 * _size, 3 * _size, "Mouth"))

    End Sub


    Public Sub New(formWidth As Single, formHeight As Single)
        Me.New(formWidth, formHeight, New Random())
    End Sub


    Public Sub update()
        If _x + _move_x > _formWidthBounds Or _x + _move_x < 0 Then
            _velocity_x = _velocity_x * -1
        End If

        If _y + _move_y > _formHeightBounds Or _y + _move_y < 0 Then
            _velocity_y = _velocity_y * -1
        End If
        _move_x = _move_x + increment * _velocity_x
        _move_y = _move_y + increment * _velocity_y
    End Sub

End Class
