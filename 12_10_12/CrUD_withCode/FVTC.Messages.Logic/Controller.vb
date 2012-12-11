
Imports FVTC.Messages.Data

Public Class Controller


    Public Shared Function getAllMessages() As DataSet
        Dim ds As DataSet = New DataSet()
        Dim query As String = "SELECT * FROM helloworld"
        ds = EC2MySQL.SelectData(query)
        Return ds
    End Function

    Public Shared Sub addNewMessage(name As String, message As String)
        Dim command As String = String.Empty
        command = "INSERT INTO `vb_demo`.`helloworld` (`message`, `name`) VALUES ('{0}', '{1}');"
        command = String.Format(command, message, name)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub

    Private Shared Function cleanInput(input As String) As String
        input = input.Replace("#", String.Empty)
        input = input.Replace("$", String.Empty)
        input = input.Replace("@@@", String.Empty)
        Return input.Replace(";", String.Empty)
    End Function


    Public Shared Sub updateMessage(name As String, message As String, id As String)
        Dim command As String = "UPDATE helloworld SET message = '{0}', name = '{1}' WHERE id= {2};"
        message = cleanInput(message)
        name = cleanInput(name)
        command = String.Format(command, message, name, id)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub

    Public Shared Sub deleteMessage(id As String)
        Dim command As String = "DELETE FROM helloworld WHERE id={0};"
        command = String.Format(command, id)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub


End Class
