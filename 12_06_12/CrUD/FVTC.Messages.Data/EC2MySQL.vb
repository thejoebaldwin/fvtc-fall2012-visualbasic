Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class EC2MySQL

    'replace the <USERNAME> and <PASSWORD> with those provided out on blackboard
    Private Const CONNECTION_STRING = "server=23.23.147.156;user id=vb_user;password=test!234;database=vb_demo;pooling=false;"

    Private _connectionString As String

    Public Sub New()
        'initialize stuff

        _connectionString = CONNECTION_STRING

    End Sub


    Public Sub New(connectionString As String)

        _connectionString = connectionString

    End Sub


    Public Shared Function SelectData(query As String) As DataSet
        If (CONNECTION_STRING.Contains("<USERNAME>")) Then
            Throw New Exception("Did you forget to replace the credentials in the connection string?")
        End If
        Dim dbConnection As MySqlConnection = Nothing
        Dim dbAdapter As MySqlDataAdapter
        Dim ds As DataSet = New DataSet()
        dbConnection = New MySqlConnection(CONNECTION_STRING)
        dbConnection.Open()
        dbAdapter = New MySqlDataAdapter(query, dbConnection)
        dbAdapter.Fill(ds)

        If (Not dbConnection Is Nothing) Then
            dbConnection.Close()
        End If

        Return ds
    End Function

    Public Shared Sub ExecuteSqlCommand(ByVal command As String)
        If (CONNECTION_STRING.Contains("<USERNAME>")) Then
            Throw New Exception("Did you forget to replace the credentials in the connection string?")
        End If
        Dim dbConnection As MySqlConnection = Nothing
        dbConnection = New MySqlConnection(CONNECTION_STRING)
        dbConnection.Open()
        Dim dbCommand As MySqlCommand = New MySqlCommand(command, dbConnection)
        dbCommand.ExecuteNonQuery()
        If (Not dbConnection Is Nothing) Then
            dbConnection.Close()
        End If
    End Sub



End Class
