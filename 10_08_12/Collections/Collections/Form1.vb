Public Class Form1
    Private arrScoops As ArrayList

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblScoops.Text = String.Empty
        lblTotal.Text = String.Empty
        arrScoops = New ArrayList()
        displayScoops()
    End Sub

    Private Sub displayScoops()
     
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        arrScoops.Add(ListBox1.SelectedItem)
        displayScoops()
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If (Not arrScoops.Contains(ListBox1.SelectedItem)) Then
            lblTotal.Text = "There are no scoops of that kind ordered."
        Else
            arrScoops.Remove(ListBox1.SelectedItem)
        End If
        displayScoops()
    End Sub
End Class
