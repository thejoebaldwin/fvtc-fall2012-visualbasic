
Imports System.IO



Public Class Form1

    Public arrMovies As ArrayList
    Public collMovies As Collection

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        arrMovies = New ArrayList()
        collMovies = New Collection()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim myMovie As Movie = New Movie(txtTitle.Text, txtYear.Text, txtActor.Text)
        arrMovies.Add(myMovie)
        collMovies.Add(myMovie, myMovie.Title)
        UpdateDisplay()

    End Sub

    Private Sub UpdateDisplay()
        lstMovies.Items.Clear()
        'For i As Integer = 0 To arrMovies.Count - 1
        '    Dim tempMovie As Movie = arrMovies(i)
        '    lstMovies.Items.Add(tempMovie.Title)
        'Next
        For i As Integer = 1 To collMovies.Count
            Dim tempMovie As Movie = collMovies(i)
            lstMovies.Items.Add(tempMovie.Title)
        Next


    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If collMovies.Contains(txtSearch.Text) = True Then
            MessageBox.Show("Found it!")
            Dim myMovie As Movie = collMovies(txtSearch.Text)
        Else
            MessageBox.Show("Not Found")
        End If



    End Sub
End Class
