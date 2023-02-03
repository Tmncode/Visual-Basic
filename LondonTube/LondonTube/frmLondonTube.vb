'Program: London Tube Ticket
'Author:  Tam M. Nguyen
'Date:    May 27,2020
'Purpose: This Classic Window Application calculate the ticket cost of London Tube.

Option Strict On

Public Class frmLondonTube
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This event handler executed when the user click the calculate button
        'It calculate the ticket cost based on the Zone

        Dim decTicket As Decimal
        Dim decTicketCost As Decimal
        Dim decTotalCost As Decimal
        Dim decZone1Cost As Decimal = 6.00818D
        Dim decZone2Cost As Decimal = 7.23594D
        Dim decZone3Cost As Decimal = 7.35858D

        If IsNumeric(txtTicket.Text) Then
            decTicket = Convert.ToDecimal(txtTicket.Text)
            If decTicket > 0 Then
                If radZone1.Checked Then
                    decTicketCost = decZone1Cost
                ElseIf radZone2.Checked Then
                    decTicketCost = decZone2Cost
                ElseIf radZone3.Checked Then
                    decTicketCost = decZone3Cost
                End If
                decTotalCost = decTicket * decTicketCost
                lblTicketCost.Text = "Ticket total " & decTotalCost.ToString("C")
            Else
                MsgBox("You entered " & decTicket.ToString() & ". Enter a postive number", , "Input Error")
                txtTicket.Text = ""
                txtTicket.Focus()
            End If
        Else
            MsgBox("You must enter a number", , "Input Error")
            txtTicket.Text = ""
            txtTicket.Focus()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtTicket.Clear()
        lblTicketCost.Text = ""
        radZone1.Checked = True
        radZone2.Checked = False
        radZone3.Checked = False
        txtTicket.Focus()
    End Sub

    Private Sub frmLondonTube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTicket.Focus()
        lblTicketCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
