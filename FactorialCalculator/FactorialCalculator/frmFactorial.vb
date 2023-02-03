'Program Name: Factorial Calculator
'Author:       Tam M. Nguyen
'Date:         July 3, 2020
Option Strict On
Public Class frmFactorial
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim n, fact As Integer
        n = CInt(txtInput.Text)
        fact = 1
        For i = 1 To n
            fact = fact * i
            lstFactorialNumber.Items.Add(" ! " & fact)
        Next
        btnOk.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        btnOk.Enabled = True
        txtInput.Text = " "
        lstFactorialNumber.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
