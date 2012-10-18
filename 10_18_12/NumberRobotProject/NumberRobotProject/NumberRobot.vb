Public Class NumberRobot

    Private _arrNumbers As ArrayList

    Public Sub New()
        _arrNumbers = New ArrayList
    End Sub

    Public Sub Add(number As Integer)
        _arrNumbers.Add(number)
    End Sub

    'property Maximum here
    Public ReadOnly Property Maximum As Integer
        Get
            Dim biggestNumber As Integer = 0
            If _arrNumbers.Count > 0 Then
                biggestNumber = _arrNumbers(0)
                For i As Integer = 0 To _arrNumbers.Count - 1
                    If biggestNumber < _arrNumbers(i) Then
                        biggestNumber = _arrNumbers(i)
                    End If
                Next
            Else
                Throw New NoNumbersException()
            End If
            Return biggestNumber
        End Get
    End Property


End Class
