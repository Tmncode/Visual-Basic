Option Strict On

Public Class frmTotalDownLoad
    Dim strGames() As String = {}
    Private Sub frmTotalDownLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim totalDownloads As Integer

        lblTotalDownLoad.Text = "The total downloads of all 10 apps is:" & vbNewLine & "$TOTAL downloads"

        For Each strGame In frmPopularGames.strGames
            Dim arrayIndex As Integer = Array.IndexOf(frmPopularGames.strGames, strGame)
            totalDownloads += frmPopularGames.intDownloads(arrayIndex)
            strGames = strGames.Concat({String.Format("{0}: {1}", strGame, frmPopularGames.intDownloads(arrayIndex).ToString())}).ToArray()
        Next
        For Each strGame In strGames.OrderBy(Function(x) x).ToArray
            lstGames.Items.Add(strGame)
        Next
        lblTotalDownLoad.Text = lblTotalDownLoad.Text.Replace("$TOTAL", totalDownloads.ToString())
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Dim frmFirst As New frmPopularGames

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class