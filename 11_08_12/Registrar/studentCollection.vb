
Imports System.Text
Imports System.IO

Public Class studentCollection

    Private _coll As Collection


    Public Sub New()
        _coll = New Collection()
    End Sub

    Public Sub New(fileName As String)
        _coll = New Collection()
        Dim reader As StreamReader = File.OpenText(fileName)
        While reader.Peek > -1
            Dim tempData As String = reader.ReadLine
            Dim arrData As String() = tempData.Split(",")
            If (arrData.Length = 3) Then
                Dim tempStudent As Student = New Student(arrData(0), arrData(1), arrData(2))
                _coll.Add(tempStudent, tempStudent.StudentID)
            End If
        End While
        reader.Close()


    End Sub

    Public Sub Save(fileName As String)
        Dim sbStudent As StringBuilder = New StringBuilder()

        For i As Integer = 1 To _coll.Count
            Dim tempStudent As Student = _coll(i)
            sbStudent.AppendFormat("{0},{1},{2}", tempStudent.FirstName, tempStudent.LastName, tempStudent.StudentID)
            sbStudent.AppendLine("")
        Next
        Dim fileContents As String = sbStudent.ToString()
        Dim writer As StreamWriter = File.CreateText(fileName)
        writer.WriteLine(fileContents)
        writer.Close()
    End Sub

    Public Sub Add(newStudent As Student, key As String)

        If _coll.Contains(key) Then
            Throw New duplicateException()
        Else
            _coll = Nothing
            _coll.Add(newStudent, key)

        End If
    End Sub

    Default Public ReadOnly Property Item(key As String) As Student
        Get
            Return _coll.Item(key)
        End Get
    End Property

    Default Public ReadOnly Property Item(index As Integer) As Student
        Get
            Return _coll.Item(index)
        End Get
    End Property

    Public Function Count() As Integer
        Return _coll.Count
    End Function


    Public Sub Remove(key As String)
        _coll.Remove(key)
    End Sub


End Class
