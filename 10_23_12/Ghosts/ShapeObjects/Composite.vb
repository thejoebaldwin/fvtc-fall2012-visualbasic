Imports System.Collections.Generic
Imports System.Drawing.Drawing2D
Public Class Composite

    Public _angle, _x, _y, _move_x, _move_y As Single


    Public Property X As Single
        Get
            Return _x
        End Get
        Set(value As Single)
            _x = value
        End Set
    End Property


    Public Property Y As Single
        Get
            Return _y
        End Get
        Set(value As Single)
            _y = value
        End Set
    End Property

    Public Property Move_Y As Single
        Get
            Return _move_y
        End Get
        Set(value As Single)
            _move_y = value
        End Set
    End Property

    Public Property Move_X As Single
        Get
            Return _move_x
        End Get
        Set(value As Single)
            _move_x = value
        End Set
    End Property


    Public Sub New(ByVal x As Single, ByVal y As Single)
        collPolygons = New List(Of Shape)
        _x = x
        _y = y

    End Sub

    Public Sub add(ByVal s As Shape)
        collPolygons.Add(s)
    End Sub


    Public Sub move(x As Single, y As Single)
        _move_x = x
        _move_y = y
    End Sub

    Public collPolygons As List(Of Shape)


    Public Sub draw(ByVal g As Graphics)

        Dim gContainer As GraphicsContainer = g.BeginContainer()
        Dim myMatrix As Matrix = g.Transform
        Dim scaleMatrix = myMatrix.Clone()
        'scaleMatrix.Scale(zoom, zoom)
        Dim translateMatrix = myMatrix.Clone()
        translateMatrix.Translate(_move_x + _x, _move_y + _y)
        Dim rotateMatrix = myMatrix.Clone()
        rotateMatrix.Rotate(_angle)

        myMatrix.Multiply(translateMatrix)
        myMatrix.Multiply(rotateMatrix)
        'myMatrix.Multiply(scaleMatrix)

        g.Transform = myMatrix
        For i As Integer = 0 To collPolygons.Count - 1
            collPolygons(i).draw(g)
        Next
        g.EndContainer(gContainer)
    End Sub


End Class
