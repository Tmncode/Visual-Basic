'Program: Fitness Tracker
'Author:  Tam M. Mguyen
'Date"    May 25,2020
'Purpose: This classic Window Desktop Application will compute and display 
'         the user life-time workout base on and average of 2.5 hour a week.

Public Class frmFitnessTracker

    Const cdblYear As Double = 12
    Const cdblMonth As Double = 4
    Const cdblWeeky As Double = 1

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'This event handler execute when the user click the result button
        'It calculate display the user name and the number hours the user has exercised in his or her life-time

        Dim strName As String
        Dim intExerciseHour As Integer
        Dim dblTotal As Double
        Dim dblTotal2 As Double
        Dim dblTotal3 As Double

        strName = txtName.Text
        intExerciseHour = txtExerciseHour.Text
        dblTotal = intExerciseHour * cdblYear
        dblTotal2 = intExerciseHour * cdblMonth
        dblTotal3 = intExerciseHour * cdblWeeky
        'lblDisplay.Text = strName & " your total hour is " &
        '                  dblTotal.ToString("N") & " a year"
        'Base off of and average of 2.5 hour per-week,
        Select Case intExerciseHour
            Case 0.0 To 2.5
                'lblDisplay.Text = strName & " your weekly estimate hour would be " + dblTotal3.ToString("N")
                txtDisplayMessage.Text = strName & " your weekly estimate hour would be " + dblTotal3.ToString("F1") &
                    " Calulation is base off of a 2.5 hour per-week."
            Case 2.5 To 10.0
                'lblDisplay.Text = strName & " your monthly estimate hour would be " & dblTotal2.ToString("N")
                txtDisplayMessage.Text = strName & " your monthly estimate hour would be " & dblTotal2.ToString("F1") &
                    " Calulation is base off of a 2.5 hour per-week."
            Case 2.5 To 120.0
                'lblDisplay.Text = strName & " your yearly estimate hour would be " & dblTotal.ToString("N")
                txtDisplayMessage.Text = strName & " your yearly estimate hour would be " & dblTotal.ToString("F1") &
                    " Calulation is base off of a 2.5 hour per-week."
        End Select


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'This event handler execute when the user click the Clear button.
        'It Clear the Name text box, maskedBirthDate text box, maskedCurrentDate text box, txtDisplayMessage
        'and ExerciseHour text box and the text property of the Display label.
        'Then set the focus on the name text box, birthdate text box, currentdate text box
        'and exercisehour text box object.

        txtDisplayMessage.Clear()
        txtName.Clear()
        txtExerciseHour.Clear()
        maskedBirthDate.Clear()
        maskedCurrentDate.Clear()
        'lblDisplay.Text = ""
        txtDisplayMessage.Focus()
        txtName.Focus()
        txtExerciseHour.Focus()
        maskedBirthDate.Focus()
        maskedCurrentDate.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler execute when the user click the Exit button 
        'It close and terimate the program.

        Close()
    End Sub
End Class
