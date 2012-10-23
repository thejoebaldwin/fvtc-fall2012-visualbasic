Public Class Rectangle
    Inherits Shape

    Private height As Integer
    Private width As Integer

    Public Sub New(new_origin_x As Single, new_origin_y As Single, new_color As Color, new_height As Single, new_width As Single, new_name As String)
        MyBase.New(new_origin_x, new_origin_y, new_color, new_name)
        height = new_height
        width = new_width
    End Sub


    Public Overrides Function getPoints() As System.Drawing.PointF()
        Dim points As List(Of PointF) = New List(Of PointF)
        points.Add(New Point(0 - width / 2, 0 - height / 2))
        points.Add(New Point(0 + width / 2, 0 - height / 2))
        points.Add(New Point(0 + width / 2, 0 + height / 2))
        points.Add(New Point(0 - width / 2, 0 + height / 2))
        Return points.ToArray()
    End Function
End Class
