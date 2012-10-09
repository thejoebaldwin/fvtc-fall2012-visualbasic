Public Class Form1

    ''' <summary>
    ''' initialize form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblScoops.Text = String.Empty
        lblTotal.Text = String.Empty
        
        'display any initial values (empty order)
        displayScoops()
    End Sub

    ''' <summary>
    ''' code to display the scoops ordered
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayScoops()
        
    End Sub

    ''' <summary>
    ''' Add a scoop to the order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

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
        
        'display updated scoops in order
        displayScoops()
    End Sub
End Class
