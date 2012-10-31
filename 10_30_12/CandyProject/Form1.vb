Public Class Form1
    Public arrCandy As Collection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrCandy = New Collection()
        lblQty.Text = String.Empty
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

    End Sub

    Private Sub btnEat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEat.Click



     

        If arrCandy.Contains(lstCandy.SelectedItem) Then
            Dim tempCandy As Candy = arrCandy(lstCandy.SelectedItem)
            tempCandy.EatOne()
            If (tempCandy.Quantity = 0) Then
                arrCandy.Remove(lstCandy.SelectedItem)
            End If
        End If
     
        




        updateListBox()


    End Sub

    Private Sub lstCandy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCandy.SelectedIndexChanged
        Dim candyName As String = lstCandy.SelectedItem
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
End Class
