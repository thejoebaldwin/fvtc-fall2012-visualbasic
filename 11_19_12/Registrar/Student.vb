Public Class Student
    Private _firstName As String
    Private _lastName As String
    'studentID should not be longer than 10 characters
    Private _studentID As String
    Private _studentType As EnumStudentType

    Public Property StudentType As EnumStudentType
        Get
            Return _studentType
        End Get
        Set(value As EnumStudentType)
            _studentType = value
        End Set
    End Property


    Public Enum EnumStudentType As Integer
        Returning
        Enrolled
        Graduated
        Expelled
    End Enum

    Public Sub New()
        _studentType = EnumStudentType.Enrolled
    End Sub

    Public Sub New(ByVal sFirstName As String, ByVal sLastName As String, ByVal sStudentID As String)

        If (sFirstName.ToUpper() <> sFirstName) Then
            'do something
            Throw New StudentException("Please enter your first name in all upper case letters")
        Else
            _firstName = sFirstName
        End If

        _lastName = sLastName
        If (sStudentID.Length > 10) Then
            'do something 
            Throw New StudentException("Student ID cannot be longer than 10 characters")
        Else
            _studentID = sStudentID
        End If
        _studentType = EnumStudentType.Enrolled
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
