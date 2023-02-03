'Program Name: Broadway Ticket Group Discount
'Author:       Tam M. Nguyen
'Date:         May 28,2020
'Purpose:      This Classic Window Application calculate Broadway ticket price per person
'              discount vary on group size

Option Strict On

Public Class frmBroadwayTicket
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decTicket As Decimal
        Dim decPricePerTicket As Decimal
        Dim decTicketTotal As Decimal
        Dim decGroup1 As Decimal = 249D
        Dim decGroup2 As Decimal = 219D
        Dim decGroup3 As Decimal = 199D
        Dim decGroup4 As Decimal = 149D

        'Did user enter a numeric value
        If IsNumeric(txtTicket.Text) Then
            decTicket = Convert.ToDecimal(txtTicket.Text)
            'Is ticket greater then zero
            If decTicket > 0 Then
                'Get group cost per ticket
                Select Case decTicket
                    Case 1 To 8
                        decPricePerTicket = decGroup1
                    Case 9 To 12
                        decPricePerTicket = decGroup2
                    Case 13 To 24
                        decPricePerTicket = decGroup3
                    Case 25 To 99
                        decPricePerTicket = decGroup4
                    Case Else
                        MsgBox("Sorry! There or no special offer for 100+ ticket at the moment", , "Input Error")

                End Select
                ' Calculate and display the ticket cost
                decTicketTotal = decTicket * decPricePerTicket
                lblTicketCost.Text = "Broadway ticket total " & decTicketTotal.ToString("C")
            Else
                'Display error if the user enter a negative value
                MsgBox("You entered " & decTicket.ToString() & ". Enter a positive number ", , "Input Error")
                txtTicket.Text = ""
                txtTicket.Focus()
            End If
        Else
            'Display error if the user entered a nonnumeric value
            MsgBox("Enter a number ", , "Input Error")
            txtTicket.Text = ""
            txtTicket.Focus()
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'This event handler clear the text box object and total ticket cost label
        'and set the focus on the ticket text box.

        txtTicket.Clear()
        lblTicketCost.Text = ""
        txtTicket.Focus()
    End Sub

    Private Sub frmBroadwayTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler executed when the form is loaded at the start 
        'of the program.It set the focus on the ticket text box and clear the total ticket cost label.

        txtTicket.Focus()
        lblTicketCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler executed when the user click the exit button
        'it close and terminate the program

        Close()
    End Sub
End Class
