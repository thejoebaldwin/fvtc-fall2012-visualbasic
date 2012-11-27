
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class Form1

    Private Const CONNECTION_STRING = "server=23.23.147.156; user id={0}; password={0}; database=vb_demo; pooling=false;"

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
            dbConnection = New MySqlConnection(CONNECTION_STRING)
            query = "SELECT * FROM helloworld;"
            dbConnection.Open()
            dbAdapter = New MySqlDataAdapter(query, dbConnection)
            'get the data
            dbAdapter.Fill(ds)
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
End Class
