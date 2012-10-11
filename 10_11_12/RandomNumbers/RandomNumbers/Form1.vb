Public Class Form1





    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim words As String() = {"chocolate", "vanilla", "mint", "caramel fudge", "cookie dough", "neopolitan"}

        Dim r As Random = New Random()

        Dim i As Integer = r.Next()
        'reduce random to 0 to 4
        i = i Mod 6

        lblRandom.Text = i
        ListBox1.Items.Add(words(i))

    End Sub

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim r As Random = New Random()
        Dim testlimit = 1000000000

        Dim arrCount As Integer() = {0, 0, 0, 0, 0, 0}
        For i As Integer = 0 To testlimit - 1
            Dim newRandom As Integer = r.Next()
            newRandom = newRandom Mod 6
            Select Case (newRandom)
                Case 0
                    arrCount(0) = arrCount(0) + 1
                Case 1
                    arrCount(1) = arrCount(1) + 1
                Case 2
                    arrCount(2) = arrCount(2) + 1
                Case 3
                    arrCount(3) = arrCount(3) + 1
                Case 4
                    arrCount(4) = arrCount(4) + 1
                Case 5
                    arrCount(5) = arrCount(5) + 1
            End Select
        Next

        For i As Integer = 0 To arrCount.Length - 1
            lblRandom.Text = lblRandom.Text & i & " count:" & ((arrCount(i) / testlimit) * 100) & "%" & ControlChars.NewLine
        Next
    End Sub
End Class
