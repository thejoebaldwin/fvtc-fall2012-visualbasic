Public Class Form1


    Dim arrScoops As ArrayList

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblScoops.Text = String.Empty
        lblTotal.Text = String.Empty

        arrScoops = New ArrayList()


        'display any initial values (empty order)
        displayScoops()
    End Sub

    ''' <summary>
    ''' code to display the scoops ordered
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayScoops()
        Dim output As String = ""
        For i As Integer = 0 To arrScoops.Count - 1
            output = output & arrScoops(i) & ","
        Next
        output = output.TrimEnd(",")
        lblScoops.Text = output
    End Sub

    ''' <summary>
    ''' Add a scoop to the order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim flavor As String = ListBox1.SelectedItem

        'For i As Integer = 0 To arrScoops.Count - 1
        '    If arrScoops(i) = String.Empty Then
        '        arrScoops(i) = flavor
        '        Exit For
        '    End If
        'Next
        arrScoops.Add(flavor)

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
        Dim flavor As String = ListBox1.SelectedItem

        If arrScoops.Contains(flavor) Then
            arrScoops.Remove(flavor)
        Else
            MessageBox.Show("dont have that flavor ordered!")

        End If


        'display updated scoops in order
        displayScoops()
    End Sub
End Class
