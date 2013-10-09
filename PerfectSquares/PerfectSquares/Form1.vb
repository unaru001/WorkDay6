Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim n As Integer = 1
        Dim persq As Integer

        Do While n < 11
            persq = n ^ 2
            lstResult.Items.Add("The number is " & persq)
            n += 1
        Loop


    End Sub
End Class
