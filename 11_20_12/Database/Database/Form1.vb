Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Const CONNECTION_STRING = "Data Source=10.4.170.5\SQLEXPRESS;Initial Catalog=NovemberNineteen;uid=vb_user;pwd=test!234;"


    Private Sub refreshData()
        Dim dbConnection As SqlConnection
        Try
            lstMessages.Items.Clear()
            dbConnection = New SqlConnection(CONNECTION_STRING)
            Dim query As String = "SELECT * FROM HelloWorld2"
            Dim dbAdapter As SqlDataAdapter = New SqlDataAdapter(query, dbConnection)
            Dim ds As DataSet = New DataSet()
            dbAdapter.Fill(ds)
            lblCount.Text = ds.Tables(0).Rows.Count
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim dr As DataRow = ds.Tables(0).Rows(i)
                Dim dataString As String = dr("id") & " - " & dr("name") & " - " & dr("message")
                lstMessages.Items.Add(dataString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConnection.Close()
        End Try
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshData()

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Dim dbConnection As SqlConnection
        Try


            dbConnection = New SqlConnection(CONNECTION_STRING)
            dbConnection.Open()
            Dim message As String = txtMessage.Text
            message = message.Replace(";", "")
            Dim name As String = txtName.Text.Replace(";", String.Empty)
            Dim command As String = String.Format("INSERT INTO HelloWorld2 (name, message) VALUES ('{0}', '{1}')", name, message)
            Dim dbCommand As SqlCommand = New SqlCommand(command, dbConnection)
            dbCommand.ExecuteNonQuery()
            refreshData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConnection.Close()
        End Try
    End Sub
End Class
