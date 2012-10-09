Public Class Form1
    Private arrScoops As ArrayList

    ''' <summary>
    ''' initialize form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblScoops.Text = String.Empty
        lblTotal.Text = String.Empty
        'have to declare as "new" or variable arrScoops will be null
        arrScoops = New ArrayList()
        'display any initial values (empty order)
        displayScoops()
    End Sub

    ''' <summary>
    ''' code to display the scoops ordered
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayScoops()
        Dim message As String = String.Empty
        For i As Integer = 0 To arrScoops.Count - 1
            message = message & arrScoops(i) & ", "
        Next
        lblScoops.Text = message
    End Sub

    ''' <summary>
    ''' Add a scoop to the order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        arrScoops.Add(ListBox1.SelectedItem)
        'display updated scoops in order
        displayScoops()
    End Sub

    ''' <summary>
    ''' Remove a scoop from the order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        'user "Contains" to see if value exists in the arraylist
        If (Not arrScoops.Contains(ListBox1.SelectedItem)) Then
            lblTotal.Text = "There are no scoops of that kind ordered."
        Else
            arrScoops.Remove(ListBox1.SelectedItem)
        End If
        'display updated scoops in order
        displayScoops()
    End Sub
End Class
