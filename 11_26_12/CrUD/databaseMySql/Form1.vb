
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Form1

    Private Const CONNECTION_STRING = "server=23.23.147.156; user id={0}; password={1}; database=vb_demo; pooling=false;"

  
    Private collMessage As Collection = New Collection()
    Private collName As Collection = New Collection()
    Private collID As Collection = New Collection()


    Private Sub RefreshData()
        Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)

        Dim dbConnection As MySqlConnection = Nothing
        Dim dbAdapter As MySqlDataAdapter
        Dim ds As DataSet = New DataSet()
        Dim query As String

        Try

            dbConnection = New MySqlConnection(connectionWithCredentials)
            dbConnection.Open()
            query = "SELECT * FROM helloworld"
            dbAdapter = New MySqlDataAdapter(query, dbConnection)
            dbAdapter.Fill(ds)
            lbData.Items.Clear()
            collMessage.Clear()
            collName.Clear()
            collID.Clear()
            For Each dr As DataRow In ds.Tables(0).Rows
                lbData.Items.Add(dr("message"))
                collMessage.Add(dr("message"))
                collName.Add(dr("name"))
                collID.Add(dr("id"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If
        End Try
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click

     
        RefreshData()




    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)

        Dim dbConnection As MySqlConnection = Nothing
        Dim command As String = String.Empty
        command = "INSERT INTO `vb_demo`.`helloworld` (`message`, `name`) VALUES ('{0}', '{1}');"
        command = String.Format(command, txtMessage.Text, txtName.Text)
        Try

            dbConnection = New MySqlConnection(connectionWithCredentials)
            dbConnection.Open()
            Dim dbCommand As MySqlCommand = New MySqlCommand(command, dbConnection)
            dbCommand.ExecuteNonQuery()
            RefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If
        End Try

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

    Private Sub ExecuteSqlCommand(ByVal command As String)
        Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)
        Dim dbConnection As MySqlConnection = Nothing
        Try
            dbConnection = New MySqlConnection(connectionWithCredentials)
            dbConnection.Open()
            Dim dbCommand As MySqlCommand = New MySqlCommand(command, dbConnection)
            dbCommand.ExecuteNonQuery()
            RefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim id As String = collID(lbData.SelectedIndex + 1)
        Dim command As String = "DELETE FROM helloworld WHERE id={0};"
        command = String.Format(command, id)

        ExecuteSqlCommand(command)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
      

        Dim id As String = collID(lbData.SelectedIndex + 1)
        Dim command As String = "UPDATE helloworld SET message = '{0}', name = '{1}' WHERE id= {2};"
        Dim message As String = txtMessage.Text.Replace(";", String.Empty)
        Dim name As String = txtName.Text.Replace(";", String.Empty)
        command = String.Format(command, message, name, id)
        ExecuteSqlCommand(command)

    End Sub
End Class
