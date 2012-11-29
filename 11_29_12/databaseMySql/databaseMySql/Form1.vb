'DOWNLOAD MYSQL CONNECTOR FOR .NET HERE
'http://dev.mysql.com/downloads/connector/net/


Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class Form1

    Public collMessages As Collection = New Collection
    Public collIDs As Collection = New Collection


    Private Const CONNECTION_STRING = "server=23.23.147.156; user id={0}; password={1}; database=vb_demo; pooling=false;"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
    End Sub

    Private Sub btnQuery_Click(sender As System.Object, e As System.EventArgs) Handles btnQuery.Click

        'declare these variables outside the try catch so we can close the connection in the finally clause
        Dim dbConnection As MySqlConnection = Nothing
        Dim dbAdapter As MySqlDataAdapter
        Dim ds As DataSet = New DataSet()
        Dim query As String
        Try
            'get username and password from the form
            Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)
            'set up connection
            dbConnection = New MySqlConnection(connectionWithCredentials)
            query = "SELECT * FROM helloworld;"
            dbConnection.Open()
            dbAdapter = New MySqlDataAdapter(query, dbConnection)
            'get the data
            dbAdapter.Fill(ds)
            'lbData.Items.Clear()
            'output

            collMessages.Clear()
            collIDs.Clear()


            For Each dr As DataRow In ds.Tables(0).Rows
                collMessages.Add(dr("message"))
                collIDs.Add(dr("id"))
            Next

            lbData.DataSource = collMessages


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'if not null then close the conenction
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If

        End Try


    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)

        Dim dbConnection As MySqlConnection = Nothing
        Dim dbAdapter As MySqlDataAdapter
        Dim ds As DataSet = New DataSet()
        Dim command As String = String.Format("INSERT INTO helloworld (message, name) VALUES ('{0}', '{1}');", txtMessage.Text, txtName.Text)
        Try
            'get username and password from the form

            'set up connection
            dbConnection = New MySqlConnection(connectionWithCredentials)
            dbConnection.Open()
            Dim dbCommand As MySqlCommand = New MySqlCommand(command, dbConnection)
            dbCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConnection.Close()

        End Try


    End Sub

    Private Sub lbData_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbData.SelectedIndexChanged

        'declare these variables outside the try catch so we can close the connection in the finally clause
        Dim dbConnection As MySqlConnection = Nothing
        Dim dbAdapter As MySqlDataAdapter
        Dim ds As DataSet = New DataSet()
        Dim query As String
        Try
            'get username and password from the form
            Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)
            'set up connection
            dbConnection = New MySqlConnection(connectionWithCredentials)



            Dim id As String = collIDs(lbData.SelectedIndex + 1)



            query = String.Format("SELECT * FROM helloworld WHERE id = {0};", id)
            dbConnection.Open()
            dbAdapter = New MySqlDataAdapter(query, dbConnection)
            'get the data
            dbAdapter.Fill(ds)
            'output
            If (ds.Tables(0).Rows.Count = 1) Then
                'same thing
                'Dim dr As DataRow = ds.Tables(0).Rows(0)
                'txtMessage.Text = dr("message")
                txtMessage.Text = ds.Tables(0).Rows(0)("message")
                txtName.Text = ds.Tables(0).Rows(0)("name")
            Else
                '????
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'if not null then close the conenction
            If (Not dbConnection Is Nothing) Then
                dbConnection.Close()
            End If

        End Try


    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click


        Dim connectionWithCredentials As String = String.Format(CONNECTION_STRING, txtUserName.Text, txtPassword.Text)

        Dim dbConnection As MySqlConnection = Nothing
        Dim id As String = collIDs(lbData.SelectedIndex + 1)
        Dim command As String = String.Format("DELETE FROM helloworld WHERE id = {0}", id)
        Try


            'set up connection
            dbConnection = New MySqlConnection(connectionWithCredentials)
            dbConnection.Open()
            Dim dbCommand As MySqlCommand = New MySqlCommand(command, dbConnection)
            dbCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConnection.Close()

        End Try



    End Sub
End Class
