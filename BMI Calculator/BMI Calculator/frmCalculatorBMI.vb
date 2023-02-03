' Program Name: BMI Calculator
' Author:       Tam M. Nguyen
' Date:         Aug 25, 2020
' Purpose:      This BMI Calculator app allows the user to enter a height and weight and computes the user's Body mass index. The input may be in Imperial or Metric format

Option Strict On
Option Explicit On

Public Class frmCalculatorBMI
    ' delcare CONSTANTS
    Const decRange1 As Decimal = 18.5D
    Const decRange2 As Decimal = 24.9D
    Const decRange3 As Decimal = 29.9D
    Const decRange4 As Decimal = 30D
    Const decImpConstant As Decimal = 703D
    Private Sub Calculate()

        Dim decWeight, decHeight, decBMI As Decimal

        If (radMetric.Checked = True Or radImperial.Checked = True) Then  ' Check whether radiobutton are checked
            If (radMetric.Checked = True) Then ' Check whether metric button are check
                If (txtWeight.Text <> "" Or txtHeight.Text <> "") Then ' Check whether height text box and weight text box are filled
                    Try
                        decWeight = Decimal.Parse(txtWeight.Text) ' assign varible to textbox
                        decHeight = Decimal.Parse(txtHeight.Text) ' assign varible to textbox
                        If (decWeight > 0) Then ' check for positive weight value
                            If (decHeight > 0) Then ' check for positive height value
                                decBMI = (decWeight) / (decHeight * decHeight) ' logic for metric calculation
                                txtBMI.Text = decBMI.ToString("f")
                                'If (decBMI < decRange1) Then ' logic for BMI Scale
                                '    txtResult.Text = "Underweight"
                                'ElseIf (decBMI > decRange1 And decBMI < decRange2) Then
                                '    txtResult.Text = "Normal"
                                'ElseIf (decBMI > decRange2 And decBMI < decRange3) Then
                                '    txtResult.Text = "Overweight"
                                'ElseIf (decBMI > decRange3 And decBMI < decRange4) Then
                                '    txtResult.Text = "obese"
                                'End If
                            Else
                                MessageBox.Show("Height value Must be a positive number greater then 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                With txtWeight
                                    .SelectAll()
                                    .Focus()
                                End With
                            End If
                        Else
                            MessageBox.Show("Weight value Must be a positive number greater then 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            With txtHeight
                                .SelectAll()
                                .Focus()
                            End With
                        End If
                    Catch QuantityFormatException As FormatException
                        MessageBox.Show("Quantity Must be a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Catch QuantityOverFlowException As OverflowException
                        MessageBox.Show("Quantity value is out of limits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Catch AnException As Exception
                        MessageBox.Show("Error:" & AnException.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                Else
                    MessageBox.Show("Please input a positive values of weight and height. CANNOT leave it Blank", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtWeight.Focus()
                End If
            ElseIf (radImperial.Checked = True) Then  ' check whether imperial button is checked
                If (txtWeight.Text <> "" Or txtHeight.Text <> "") Then ' check whether height and weight textbox are filled
                    Try
                        decWeight = Decimal.Parse(txtWeight.Text) ' assign variable to the textbox
                        decHeight = Decimal.Parse(txtHeight.Text) ' assign variable to the textbox
                        If (decWeight > 0) Then ' check for positive weight value
                            If (decHeight > 0) Then ' check for positive height value
                                decBMI = (decWeight * decImpConstant) / (decHeight * decHeight) ' logic for imperial calculation
                                txtBMI.Text = decBMI.ToString("f")
                                'If (decBMI < decRange1) Then ' logic for BMI Scale calculation
                                '    txtResult.Text = "Underweight"
                                'ElseIf (decBMI > decRange1 And decBMI < decRange2) Then
                                '    txtResult.Text = "Normal Weight"
                                'ElseIf (decBMI > decRange2 And decBMI < decRange3) Then
                                '    txtResult.Text = "Overweight"
                                'ElseIf (decBMI > decRange3 And decBMI < decRange4) Then
                                '    txtResult.Text = "obese"
                                'End If
                            Else
                                MessageBox.Show("Height value MUST be a positive number greater then 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                With txtWeight
                                    .SelectAll()
                                    .Focus()
                                End With
                            End If
                        Else
                            MessageBox.Show("Weight value MUST be a positive number greater then 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            With txtHeight
                                .SelectAll()
                                .Focus()
                            End With
                        End If
                    Catch QuantityFormatException As FormatException
                        MessageBox.Show("Quantity MUST be a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Catch QuantityOverFlowException As OverflowException
                        MessageBox.Show("Quantity value is out of limits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Catch AnException As Exception
                        MessageBox.Show("Error:" & AnException.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                End If
            Else
                MessageBox.Show("Please enter a positive values of weight and height. CANNOT leave it blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtWeight.Focus()
            End If
        Else
            MessageBox.Show("Please choose one of the Type...!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' show message if no input enter
        End If
        BMI_Message(decBMI) ' Send decBMI results to sub BMI_Message
    End Sub

    Private Sub BMI_Message(ByVal BMI_Value As Double)
        Select Case BMI_Value
            Case 0.0 To 18.5
                txtResult.Text = "Underweight"
            Case 18.6 To 24.9
                txtResult.Text = "Normal Weight"
            Case 25.0 To 29.9
                txtResult.Text = "Overweight"
            Case Is >= 30.0
                txtResult.Text = "Obese"
            Case Else
                txtResult.Text = "Unable to Determine BMI"
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculate() ' Calling Calculate Sub for results
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all label and text box and unclicked all button
        txtWeight.Text = ""
        txtHeight.Text = ""
        lblWeightUnit.Text = ""
        lblHeightUnit.Text = ""
        txtBMI.Text = ""
        txtResult.Text = ""
        radMetric.Checked = False
        radImperial.Checked = False
        txtWeight.Enabled = False
        txtHeight.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmCalculatorBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(2000)
        radImperial.AutoCheck = True
        radMetric.AutoCheck = True
        txtHeight.Enabled = False
        txtWeight.Enabled = False
    End Sub

    Private Sub radImperial_CheckedChanged(sender As Object, e As EventArgs) Handles radImperial.CheckedChanged
        ' This event undergo when the button is checked
        lblWeightUnit.Text = "pounds"
        lblHeightUnit.Text = "inches"
        txtWeight.Enabled = True
        txtHeight.Enabled = True
    End Sub

    Private Sub radMetric_CheckedChanged(sender As Object, e As EventArgs) Handles radMetric.CheckedChanged
        ' This event undergo when the button is checked
        lblWeightUnit.Text = "kilograms"
        lblHeightUnit.Text = "meters"
        txtWeight.Enabled = True
        txtHeight.Enabled = True
    End Sub
End Class
