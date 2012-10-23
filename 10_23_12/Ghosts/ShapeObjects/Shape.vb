Imports System.Drawing.Drawing2D
Public MustInherit Class Shape

    Public angle, angle_increment As Single
    Public name As String
    Protected origin_x, origin_y As Single
    Private height, width, x, y, zoom As Single
    Private ptsArray As PointF()
    Public shapeColor As Color
    Public shapeBrush As Brush
    Public visible As Boolean = True
    Private initialized As Boolean = False

    Public Sub move(move_x As Single, move_y As Single)
        x = x + move_x
        y = y + move_y
    End Sub

    Public Sub zoomIn()
    
        If zoom > 0 And zoom < 1 Then
            zoom = zoom + 0.1
        Else
            zoom = zoom + 1
        End If
    End Sub
    Public Sub zoomOut()
        
        If zoom > 0 And zoom < 1 Then
            zoom = zoom - 0.1
        Else
            zoom = zoom - 1
        End If
        If zoom <= 0 Then
            zoom = 0.1
        End If
    End Sub

    Public Sub rotate()
        angle = angle + angle_increment
    End Sub


    Protected Sub New(new_origin_x As Single, new_origin_y As Single, new_color As Color, new_name As String)
        name = new_name
        angle = 0.0F
        x = 0.0F
        y = 0.0F
        zoom = 1.0F
        origin_x = new_origin_x
        origin_y = new_origin_y
        angle_increment = 5.0F
        shapeColor = new_color
    End Sub

    Public Sub draw(ByRef g As Graphics)
        draw(g, True)
    End Sub

    Public Sub draw(ByRef g As Graphics, ByVal transformOn As Boolean)
        If (visible) Then
            If Not initialized Then
                ptsArray = getPoints()
                initialized = True
            End If

            Dim tempBrush As New SolidBrush(shapeColor)
            Dim shapePen As New Pen(shapeColor, 2)

            If (transformOn) Then
              
                Dim gContainer As GraphicsContainer = g.BeginContainer()
                Dim myMatrix As Matrix = g.Transform
                Dim scaleMatrix = myMatrix.Clone()
                scaleMatrix.Scale(zoom, zoom)
                Dim translateMatrix = myMatrix.Clone()
                translateMatrix.Translate(origin_x + x, origin_y + y)
                Dim rotateMatrix = myMatrix.Clone()
                rotateMatrix.Rotate(angle)

                myMatrix.Multiply(translateMatrix)
                myMatrix.Multiply(rotateMatrix)
                myMatrix.Multiply(scaleMatrix)

                g.Transform = myMatrix
                g.DrawPolygon(shapePen, ptsArray)
                g.FillPolygon(tempBrush, ptsArray)
                g.EndContainer(gContainer)
            Else
                g.DrawPolygon(shapePen, ptsArray)
                g.FillPolygon(tempBrush, ptsArray)
            End If
            shapePen.Dispose()
          
        End If
    End Sub


    Public MustOverride Function getPoints() As PointF()






End Class
