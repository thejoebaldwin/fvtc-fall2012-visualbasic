Imports System.IO
Imports System.Text

Public Class studentCollection

    Private _coll As Collection

    Public Sub New()
        _coll = New Collection
    End Sub

    Public Sub Add(newStudent As Student, key As String)
        _coll.Add(newStudent, key)
    End Sub

    Public Sub Remove(key As String)
        _coll.Remove(key)
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

    Public Sub Load(filePath As String)
        Dim reader As StreamReader = File.OpenText(filePath)
        While (reader.Peek > -1)
            Dim data As String = reader.ReadLine
            Dim arrAttributes As String() = data.Split(",")
            If (arrAttributes.Length = 4) Then
                Dim firstName As String = arrAttributes(0)
                Dim lastName As String = arrAttributes(1)
                Dim studentID As String = arrAttributes(2)
                Dim studentType As Student.EnumStudentType = arrAttributes(3)
                Dim tempStudent As Student = New Student(firstName, lastName, studentID)
                tempStudent.StudentType = studentType
                _coll.Add(tempStudent, tempStudent.StudentID)
            End If
        End While
        reader.Close()
    End Sub

    Public Sub Save(filePath As String)


        Dim sbStudent As StringBuilder = New StringBuilder()

        'build the string
        For i As Integer = 1 To _coll.Count
            Dim tempStudent As Student = _coll(i)
            'firstName,lastName,studentID
            '{0},{1},{2} newline
            sbStudent.AppendFormat("{0},{1},{2},{3}", tempStudent.FirstName, tempStudent.LastName, tempStudent.StudentID, CType(tempStudent.StudentType, Integer))
            sbStudent.AppendLine(String.Empty)
        Next

        'write it to the file
        Dim writer As StreamWriter = File.CreateText(filePath)
        writer.WriteLine(sbStudent.ToString())
        writer.Close()

    End Sub


    Public Function Count() As Integer
        'Dim o As Object = _coll.Item("090909")



        Return _coll.Count
    End Function





End Class
