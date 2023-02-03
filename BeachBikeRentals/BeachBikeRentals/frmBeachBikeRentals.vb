' Program: Beach bike rental
' Programmer: Tam M. Nguyen
' Date: 5/20/2020
' Purpose: This application calculates and display the total
'          cost for renting a bike for specified number of days.

Option Strict On

Public Class frmBeachBikeRentals

    ' cost per bike rental use in multiple procedures
    Const _cdecPricePerDay As Decimal = 9.95D

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        ' This event handler is executed when the user click the
        ' find cost button. It calculates and displays the cost 
        ' Of the bike rented (number of days times the cost per bike).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay

        'lblCostHeading.Text = _cdecPricePerDay.ToString() _
        '    & " per days "
        lblDisplayCost.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event Handler is executed when the user click the
        ' Clear button. It clear the number of days text box 
        ' and the text property of the total cost Label.
        ' Then, it set the focus on the txtNumberOfDays Text Box object.

        txtNumberOfDays.Clear()
        lblDisplayCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Clos the window and terminate the application

        Close()
    End Sub

    Private Sub frmBeachBikeRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It clear the cost Heading, clear the text property of the
        ' Total cost Label, and set the focus on.
        ' the txtNumberOfDays Text object.

        lblCostHeading.Text = _cdecPricePerDay.ToString("C") & " per Day "
        lblDisplayCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub
End Class
