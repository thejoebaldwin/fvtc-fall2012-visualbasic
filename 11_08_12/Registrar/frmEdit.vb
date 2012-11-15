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
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        'For Each value As Student.StudentType In [Enum].GetValues(Student.StudentType.CurrentlyEnrolled.GetType())
        For Each value As Student.StudentType In
            [Enum].GetValues(Student.StudentType.CurrentlyEnrolled.GetType())

            cbStatus.Items.Add(value)

        Next







        'or hard coded (not the best way)
        'cbStatus.Items.Add(Student.StudentType.CurrentlyEnrolled)
        'cbStatus.Items.Add(Student.StudentType.Graduated)
        'cbStatus.Items.Add(Student.StudentType.NewStudent)
        'cbStatus.Items.Add(Student.StudentType.ReturningStudent)





        Dim tempStudent As Student = collStudents(_studentID)
        txtFirstName.Text = tempStudent.FirstName
        txtLastName.Text = tempStudent.LastName
        txtStudentID.Text = _studentID
        cbStatus.SelectedItem = tempStudent.Status


    End Sub

    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click
        Try


            If _newStudent = True Then
                Dim tempStudent As Student = New Student(txtFirstName.Text, txtLastName.Text, txtStudentID.Text)
                tempStudent.Status = cbStatus.SelectedItem
                collStudents.Add(tempStudent, tempStudent.StudentID)
            Else
                Dim tempStudent As Student = collStudents(_studentID)
                tempStudent.FirstName = txtFirstName.Text
                tempStudent.LastName = txtLastName.Text
                tempStudent.Status = cbStatus.SelectedItem
            End If

            Me.Close()
        Catch ex As duplicateException
            MessageBox.Show("That Student ID already exists")
        Catch ex As Exception
            MessageBox.Show("A serious error has occured")
        End Try

    End Sub
End Class