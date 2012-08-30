Public Class frmExpenses

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub frmExpenses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'approach #1
        'TextBox1.Text = String.Empty
        'TextBox2.Text = String.Empty
        'TextBox3.Text = String.Empty
        'TextBox4.Text = String.Empty
        'TextBox5.Text = String.Empty

        'approach #2
        'For counter As Integer = 1 To 20
        '    If (Me.Controls.Find("txtExpense" & counter.ToString(), True).Length > 0) Then
        '        Dim genericControl As Control = Me.Controls.Find("txtExpense" & counter.ToString(), True)(0)
        '        genericControl.Text = String.Empty
        '    End If
        'Next

        'approach #3
        Dim counter As Integer = 1
        Dim isControlFound As Boolean = False
        Do
            isControlFound = Me.Controls.Find("txtExpense" & counter.ToString(), True).Length > 0
            If (isControlFound) Then
                Dim genericControl As Control = Me.Controls.Find("txtExpense" & counter.ToString(), True)(0)
                genericControl.Text = String.Empty
            End If
            counter += 1
        Loop While isControlFound
    End Sub

    Public Function getTotal() As Double
        Dim total As Double
        total += txtExpense1.Text
        total += txtExpense2.Text
        total += txtExpense3.Text
        total += txtExpense4.Text
        total += txtExpense5.Text
        Return total
    End Function

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        lblTotal.Text = getTotal()

    End Sub
End Class
