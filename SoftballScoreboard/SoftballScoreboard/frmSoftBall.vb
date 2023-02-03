'Program Name: Softball Scorebroad
'Author:       Tam M. Nguyen
'Date:         June 9, 2020
'Purpose:      This application calculate the scores for each inning during a softball game
'              for one team

Option Strict On
Public Class frmSoftBall
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        'The button score click event accepts and display up to 7 inning values
        'and then calculates and display the total score for one team.

        'Declare and initialize variables
        Dim strScore As String
        Dim decScore As Decimal
        Dim decEnterScore As Decimal
        Dim decTotalScore As Decimal = 0D
        'Declare and initialize variables for InputBox
        Dim strInputMessage As String = "Enter the Score for team #"
        Dim strInputHeading As String = "Total Score"
        Dim strNormalMessage As String = "Enter the score for team #"
        Dim strNonNumericError As String = "Error - Enter a number for the score of team #"
        Dim strNegativeError As String = "Error - Enter a positive number for the score of team #"
        'Declare and initialize variables for loop
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 0

        'This loop allows the user to enter the score of up to 7
        'The loop terminates when the user has entered 7 score values or the user
        'clicks the Cancel button or the Close button in the InputBox
        strScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strScore = strCancelClicked
            If IsNumeric(strScore) Then
                decScore = Convert.ToDecimal(strScore)
                If decScore >= 0 Then
                    lstInning.Items.Add(decScore)
                    decTotalScore += decScore
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculate and display score
        If intNumberOfEntries >= 0 Then
            lblTotalScore.Visible = True
            decEnterScore = decTotalScore + (intNumberOfEntries - 1)
            lblTotalScore.Text = "Total Score is " &
                decEnterScore.ToString()
        Else
            MsgBox("No score value entered")
        End If

        'Disable the enter score button
        btnScore.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The Clear event handler clears the listbox object and
        'hides the total score label. It also enable the enter score button

        lstInning.Items.Clear()
        lblTotalScore.Visible = False
        btnScore.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This event handler closes the window and exit the application
        Close()
    End Sub
End Class
