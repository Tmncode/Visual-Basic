' Program Name: Dance band
' Author:       Tam M. Nguyen
' Date:         September 15,2020
' Purpose:      This Window Application open txt File that contains song names ordered by popularity,
'               their music genre, and the song length in minutes. The application allows a user to select
'               a genre of music and a list if songs and their length can be displayed. The application also
'               allows you to view all songs that the dance band can play in order of popularity or alphabetical order.

Option Strict On

Public Class frmDanceBand
    ' global declarations Class Level variables
    Public Shared _intSizeOfArray As Integer = 51
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Public Shared _strSongName(_intSizeOfArray) As String
    Public Shared _strGenre(_intSizeOfArray) As String
    Public Shared _dblSongLength(_intSizeOfArray) As String
    Public Shared strSongs(_intSizeOfArray) As String
    Private Sub frmDanceBand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strPathNameAndFile As String = "songs.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available"

        ' verify the file exists
        If IO.File.Exists(strPathNameAndFile) Then
            objReader = IO.File.OpenText(strPathNameAndFile)
            Do While objReader.Peek <> -1
                '_strInventoryItem(intCount) = objReader.ReadLine()
                _strSongName(intCount) = objReader.ReadLine()
                _strGenre(intCount) = objReader.ReadLine()
                _dblSongLength(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            ' The combo box is filled with the 4 genre names
            For intFill = 0 To (_strGenre.Length - 1)
                _strInventoryItem = {_strGenre(0), _strGenre(1), _strGenre(2), _strGenre(3)}
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub cboGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenre.SelectedIndexChanged

        lstSongs.Items.Clear()
        For Each strSong In _strSongName
            If _strGenre(Array.IndexOf(_strSongName, strSong)) = cboGenre.Items.Item(cboGenre.SelectedIndex).ToString() Then
                lstSongs.Items.Add(String.Format("{0} - {1}", strSong, _dblSongLength(Array.IndexOf(_strSongName, strSong))))
            End If
        Next
        lstSongs.Visible = True
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmSecond As New frmDisplay
        Hide()
        frmDisplay.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstSongs.Items.Clear()
        lstSongs.Visible = False
        cboGenre.Text = "Select Genre"
        cboGenre.SelectedIndex = -1
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
