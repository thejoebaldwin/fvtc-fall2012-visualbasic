Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        collStudents = New studentCollection("../../students.txt")
        'collStudents.Add(New Student("Rick", "Thompson", "0123456"), "0123456")
        'collStudents.Add(New Student("Tony", "Roberts", "ABCDEFGGH"), "ABCDEFGGH")
        'collStudents.Add(New Student("John", "Smith", "11235433456"), "11235433456")
        'collStudents.Add(New Student("Sheila", "Jones", "9898789789"), "9898789789")

        updateListBox()
        clearSummary()


        

    End Sub

    Public Sub updateListBox()
        lstStudents.Items.Clear()
        For i As Integer = 1 To collStudents.Count
            'Dim tempStudent As Student = collStudents(i)
            'lstStudents.Items.Add(tempStudent.StudentID)
            lstStudents.Items.Add(collStudents(i).StudentID)
        Next
    End Sub


    Private Sub updateSummary()
        Dim studentID As String = lstStudents.SelectedItem
        Dim tempStudent As Student = collStudents(studentID)
        lblStudentID.Text = studentID
        lblFirstName.Text = tempStudent.FirstName
        lblLastName.Text = tempStudent.LastName
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStudents.SelectedIndexChanged
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        updateSummary()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim studentID As String = lstStudents.SelectedItem
        Dim editForm As frmEdit = New frmEdit(studentID)
        editForm.ShowDialog()
        updateSummary()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim editForm As frmEdit = New frmEdit()
        editForm.ShowDialog()
        updateListBox()
        lstStudents.SelectedIndex = lstStudents.Items.Count - 1

    End Sub

    Private Sub clearSummary()
        lblLastName.Text = String.Empty
        lblFirstName.Text = String.Empty
        lblStudentID.Text = String.Empty

    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim studentID As String = lstStudents.SelectedItem
        collStudents.Remove(studentID)
        updateListBox()
        clearSummary()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        collStudents.Save("../../students.txt")

    End Sub
End Class
