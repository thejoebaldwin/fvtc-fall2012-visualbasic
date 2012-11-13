Public Class frmEdit

    Private _studentID As String
    Private _newStudent As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtStudentID.ReadOnly = False
        _newStudent = True

    End Sub


    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentID = studentID
        Dim tempStudent As Student = collStudents(_studentID)
        txtFirstName.Text = tempStudent.FirstName
        txtLastName.Text = tempStudent.LastName
        txtStudentID.Text = _studentID

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click
        Try

        
        If _newStudent = True Then
            Dim tempStudent As Student = New Student(txtFirstName.Text, txtLastName.Text, txtStudentID.Text)
            collStudents.Add(tempStudent, tempStudent.StudentID)
        Else
            Dim tempStudent As Student = collStudents(_studentID)
            tempStudent.FirstName = txtFirstName.Text
            tempStudent.LastName = txtLastName.Text
        End If

            Me.Close()
        Catch ex As duplicateException
            MessageBox.Show("That Student ID already exists")
        End Try

    End Sub
End Class