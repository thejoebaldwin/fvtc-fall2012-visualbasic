Public Class StringRobot

    Private _word As String

    Public Sub New(robotWord As String)
        _word = robotWord
    End Sub

    Public ReadOnly Property Word As String
        Get
            Return _word
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReverseString() As String
        'loop through _word in reverse order
        Dim temp As String = String.Empty
        For i As Integer = _word.Length - 1 To 0 Step -1
            temp = temp & _word(i)
        Next
        If temp = String.Empty Then
            Throw New EmptyStringException()
        End If

        Return temp
    End Function

    Public Sub Encrypt()
        Dim temp As String = String.Empty
        For i As Integer = 0 To _word.Length - 1 Step 1
            Dim ascii As Integer = Asc(_word(i))
            'encrypt 
            ascii += 10
            temp = temp & Convert.ToChar(ascii)
        Next
        _word = temp
    End Sub

    Public Sub Decrypt()
        Dim temp As String = String.Empty
        For i As Integer = 0 To _word.Length - 1 Step 1
            Dim ascii As Integer = Asc(_word(i))
            'encrypt 
            ascii -= 10
            temp = temp & Convert.ToChar(ascii)
        Next
        _word = temp
    End Sub


End Class
