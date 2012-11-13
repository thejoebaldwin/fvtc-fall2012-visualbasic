Public Class frmEdit

    Private _studentID As String
    Private _isNewStudent As Boolean = False


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtStudentID.ReadOnly = False
        _isNewStudent = True

    End Sub

    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentID = studentID

        txtStudentID.Text = _studentID
        Dim tempStudent As Student = collStudents(_studentID)
        txtFirstName.Text = tempStudent.FirstName
        txtLastName.Text = tempStudent.LastName

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click

        If (_isNewStudent) Then
            'create new student
            Dim studentID As String = txtStudentID.Text
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text

            Dim tempStudent As Student = New Student(firstName, lastName, studentID)
            collStudents.Add(tempStudent, tempStudent.StudentID)
        Else
            'edit existing student in collection
            Dim tempStudent As Student = collStudents(_studentID)
            tempStudent.FirstName = txtFirstName.Text
            tempStudent.LastName = txtLastName.Text
        End If

        Me.Close()

    End Sub
End Class