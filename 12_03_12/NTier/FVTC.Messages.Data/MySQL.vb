Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class MySQL


    Private Const CONNECTION_STRING = "server=23.23.147.156; user id=vb_user; password=test!234; database=vb_demo; pooling=false;"


    Public Shared Function SelectQuery(query As String) As DataSet

        'query code here

        Return New DataSet()
    End Function


    Public Shared Sub ExecuteSqlCommand(ByVal command As String)

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
