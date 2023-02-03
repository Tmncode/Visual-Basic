'Program Name: Comic Convention
'Author:       Tam M. Nguyen
'Date:         May 27,2020
'Purpose:      This Classic Window App computes the registration cost of attending 
'              a Comic Convention

Option Strict On

Public Class frmComicConvention
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This event handler calculate the cost per-person and the type of convention

        'Creating variable
        Dim decGroupSize As Decimal 'Hold the text value 
        Dim decGroupCost As Decimal 'Hold the cost per-person and convention type
        Dim decTotalCost As Decimal 'Is assigned and calculated the final cost
        Dim decSuperHero As Decimal = 380
        Dim decAutoGraph As Decimal = 275
        Dim decConvention As Decimal = 209

        'Check if the user enter a numeric value
        If IsNumeric(txtGroupSize.Text) Then
            decGroupSize = Convert.ToDecimal(txtGroupSize.Text)
            'Check if txtGroupSize is greater then zero
            If decGroupSize > 0 Then
                'Determine cost per-ticket
                If radSuperHero.Checked Then
                    decGroupCost = decSuperHero
                ElseIf radAutoGraphs.Checked Then
                    decGroupCost = decAutoGraph
                ElseIf radConvention.Checked Then
                    decGroupCost = decConvention
                End If
                ' Calculate and display cost
                decTotalCost = decGroupSize * decGroupCost
                lblRegistrationCost.Text = " Registration Cost: " & decTotalCost.ToString("C")
            Else
                ' Display error message if user enter a negative value
                MsgBox("You entered " & decGroupSize.ToString() & ". Must be a postive number ", , "Input Error")
                txtGroupSize.Text = ""
                txtGroupSize.Focus()
            End If
            'Check if group sie is greater then 20
            If decGroupSize > 20 Then
                MsgBox("You entered " & decGroupSize.ToString() & ". You have exceeded the number of tickets", , "Input Error")
            End If

        Else
            ' Display error message if the user enterd a nonnumeric(Letter) value
            MsgBox("Enter a number", , "Input Error")
            txtGroupSize.Text = ""
            txtGroupSize.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler executed when the user click the clear button 
        'It clear the text group size text box, and set the focus for the text box
        'and clear the Registration cost label

        txtGroupSize.Clear()
        lblRegistrationCost.Text = ""
        radSuperHero.Checked = True
        radAutoGraphs.Checked = False
        radConvention.Checked = False
        txtGroupSize.Focus()
    End Sub

    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler executed when the form loaded at the start of the program.
        'It set the focus to the GroupSize text box and clear the registration cost label

        lblRegistrationCost.Text = ""
        txtGroupSize.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler executed when the user click the Exit button
        'It close and terminate the program
        Close()
    End Sub
End Class
