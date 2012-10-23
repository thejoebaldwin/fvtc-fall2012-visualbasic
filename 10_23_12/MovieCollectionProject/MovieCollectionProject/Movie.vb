Public Class Movie

    Private _title As String
    Private _year As Integer
    Private _actor As String

    Public Sub New()
        _title = "No Title"
        _year = -1
        _actor = "No Actor"
    End Sub

    Public Sub New(movieTitle As String, movieYear As Integer, movieActor As String)
        _title = movieTitle
        _year = movieYear
        _actor = movieActor
    End Sub

    Public Function getTitle() As String
        Return _title
    End Function

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public Property Actor As String
        Get
            Return _actor
        End Get
        Set(value As String)
            _actor = value
        End Set
    End Property

End Class
