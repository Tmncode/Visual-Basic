'Program Name: Fitness Challenge
'Author:       Tam M. Nguyen
'Date:         June 3, 2020
'Purpose:      The Fitness Challenge program enters the weight loss
'              loss from team members for a fitness challenge. It displays each 
'              weight loss value. After all weight loss have been entered,
'              it displays the average the weight loss for the team.

Option Strict On
Public Class frmFitness
    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        'This event handler executed when the user click the btnWeightLoss it accept up to 8 weight loss
        'value, and then calculates and displays the average weight loss for the team.

        ' Declare and initialize variables
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter weight loss for team member #"
        Dim strInputHeading As String = "Weight loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter the weight loss for team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop allow the user to enter the weight loss of up to 8 team members.
        'The loop terminates when the user enter 8 weight loss values or the user
        'click the Cancal Button or click the Close Button in the Inputbox.
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or
            strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    IstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        'Calculate and displays average team weight loss 
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " &
                decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        'Disables the Weight Loss button
        btnWeightLoss.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'This event handler execute when the user click the Clear button, it clear the list box
        'and hides the average weight loss label. It also enable the weight loss button

        IstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This event handler execute when the user click the exit button it terminate
        'and close the program

        Close()
    End Sub
End Class
