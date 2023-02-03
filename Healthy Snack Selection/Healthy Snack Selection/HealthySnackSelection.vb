Public Class HealthySnackSelection
    Private Sub btnBeanBuritto_Click(sender As Object, e As EventArgs) Handles btnBeanBurrito.Click
        ' This code executed when the user click the bean buritto. It display the bean burrito picture
        ' and enable the button select
        picSnackImage.Image = My.Resources.Bean_Buritto
        btnSelect.Enabled = True
    End Sub

    Private Sub btnFalafel_Click(sender As Object, e As EventArgs) Handles btnFalafel.Click
        ' This code executed when the user click the falafel button. Its display the falafel picture
        ' and enable the button select
        picSnackImage.Image = My.Resources.fafafel
        btnSelect.Enabled = True
    End Sub

    Private Sub btnGreekYogurt_Click(sender As Object, e As EventArgs) Handles btnGreekYogurt.Click
        ' This code executed when the user click the greek yogurt button. Its display the greek yogurt 
        ' picture and enable the button select
        picSnackImage.Image = My.Resources.greek_yogurt
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSpringRolls_Click(sender As Object, e As EventArgs) Handles btnSpringRolls.Click
        ' This code executed when the user click the spring rolls button. Its display the spring rolls
        ' picture and enable the button select
        picSnackImage.Image = My.Resources.spring_rolls
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code executed when the user click the select button. Its display the conformation message
        ' and enable the Exit window button
        lblConformation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code executed when the user click the exit window button. Its close and terminate
        ' the program and it execution
        Me.Close()
    End Sub
End Class
