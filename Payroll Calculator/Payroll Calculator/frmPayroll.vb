' Program: Payroll Calculator
' Author:  Tam M. Nguyen
' Date:    May 21, 2020
' Purpose: This Window Classic Desktop application will compute and display the FICA tax,Federal tax
'          and state tax for a two-week pay period.

Option Strict On

Public Class frmPayroll

    Const _cdblFICAtax As Double = 7.65D
    Const _cdblFederalTax As Double = 0.22D
    Const _cdblStateTax As Double = 0.04D

    Private Sub btnTotalIncome_Click(sender As Object, e As EventArgs) Handles btnTotalIncome.Click
        'This event handler execute when the user click the get total button
        'It calculates and display Bi-Weekly pay and substract FICA tax, Federal tax, State tax then display 
        'your Net Total.

        Dim strGrossPay As String
        Dim intGrossPay As Integer 'Hold gross pay.
        Dim intNetPay As Double  'Hold net pay
        Dim intNetPay2 As Double
        Dim intNetPay3 As Double
        Dim intNetPay4 As Double

        strGrossPay = txtGrossPay.Text
        intGrossPay = Convert.ToInt32(strGrossPay)



        intNetPay2 = _cdblFICAtax
        intNetPay3 = _cdblFederalTax
        intNetPay4 = _cdblStateTax
        intNetPay = intGrossPay - (_cdblFICAtax + _cdblFederalTax + _cdblStateTax)
        lblFICAdeduction.Text = intNetPay2.ToString("C")
        lblFederalDeduction.Text = intNetPay3.ToString("C")
        lblStateDeduction.Text = intNetPay4.ToString("C")
        lblNetPay.Text = intNetPay.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler execute when the user click the Exit button 
        'It close the window and terminate the application

        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler execute when the user click the
        'Clear button. It will clear the BiWeekly text box
        'and the text property of the NetPay label.
        'Then, it sets the focus on the txtBiWeekly text box object.

        txtGrossPay.Clear()
        lblFICAdeduction.Text = ""
        lblFederalDeduction.Text = ""
        lblStateDeduction.Text = ""
        lblNetPay.Text = ""
        txtGrossPay.Focus()
    End Sub
End Class
