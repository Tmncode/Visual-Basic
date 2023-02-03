' Program Name: Most Popular Games Sold
' Author:       Tam M. Nguyen
' Date:         October 4th, 2019
' Purpose:      

Option Strict On

Public Class frmPopularGames

    Public Shared intSize As Integer = 9
    Public Shared strGames(intSize) As String
    Public Shared intDownloads(intSize) As Integer

    Private Sub frmPopularGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objReader As IO.StreamReader
        Dim strPath As String = "H:\Visual Basic 2017\VB17-Chapter.08\mobile.txt"
        Dim strFileError As String = "The file is not available. Restart when the file is available"
        Dim intCount As Integer = 0
        Dim intFill As Integer

        If IO.File.Exists(strPath) Then
            objReader = IO.File.OpenText(strPath)
            Do While objReader.Peek <> -1
                strGames(intCount) = objReader.ReadLine()
                intDownloads(intCount) = Integer.Parse(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (strGames.Length - 1)
                lstGames.Items.Add(strGames(intFill))
                cboSelect.Items.Add(strGames(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        lblGameDownload.Text = "$GAME " & "has " & vbNewLine & "$DOWNLOADS downloads total"
        If cboSelect.SelectedIndex <> -1 Then
            lblGameDownload.Text = lblGameDownload.Text.Replace("$GAME", strGames(cboSelect.SelectedIndex)).Replace("$DOWNLOADS", intDownloads(cboSelect.SelectedIndex).ToString())
        End If
        lblGameDownload.Visible = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblGameDownload.Text = ""
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmSecond As New frmTotalDownLoad

        Hide()
        frmSecond.ShowDialog()
    End Sub
End Class
