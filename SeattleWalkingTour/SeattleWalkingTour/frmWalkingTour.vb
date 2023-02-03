' Program:     Seattle Walking Tour
' Author:      Tam M. Nguyen
' Date:        May 20, 2020
' Purpose:     This window application compute the cost of seattle walking tour.
' Program      The user enters the number of tickets need for a three-Hour
' procedures:  walking tour of the waterfront of seattle. The program calculates and display the cost of the 
'              tickets with and additional cost of $1.99 for booking using the app

Option Strict On

Public Class frmWalkingTour
    ' Cost for booking fee
    Const _cdecBookingFee As Decimal = 1.99D
    ' Cost per Ticket
    Const _cdecTickets As Decimal = 14.99D

    Private Sub frmWalkingTour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler execute when the form is loaded.
        ' It display the cost heading, clear the text property of the
        ' total cost label, and set the focus on
        ' the text number of ticket text box object.

        lblCostHeading.Text = _cdecTickets.ToString("C") & " per Tickets " & _cdecBookingFee.ToString("C") &
            " Booking Fee "
        lblTotalCost.Text = ""
        txtNumberOfTickets.Focus()
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        ' This event handler execute when the user click the
        ' Display cost button. It calculate and display the cost
        ' of the Walking Tour (Number of tickets plus booking fee)

        Dim strNumberOfTickets As String
        Dim intNumberOfTickets As Integer
        Dim decTotalCost As Decimal

        strNumberOfTickets = txtNumberOfTickets.Text
        intNumberOfTickets = Convert.ToInt32(strNumberOfTickets)
        decTotalCost = intNumberOfTickets * _cdecTickets + _cdecBookingFee
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clear the Text number of tickets box
        ' and label total cost text

        txtNumberOfTickets.Clear()
        lblTotalCost.Text = ""
        txtNumberOfTickets.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This event handler close the window and terminate the application

        Close()
    End Sub
End Class
