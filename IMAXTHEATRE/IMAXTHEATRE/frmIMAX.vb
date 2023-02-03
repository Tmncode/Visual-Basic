' Program Name:  IMAX THEATRE
' Author:        Tam M. Nguyen
' Date:          August 20, 2020
' Purpose:       The IMAX application computes the cost of matinee and evening tickets with varyimg base and data plans

Option Strict On

Public Class frmIMAX

    Private Sub cboTicketChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTicketChoice.SelectedIndexChanged
        ' This event handler allows the user to enter there Imax choice and then calls subprocedures to place the Imax type
        Dim intTicketChoice As Integer

        intTicketChoice = cboTicketChoice.SelectedIndex

        ' Make items visible in the window
        lblTickets.Visible = True
        txtTickets.Visible = True
        btnCost.Visible = True
        btnClear.Visible = True
        lblTotal.Visible = True
        ' Clear label 
        lblTotal.Text = ""
        ' set focus on the number in textbox
        txtTickets.Focus()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This button event handler determines the cost of IMAX tickets choice and display the total cost
        Dim intTicketNumber As Integer
        Dim blnNumberOfTicketIsValid As Boolean = False
        Dim blnImaxIsSelected As Boolean = False
        Dim intImaxChoice As Integer
        Dim intTicketChoice As Integer
        Dim strSelectedTicket As String = ""
        Dim decTotalCost As Decimal

        ' Call a function to ensure the number of ticket is valid 
        blnNumberOfTicketIsValid = ValidateNumberOfTicket()
        ' call a function to ensure a Imax was selected
        intImaxChoice = ValidateImaxSelection(blnImaxIsSelected, strSelectedTicket)
        If (blnNumberOfTicketIsValid And blnImaxIsSelected) Then
            intTicketNumber = Convert.ToInt32(txtTickets.Text)
            intTicketChoice = cboTicketChoice.SelectedIndex
            Select Case intTicketChoice
                Case 0
                    decTotalCost = MatineeImaxCost(intImaxChoice, intTicketNumber)
                Case 1
                    decTotalCost = EveningImaxCost(intImaxChoice, intTicketNumber)
            End Select
            ' Display the cost
            lblTotal.Text = "Cost: " & decTotalCost.ToString("C") & " for the tickets"
        End If
    End Sub

    Private Function ValidateNumberOfTicket() As Boolean
        ' This procedure validates the value entered for the text Ticket box
        Dim intTicketNumber As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfTicketMessage As String = "Please enter the number of tickets for Imax Theatre"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTicketNumber = Convert.ToInt32(txtTickets.Text)
            If intTicketNumber >= 0 And intTicketNumber <= 10 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfTicketMessage, , strMessageBoxTitle)
                txtTickets.Focus()
                txtTickets.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberOfTicketMessage, , strMessageBoxTitle)
            txtTickets.Focus()
            txtTickets.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberOfTicketMessage, , strMessageBoxTitle)
            txtTickets.Focus()
            txtTickets.Clear()
        Catch Exception As SystemException
            MsgBox(strNumberOfTicketMessage, , strMessageBoxTitle)
            txtTickets.Focus()
            txtTickets.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function ValidateImaxSelection(ByRef blnImax As Boolean, ByRef strImax As String) As Integer
        ' This function ensures the user selected a Imax type
        Dim intImaxType As Integer
        Try
            intImaxType = Convert.ToInt32(cboTicketChoice.SelectedIndex)
            strImax = cboTicketChoice.SelectedItem.ToString()
            blnImax = True
        Catch Exception As SystemException
            ' Determine if the Imax type is selected
            MsgBox("Select a Imax type", , "Error")
            blnImax = False
        End Try
        Return intImaxType
    End Function
    Private Function MatineeImaxCost(ByVal intImax As Integer, ByVal intNumber As Integer) As Decimal
        ' This function calculates the cost for Imax matinee
        Dim decTicketCost As Decimal
        Dim decFinalCost As Decimal
        Dim decMatineeImax As Decimal = 16D

        Select Case intImax
            Case 0
                decTicketCost = decMatineeImax
        End Select
        decFinalCost = decTicketCost * intNumber
        Return decFinalCost
    End Function
    Private Function EveningImaxCost(ByVal intImax As Integer, ByVal intNumber As Integer) As Decimal
        ' This function calculates the cost for Imax evening
        Dim decTicketCost As Decimal
        Dim decFinalCost As Decimal
        Dim decEveningImax As Decimal = 27D

        Select Case intImax
            Case 1
                decTicketCost = decEveningImax
        End Select
        decFinalCost = decTicketCost * intNumber
        Return decFinalCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the form for reuse when user clicks the clear button
        cboTicketChoice.Text = "Select Tickets"
        txtTickets.Clear()
        lblTotal.Text = ""
        lblTickets.Visible = False
        txtTickets.Visible = False
        btnClear.Visible = False
        lblTotal.Visible = False
    End Sub

    Private Sub frmIMAX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splash screen for 4 seconds
        Threading.Thread.Sleep(2000)
    End Sub
End Class
