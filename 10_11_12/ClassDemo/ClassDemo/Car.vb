Public Class Car

    ''' <summary>
    ''' Color of the Car
    ''' </summary>
    ''' <remarks></remarks>
    Public Color As String
    ''' <summary>
    ''' Year of the Car
    ''' </summary>
    ''' <remarks></remarks>
    Public Year As Integer
    Public Model As String
    Public Miles As Integer

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Car()

    End Sub


    Public Sub Drive(milesToDrive As Integer)
        If (milesToDrive > 0) Then
            Miles += milesToDrive
        End If
    End Sub

End Class
