Public Class Form1


    Private myValue As Integer = 2000

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblBeforeValue.Text = myValue
    End Sub

    Private Sub btnByReference_Click(sender As System.Object, e As System.EventArgs) Handles btnByReference.Click
        superReferenceSub(myValue)
        lblAfterValue.Text = myValue
    End Sub

    Private Sub btnByValue_Click(sender As System.Object, e As System.EventArgs) Handles btnByValue.Click
        superValueSub(myValue)
        lblAfterValue.Text = myValue
    End Sub

    Public Sub superValueSub(tempValue As Integer)
        tempValue += 999999
    End Sub

    Public Sub superReferenceSub(ByRef tempValue As Integer)
        tempValue += 999999
    End Sub

End Class
