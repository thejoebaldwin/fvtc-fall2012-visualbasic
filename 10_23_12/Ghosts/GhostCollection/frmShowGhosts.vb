Imports System.Drawing.Drawing2D
Imports ShapeObjectLibrary
Public Class frmShowGhosts

    Private r As Random
    Public collGhosts As Collection = New Collection()

    ''' <summary>
    ''' Initializes a single "Ghost" object into the collection and array
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initialize()
        r = New Random()
        collGhosts.Add(New Ghost(Me.Width, Me.Height, r))
    End Sub
    ''' <summary>
    ''' Calls the Draw subroutines for the collection and array
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Private Sub draw(g As Graphics)
        drawGhostsInCollection(g)
    End Sub

    ''' <summary>
    ''' Checks to see if an object was clicked on in the collection and array
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Private Sub checkIfClicked(x As Integer, y As Integer)
        checkIfClickedInCollection(x, y)
    End Sub

    ''' <summary>
    ''' Updates the movement of the objects in the collection and array
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateGhosts()
        updateGhostsInCollection()
    End Sub

    ''' <summary>
    ''' Adds an object to the collection and array
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub addGhost()
        addGhostToCollection()
    End Sub


    ''' <summary>
    ''' Checks to see if an object in the collection was clicked
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Private Sub checkIfClickedInCollection(x As Integer, y As Integer)
        For i As Integer = 1 To collGhosts.Count
            If CType(collGhosts(i), Ghost).wasClicked(x, y) Then
                removeGhostFromCollection(i)
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' Draws the objects in the collection
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Private Sub drawGhostsInCollection(g As Graphics)
        For i As Integer = 1 To collGhosts.Count
            CType(collGhosts(i), Ghost).draw(g)
        Next
    End Sub

    ''' <summary>
    ''' Removes an object from the collection
    ''' </summary>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Private Sub removeGhostFromCollection(index As Integer)
        collGhosts.Remove(index)
    End Sub

    ''' <summary>
    ''' Updates the movement for the objects in the collection
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateGhostsInCollection()
        For i As Integer = 1 To collGhosts.Count
            CType(collGhosts(i), Ghost).update()
        Next
    End Sub

    ''' <summary>
    ''' Adds an object to the collection
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub addGhostToCollection()
        collGhosts.Add(New Ghost(Me.Width, Me.Height, r))
    End Sub















    'GORY GRAPHICS DETAILS



    Private Sub Ghosts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        initialize()
    End Sub
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        draw(g)
        MyBase.OnPaint(e)
    End Sub
    Private Sub Ghosts_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        checkIfClicked(e.X, e.Y)
    End Sub
    Private Sub btnGhostAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnGhostAdd.Click
        addGhost()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Invalidate()
        updateGhosts()
    End Sub
End Class
