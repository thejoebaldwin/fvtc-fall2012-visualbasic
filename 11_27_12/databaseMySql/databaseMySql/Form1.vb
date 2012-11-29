
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class Form1

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
            lbData.Items.Clear()
            'output
            For Each dr As DataRow In ds.Tables(0).Rows
                lbData.Items.Add(dr("message"))
            Next
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
        Dim command As String = String.Format("INSERT INTO helloworld (message) VALUES ('{0}');", txtMessage.Text)
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
End Class
