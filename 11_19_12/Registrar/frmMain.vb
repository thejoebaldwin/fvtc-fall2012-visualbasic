Imports System.IO
Imports System.Text

Public Class frmMain



    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblFirstName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblStudentID.Text = String.Empty

        collStudents = New studentCollection()
        'Dim tempStudent As Student = New Student("Tony", "Smith", "0123456")
        'collStudents.Add(tempStudent, tempStudent.StudentID)
        'tempStudent = New Student("Tina", "Johnson", "999345")
        'collStudents.Add(tempStudent, tempStudent.StudentID)
        'tempStudent = New Student("Rick", "Paulson", "887654")
        'collStudents.Add(tempStudent, tempStudent.StudentID)

        collStudents.Load("../../students.txt")

        


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

    Private Sub UpdateSummary()
        Dim tempStudent As Student = collStudents(lstStudents.SelectedItem)
        lblStudentID.Text = tempStudent.StudentID
        lblFirstName.Text = tempStudent.FirstName
        lblLastName.Text = tempStudent.LastName
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStudents.SelectedIndexChanged
        btnEdit.Enabled = True
        'MessageBox.Show(lstStudents.SelectedItem)
        UpdateSummary()

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

        Dim editForm As frmEdit = New frmEdit(lstStudents.SelectedItem)
        editForm.ShowDialog()

        Dim selectedIndex As Integer = lstStudents.SelectedIndex
        updateListBox()
        lstStudents.SelectedIndex = selectedIndex
        'UpdateSummary()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim editform As frmEdit = New frmEdit()
        editform.ShowDialog()
        updateListBox()
        lstStudents.SelectedIndex = lstStudents.Items.Count - 1
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        collStudents.Remove(lstStudents.SelectedItem)
        updateListBox()
        lblFirstName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblStudentID.Text = String.Empty
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        collStudents.Save("../../students.txt")

    End Sub
End Class
