Public Class frmCampusMusicCafe
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        ' This code execute when the user click the Date button. Its display the date

        lblDate.Text = "Apirl 24, 2020"
    End Sub

    Private Sub btnMicNight_Click(sender As Object, e As EventArgs) Handles btnMicNight.Click
        ' This code execute when the user click the Mic Night button. Its display the location Mic Night

        lblMicNight.Text = "Open Mic"
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        ' This code execute when the user click the Time button. Its display the time

        lblTime.Text = "Start at 8:00 PM "
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        ' This code execute when the user click the more Detail button. Its display the 
        ' additional infomation and enable the exit window button

        lblDetail.Text = "For more infomation view the Campus Music Cafe Facebook page."
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code exit execute when the user click the exit window button. Its close and terminate the 
        ' program and execution

        Me.Close()
    End Sub

End Class
