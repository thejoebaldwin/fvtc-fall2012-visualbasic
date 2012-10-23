Public Class Square
    Inherits Rectangle

    Public Sub New(new_origin_x As Single, new_origin_y As Single, new_color As Color, width As Single, new_name As String)
        MyBase.New(new_origin_x, new_origin_y, new_color, width, width, new_name)
    End Sub
End Class
