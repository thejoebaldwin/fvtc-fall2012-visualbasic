Public Class MillimeterCalculator

    Private Sub MillimeterCalculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMillimeters.Text = String.Empty
        lblError.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click


        'Declare Variables
        Dim inches, millimeters As Double
        'Get inches from user
        If IsNumeric(txtInches.Text) Then
            inches = txtInches.Text
            lblError.Text = String.Empty
            'calculate inches to millimeters: 1 inch = 25.4 millimeter
            millimeters = inches * 25.4
            'display millimeters to user
            lblMillimeters.Text = millimeters
        Else
            lblError.Text = "Please enter a numeric value"
            lblMillimeters.Text = String.Empty
        End If




    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Me.Close()
        Application.Exit()
    End Sub
End Class
