' Program Name: Latte Selection
' Developer Name: Tam M. Nguyen
' Date: 4/22/2020
' Purpose: This application display latte flavor (pumpkin spice
'          and mocha). The user can select a latte flavor.

Public Class frmLatteSelection
    Private Sub btnPunpkin_Click(sender As Object, e As EventArgs) Handles btnPunpkin.Click

        'This code is executed when the user click the Pumpkin spice button. Its display the Pumpkin spice picture
        'hide the Mocha picture, and enables the selected latte button.

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True 'Enable button

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'This code is executed when the user click the exit window button.
        'It close the window and terminates the program execution.

        Me.Close()

    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click

        'This code is executed when the user click the Mocha button. It display the Mocha picture
        'hide the Pumpkin spice picture, and enables the selected latte button.

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True 'Enable button

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        'This code is executed when the user click the selected latte button. It Disable (Pumpkin, Mocha, 
        'and select Latte button) hide the instruction message, enable the Exit button, enable confirmation
        'message.

        btnPunpkin.Enabled = False
        btnMocha.Enabled = False
        btnSelect.Enabled = False
        lblInstructionMessage.Visible = False
        lblConfirmationMesssge.Visible = True
        btnExit.Enabled = True

    End Sub

End Class
