Imports System.IO
Imports System.Text

Public Class Form1
    Public arrCandy As CandyCollection
    Public selectedIndex As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            arrCandy = New CandyCollection()
            lblQty.Text = String.Empty
            loadCandy()
            updateListBox()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub loadCandy()
        'open the file
        Dim reader As StreamReader = File.OpenText("../../candydata.txt")
        'read each line
        While (reader.Peek > -1)
            Dim tempCandyString As String = reader.ReadLine()
            Dim tempAttributes As String() = tempCandyString.Split(",")
            If tempAttributes.Length >= 3 Then
                Dim tempCandy As Candy = New Candy(tempAttributes(2))
                tempCandy.Name = tempAttributes(0)
                tempCandy.Flavor = tempAttributes(1)
                arrCandy.Add(tempCandy, tempCandy.Name)
            End If
         
        End While
        reader.Close()
        'each line contains instance attributes
        'add new instance to the collection
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim myCandy As Candy = New Candy()
        myCandy.Name = txtName.Text
        myCandy.Flavor = txtFlavor.Text

        If arrCandy.Contains(myCandy.Name) Then
            Dim tempCandy As Candy = arrCandy(myCandy.Name)
            tempCandy.AddOne()
        Else
            arrCandy.Add(myCandy, myCandy.Name)
        End If

        updateListBox()
    End Sub

    Public Sub updateListBox()

        lstCandy.Items.Clear()
        For i As Integer = 1 To arrCandy.Count
            Dim tempCandy As Candy = arrCandy(i)
            lstCandy.Items.Add(tempCandy.Name)
        Next

        If selectedIndex < lstCandy.Items.Count Then
            lstCandy.SelectedIndex = selectedIndex
        End If


    End Sub

    Private Sub btnEat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEat.Click





        If arrCandy.Contains(lstCandy.SelectedItem) Then
            Dim tempCandy As Candy = arrCandy(lstCandy.SelectedItem)
            tempCandy.EatOne()
            If (tempCandy.Quantity = 0) Then
                'arrCandy.Remove(lstCandy.SelectedItem)
            End If
        End If






        updateListBox()


    End Sub

    Private Sub lstCandy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCandy.SelectedIndexChanged
        Dim candyName As String = lstCandy.SelectedItem
        selectedIndex = lstCandy.SelectedIndex
        Dim isFound As Boolean = False
        For i As Integer = 1 To arrCandy.Count
            If candyName = arrCandy(i).Name Then
                Dim tempCandy As Candy = arrCandy(i)
                lblQty.Text = tempCandy.Quantity
                txtName.Text = tempCandy.Name
                txtFlavor.Text = tempCandy.Flavor
                Exit For
            End If
        Next




    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If (arrCandy.Contains(lstCandy.SelectedItem)) Then
            Dim tempCandy As Candy = arrCandy(lstCandy.SelectedItem)
            tempCandy.Name = txtName.Text
            tempCandy.Flavor = txtFlavor.Text
        End If

        updateListBox()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim sbCandy As StringBuilder = New StringBuilder()

        For i As Integer = 1 To arrCandy.Count
            Dim tempCandy As Candy = arrCandy(i)
            sbCandy.AppendFormat("{0},{1},{2}{3}", tempCandy.Name, tempCandy.Flavor, tempCandy.Quantity, ControlChars.NewLine)
        Next
        Dim fileContents As String = sbCandy.ToString()
        Dim writer As StreamWriter = File.CreateText("../../candydata.txt")
        writer.WriteLine(fileContents)
        writer.Close()

    End Sub
End Class
