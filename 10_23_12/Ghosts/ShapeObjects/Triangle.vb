Public Class Triangle
    Inherits Polygon
    Public Sub New(new_origin_x As Single, new_origin_y As Single, new_color As Color, height As Integer, new_name As String)
        MyBase.New(new_origin_x, new_origin_y, new_color, 3, height, new_name)
    End Sub
End Class
