Public Class Student
    Private _firstName As String
    Private _lastName As String
    Private _studentID As String
    Private _status As studentType

    Public Enum StudentType As Integer
        NewStudent
        ReturningStudent
        CurrentlyEnrolled
        Graduated
    End Enum


    Public Property Status As StudentType
        Get
            Return _status
        End Get
        Set(value As StudentType)
            _status = value
        End Set
    End Property




    Public Sub New()
        _status = StudentType.CurrentlyEnrolled
    End Sub

    Public Sub New(ByVal sFirstName As String, ByVal sLastName As String, ByVal sStudentID As String)
        _firstName = sFirstName
        _lastName = sLastName
        _studentID = sStudentID
    End Sub


    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property



    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property StudentID As String
        Get
            Return _studentID
        End Get
        Set(ByVal value As String)
            _studentID = value
        End Set
    End Property
End Class
