Public Class frmEdit

    Private _studentID As String
    Private _isNewStudent As Boolean = False


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtStudentID.ReadOnly = False
        _isNewStudent = True

        For Each value As Student.EnumStudentType In
           [Enum].GetValues(GetType(Student.EnumStudentType))
            cbStudentType.Items.Add(value)
        Next

    End Sub

    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        For Each value As Student.EnumStudentType In
   [Enum].GetValues(Student.EnumStudentType.Enrolled.GetType())
            cbStudentType.Items.Add(value)
        Next

        ' Add any initialization after the InitializeComponent() call.
        _studentID = studentID

   


        txtStudentID.Text = _studentID
        Dim tempStudent As Student = collStudents(_studentID)
        txtFirstName.Text = tempStudent.FirstName
        txtLastName.Text = tempStudent.LastName
        cbStudentType.SelectedItem = tempStudent.StudentType
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click
        Try

        

        If (_isNewStudent) Then
            'create new student
            Dim studentID As String = txtStudentID.Text
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text



                Dim tempStudent As Student = New Student(firstName, lastName, studentID)


                tempStudent.StudentType = cbStudentType.SelectedItem

            collStudents.Add(tempStudent, tempStudent.StudentID)
        Else
            'edit existing student in collection
            Dim tempStudent As Student = collStudents(_studentID)
            tempStudent.FirstName = txtFirstName.Text
                tempStudent.LastName = txtLastName.Text
                tempStudent.StudentType = cbStudentType.SelectedItem
        End If
            Me.Close()
        Catch ex As StudentException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class