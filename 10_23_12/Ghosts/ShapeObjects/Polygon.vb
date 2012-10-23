Public Class Polygon
    Inherits Shape
    Private vertices As Integer
    Private radius As Integer

    Public Sub New(new_origin_x As Single, new_origin_y As Single, new_color As Color, numberVertices As Integer, shapeRadius As Integer, new_name As String)
        MyBase.New(new_origin_x, new_origin_y, new_color, new_name)
        radius = shapeRadius
        vertices = numberVertices
    End Sub

    Public Overrides Function getPoints() As System.Drawing.PointF()
        Return getNPointsOnCircle(origin_x, origin_y, radius, vertices)
    End Function

    Private Function getNPointsOnCircle(center_x As Single, center_y As Single, radius As Single, n As Single) As PointF()
        Dim points As List(Of PointF) = New List(Of PointF)
        Dim alpha As Single = Math.PI * 2 / n
        Dim i As Integer = -1
        While i < n
            Dim theta As Single = alpha * i
            Dim pointOnCircle As PointF = New PointF(Math.Cos(theta) * radius, Math.Sin(theta) * radius)
            points.Add(pointOnCircle)
            i = i + 1
        End While
        points.RemoveAt(points.Count - 1)
        Return points.ToArray()
    End Function
End Class
