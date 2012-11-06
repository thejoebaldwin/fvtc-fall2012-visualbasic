Public Class CandyCollection

    Private _collCandy As Collection

    Public Sub New()
        _collCandy = New Collection
    End Sub

    Public Function Contains(key As String) As Boolean
        Return _collCandy.Contains(key)
    End Function

    Public Sub Add(c As Candy)
        _collCandy.Add(c)
    End Sub

    Public Sub Add(c As Candy, key As String)
        _collCandy.Add(c, key)
    End Sub

    Public Function Find(name As String) As Candy
        Return _collCandy(name)
    End Function

    Public Sub Clear()
        _collCandy.Clear()
    End Sub

    Public Function Count() As Integer
        Return _collCandy.Count
    End Function

    Default Public ReadOnly Property Item(index As Integer) As Candy
        Get
            Return _collCandy(index)
        End Get
    End Property

End Class
