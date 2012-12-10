Imports FVTC.Messages.Data

Public Class Form1

    Private collMessage As Collection = New Collection()
    Private collName As Collection = New Collection()
    Private collID As Collection = New Collection()

    Private Sub RefreshData()
        Dim ds As DataSet = New DataSet()
        Dim query As String = "SELECT * FROM helloworld"
        ds = EC2MySQL.SelectData(query)
        collMessage.Clear()
        collName.Clear()
        collID.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            lbData.Items.Add(dr("message"))
            collMessage.Add(dr("message"))
            collName.Add(dr("name"))
            collID.Add(dr("id"))
        Next
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        RefreshData()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim command As String = String.Empty
        command = "INSERT INTO `vb_demo`.`helloworld` (`message`, `name`) VALUES ('{0}', '{1}');"
        command = String.Format(command, txtMessage.Text, txtName.Text)
        EC2MySQL.ExecuteSqlCommand(command)
        RefreshData()
    End Sub

    Private Sub lbData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbData.SelectedIndexChanged
        Dim tempIndex As Integer = lbData.SelectedIndex
        If (tempIndex + 1 > collName.Count) Then
            MessageBox.Show("outside of index")
        Else
            txtName.Text = collName(tempIndex + 1)
            txtMessage.Text = collMessage(tempIndex + 1)
            lblID.Text = collID(tempIndex + 1)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim id As String = collID(lbData.SelectedIndex + 1)
        Dim command As String = "DELETE FROM helloworld WHERE id={0};"
        command = String.Format(command, id)
        EC2MySQL.ExecuteSqlCommand(command)
        RefreshData()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim id As String = collID(lbData.SelectedIndex + 1)
        Dim command As String = "UPDATE helloworld SET message = '{0}', name = '{1}' WHERE id= {2};"
        command = String.Format(command, txtMessage.Text, txtName.Text, id)
        EC2MySQL.ExecuteSqlCommand(command)
        RefreshData()
    End Sub
End Class
