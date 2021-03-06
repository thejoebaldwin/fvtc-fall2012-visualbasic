﻿Imports System.Data
Imports FVTC.Messages.Data

Public Class Controller

    Public Shared Function GetAllMessages() As DataSet
        Dim query As String = "SELECT * FROM helloworld"
        Dim ds As DataSet = EC2MySQL.SelectData(query)
        Return ds
    End Function

    Private Shared Function cleanInput(input As String) As String
        input = input.Replace(";", String.Empty)
        input = input.Replace("#", String.Empty)
        input = input.Replace("SELECT", String.Empty)
        Return input
    End Function

    Public Shared Sub AddNewMessage(message As String, name As String)
        Dim command As String = String.Empty
        command = "INSERT INTO `vb_demo`.`helloworld` (`message`, `name`) VALUES ('{0}', '{1}');"
        message = cleanInput(message)
        name = cleanInput(name)
        command = String.Format(command, message, name)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub

    Public Shared Sub UpdateMessage(message As String, name As String, id As String)
        Dim command As String = "UPDATE helloworld SET message = '{0}', name = '{1}' WHERE id= {2};"
        message = cleanInput(message)
        name = cleanInput(name)
        command = String.Format(command, message, name, id)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub

    Public Shared Sub DeleteMessage(id As String)
        Dim command As String = "DELETE FROM helloworld WHERE id={0};"
        command = String.Format(command, id)
        EC2MySQL.ExecuteSqlCommand(command)
    End Sub



End Class
