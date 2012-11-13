Public Class frmMain

    Public collStudents As Collection


    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblFirstName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblStudentID.Text = String.Empty

        collStudents = New Collection()
        Dim tempStudent As Student = New Student("Tony", "Smith", "0123456")
        collStudents.Add(tempStudent, tempStudent.StudentID)
        tempStudent = New Student("Tina", "Johnson", "999345")
        collStudents.Add(tempStudent, tempStudent.StudentID)
        tempStudent = New Student("Rick", "Paulson", "887654")
        collStudents.Add(tempStudent, tempStudent.StudentID)

        updateListBox()
    End Sub

    Private Sub updateListBox()
        lstStudents.Items.Clear()
        For i As Integer = 1 To collStudents.Count
            Dim tempStudent As Student = collStudents(i)
            lstStudents.Items.Add(tempStudent.StudentID)
        Next
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStudents.SelectedIndexChanged

        'MessageBox.Show(lstStudents.SelectedItem)
        Dim tempStudent As Student = collStudents(lstStudents.SelectedItem)
        lblStudentID.Text = tempStudent.StudentID
        lblFirstName.Text = tempStudent.FirstName
        lblLastName.Text = tempStudent.LastName

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

        Dim editForm As frmEdit = New frmEdit(lstStudents.SelectedItem)
        editForm.ShowDialog()


    End Sub
End Class
