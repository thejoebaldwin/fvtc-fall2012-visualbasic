
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Form1

    Private Const CONNECTION_STRING = "server=23.23.147.156; user id={0}; password={1}; database=vb_demo; pooling=false;"

  



    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click

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
            For Each dr As DataRow In ds.Tables(0).Rows
                lbData.Items.Add(dr("message"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If
        End Try





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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If
        End Try

    End Sub
End Class
