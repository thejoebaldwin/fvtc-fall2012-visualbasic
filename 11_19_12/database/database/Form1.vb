
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Const CONNECTION_STRING = "Data Source=10.4.170.5\SQLEXPRESS;Initial Catalog=NovemberNineteen;uid=vb_user;pwd=test!234;"


    Private Sub refreshData()
        Try
            Dim dbConnection As SqlConnection = New SqlConnection(CONNECTION_STRING)
            Dim query As String = "SELECT * FROM HelloWorld2"
            Dim dbAdapter As SqlDataAdapter = New SqlDataAdapter(query, dbConnection)
            Dim ds As DataSet = New DataSet()
            dbAdapter.Fill(ds, "HelloWorld")
            'after this point is up to you what you do with the data


            'Label1.Text = ds.Tables("HelloWorld").Rows.Count
            Dim dt As DataTable = ds.Tables("HelloWorld")

            For i As Integer = 0 To dt.Rows.Count - 1
                ListBox1.Items.Add(dt.Rows(i)("message") & "||" & dt.Rows(i)("name"))
            Next



            dbConnection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshData()





    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        Dim dbConnection As SqlConnection = New SqlConnection(CONNECTION_STRING)
        dbConnection.Open()

        Dim name As String = txtName.Text.Replace(";", String.Empty)
        Dim message As String = txtMessage.Text.Replace(";", String.Empty)




        Dim query As String = String.Format("INSERT INTO HelloWorld2 (name,message) VALUES ('{0}', '{1}')", name, message)
        Dim dbCommand As SqlCommand = New SqlCommand(query, dbConnection)
        dbCommand.ExecuteNonQuery()
        dbConnection.Close()
        refreshData()
    End Sub





   


End Class
