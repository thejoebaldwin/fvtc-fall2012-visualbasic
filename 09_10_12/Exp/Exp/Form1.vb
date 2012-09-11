Public Class Form1
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Function displayResults(i As Integer)
        CType(Me.Controls.Find("lblAnswer" & i.ToString(), True)(0), Label).Text = Convert.ToInt16(txtBase.Text).ToString() & "^" & Convert.ToInt16(txtExponent.Text) + (i - 1)
        CType(Me.Controls.Find("txtAnswer" & i.ToString(), True)(0), TextBox).Text = Convert.ToInt16(txtBase.Text) ^ (Convert.ToInt16(txtExponent.Text) + (i - 1))
        Return i - 1
    End Function

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        If Not IsNumeric(txtBase.Text) Or Not IsNumeric(txtExponent.Text) Then MessageBox.Show("Please check your input") Else displayResults(displayResults(displayResults(displayResults(displayResults(displayResults(displayResults(displayResults(displayResults(9)))))))))
    End Sub

End Class
