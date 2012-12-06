Imports FVTC.Messages.Data
Imports FVTC.Messages.Logic

Public Class Form1
    Private collMessages As Collection = New Collection()

    Private Sub RefreshData()
        Dim ds As DataSet = Controller.GetAllMessages()
        collMessages.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim tempMessage As Message = New Message(dr("message"), dr("name"), dr("id"))
            collMessages.Add(tempMessage, tempMessage.Id)
            lbData.Items.Add(tempMessage.Message)
        Next
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        RefreshData()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Controller.AddNewMessage(txtMessage.Text, txtName.Text)
        RefreshData()
    End Sub

    Private Sub lbData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbData.SelectedIndexChanged
        Dim tempIndex As Integer = lbData.SelectedIndex
        If (tempIndex + 1 > collMessages.Count) Then
            MessageBox.Show("outside of index")
        Else
            Dim tempMessage As Message = collMessages(tempIndex + 1)
            txtName.Text = tempMessage.Name
            txtMessage.Text = tempMessage.Message
            lblID.Text = tempMessage.Id
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim tempMessage As Message = collMessages(lbData.SelectedIndex + 1)
        Dim id As String = tempMessage.Id
        Controller.DeleteMessage(id)
        RefreshData()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim tempMessage As Message = collMessages(lbData.SelectedIndex + 1)
        Dim id As String = tempMessage.Id
        Controller.UpdateMessage(txtMessage.Text, txtName.Text, id)
        RefreshData()
    End Sub
End Class
