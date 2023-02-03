Public Class frmDisplay

    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged

        lstSongs2.Items.Clear()
        If cboSort.SelectedIndex = 0 Then
            For Each strSongItem In frmDanceBand._strSongName
                If frmDanceBand._strGenre(Array.IndexOf(frmDanceBand._strSongName, strSongItem)) = frmDanceBand.cboGenre.Items.Item(frmDanceBand.cboGenre.SelectedIndex).ToString() Then
                    lstSongs2.Items.Add(String.Format("{0} - {1}", strSongItem, frmDanceBand._dblSongLength(Array.IndexOf(frmDanceBand._strSongName, strSongItem))))
                End If
            Next
        ElseIf cboSort.SelectedIndex = 1 Then
            Dim sortedSong() As String = {}
            For Each strSongItem In frmDanceBand._strSongName
                If frmDanceBand._strGenre(Array.IndexOf(frmDanceBand._strSongName, strSongItem)) = frmDanceBand.cboGenre.Items.Item(frmDanceBand.cboGenre.SelectedIndex).ToString() Then
                    sortedSong = sortedSong.Concat({String.Format("{0} - {1}", strSongItem, frmDanceBand._dblSongLength(Array.IndexOf(frmDanceBand._strSongName, strSongItem)))}).ToArray()
                End If
            Next
            Array.Sort(sortedSong)
            For Each strSongItem In sortedSong
                lstSongs2.Items.Add(strSongItem)
            Next
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmFirst As New frmDanceBand

        Hide()
        frmFirst.ShowDialog()
    End Sub

End Class