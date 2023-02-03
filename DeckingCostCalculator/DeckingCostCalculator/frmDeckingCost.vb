'Program: Decking Cost Calculator
'Author:  Tam M. Nguyen
'Date:    May 26,2020
'Purpose: This Application calculates computes the estimates cost of decking based on
'         the number of square feet and the following cost per square foot: Lumber = $2.35 per square foot
'         RedWood = $7.75 per square foot, Composite = $8.50 per square foot.

Option Strict On

Public Class frmDeckingCost
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler execute when the user click the exit button
        'It Close and terminate the program

        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event-Handler execute when the user click the Clear button
        'It clear the square footage text box and cost estimate label

        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedWood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This event-Handler calculates the estimates cost of decking based on 
        'the square footage and the decking type.

        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedWoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        'Did the user enter a numeric number?
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            'Is the square footage greater then zero?
            If decFootage > 0 Then
                'Determine cost per square foot
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedWood.Checked Then
                    decCostPerSquareFoot = decRedWoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If
                'Calculate and display cost estimates
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = "Cost Estimate: " & decCostEstimate.ToString("C")
            Else
                'Display error message if the user enter a negative value
                MsgBox("You entered " & decFootage.ToString() & ". Enter a postive number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            'Display error message if the user enter a nonnumeric value
            MsgBox("Enter the square footage of decking",, "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()

        End If

    End Sub

    Private Sub frmDeckingCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler executed when the form is loaded at the start of
        'the program. Its set the focus to the square footage text box
        'and clear the cost estimate label.

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
