' Program name: Virtual Reality Headset
' Developer:    Tam M. Nguyen
' Date:         4/24/2020
' purpose:      This Window Classic Desktop application displays and order screen for two types
'               of virtual reality headset. The user can choose either a Crown VR headset or Earbud VR
'               Headset.
Public Class frmVirtualRealityHeadset
    Private Sub btnCrown_Click(sender As Object, e As EventArgs) Handles btnCrown.Click
        ' This code execute when the user click the VR Crown button. Its display the VR crown picture
        ' hide the VR earbud picture and enable the Exit Window button.

        picCrown.Visible = True
        picEarbud.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnEarbud_Click(sender As Object, e As EventArgs) Handles btnEarbud.Click
        ' This code execute when the user click the VR Earbud button. Its display the VR earbud picture
        ' hide the VR crown picture and enable the Exit Window button.

        picEarbud.Visible = True
        picCrown.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code execute when the user click the Exit Window button. Its close and terinate
        ' the program and execution.

        Me.Close()
    End Sub
End Class
