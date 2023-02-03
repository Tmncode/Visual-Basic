'Program Name: Rainfall Average
'Author:       Tam M. Nguyen
'Date:         June 5, 2020
'Purpose:      The Rainfall program enter the average rainfall.
'              After all rainfall values have been entered. It displays
'              the average Rainfall for the month.

Option Strict On
Public Class frmRainFall
    Private Sub btnEnterAverage_Click(sender As Object, e As EventArgs) Handles btnEnterAverage.Click
        'This event handler accept and displays up to 12 rainfall values
        'and then calculates and displays the average rainfall for the month.

        'Declare and initialize variables
        Dim strRainFall As String
        Dim decRainFall As Decimal
        Dim decAverage As Decimal
        Dim decTotalAverage As Decimal = 0D
        Dim strInputMessage As String = "Enter RainFall for number #"
        Dim strInputHeading As String = "Rainfall Average"
        Dim strNormalMessage As String = "Enter Rainfall for number #"
        Dim strNonNumericError As String = "Error - Enter a number for Rainfall number #"
        Dim strNegativeError As String = "Error - Enter a positive number for Rainfall number #"

        'Delcare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries = 12
        Dim intNumberOfEntries = 1

        'This loop allows the user to enter the Rainfall number up to 12.
        'The loop terminates when the user has enter 12 Rainfall values or the user
        'clicks the Cancel Button or the Close Button on the InputBox.
        strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainFall = strCancelClicked
            If IsNumeric(strRainFall) Then
                decRainFall = Convert.ToDecimal(strRainFall)
                Select Case decRainFall
                    Case Is > 0
                        lstRainFallAverage.Items.Add(decRainFall)
                        decTotalAverage += decRainFall
                        intNumberOfEntries += 1
                        strInputMessage = strNormalMessage
                    Case Else
                        strInputMessage = strNegativeError
                End Select
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
            Select Case intNumberOfEntries
                Case Is > 1
                    lblAverageRainfall.Visible = True
                    decAverage = decTotalAverage / (intNumberOfEntries - 1)
                    lblAverageRainfall.Text = "Average Rainfall per Month is " & decAverage.ToString("F1") & " inches"
                Case Else
                    MsgBox("No Rainfall values entered")
            End Select

            'Disable the enter Rainfall button
            btnEnterAverage.Enabled = False
        Loop

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'This event handler clears the listbox object and hides
        'the average Rainfall label.It also enable the Enter Rainfall button

        lstRainFallAverage.Items.Clear()
        lblAverageRainfall.Visible = False
        btnEnterAverage.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This event handler Closes the window and Exits the program.

        Close()
    End Sub
End Class
