Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim curYear As Integer = 2012
        Dim pop As Double = 7000000000.0

        Do While (pop > 6000000.0)
            curYear -= 50
            pop /= 2


        Loop
        MessageBox.Show("The year is " & curYear, "Error")

    End Sub
End Class
