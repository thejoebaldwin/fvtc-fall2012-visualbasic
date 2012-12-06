Public Class Message

    Private _name, _message, _id As String

    Private _dateCreated As Date

    Public Sub New(messageName As String, messageMessage As String, messageId As String)
        _name = messageName
        _message = messageMessage
        _id = messageId
    End Sub


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property


    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            _message = value
        End Set
    End Property


    Public ReadOnly Property Id As String
        Get
            Return _id
        End Get
    End Property
End Class
