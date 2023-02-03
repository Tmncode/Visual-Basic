Public Class AirLinesGrowth
    Private Sub Calculate()
        Dim Year As Integer
        Dim YearChoice As Integer
        Dim NumberInYearIsValid As Boolean = False
        Dim Result As Double
        Dim Passenger As Long = 3800000000
        Dim Average As Decimal = 0.069

        NumberInYearIsValid = ValidateNumberInYear()

        If NumberInYearIsValid Then
            Year = Convert.ToInt32(txtYear.Text)
            YearChoice = txtYear.Text

            For Year = 2017 To 2027
                Passenger += (Passenger * 1.069)
                lstGrowthPerYear.Items.Add("Year " & Year & " Passenger " & Passenger.ToString("N"))
                If Year = txtYear.Text Then
                    txtFinalAnswer.Text = "In " & Year & " There are " & Passenger.ToString("N") & " people flying the commercial airlines"
                End If
            Next
        End If
    End Sub
    Private Function ValidateNumberInYear() As Boolean
        Dim Year As Integer
        Dim ValidityCheck As Boolean = False
        Dim NumberInYear As String = "Incorrect"
        Dim MessageTitle As String = "Input Error"

        Try
            Year = Convert.ToInt32(txtYear.Text)
            If Year >= 2017 And Year <= 2027 Then
                ValidityCheck = True
            Else
                MsgBox(NumberInYear, , MessageTitle)
                txtYear.Focus()
                txtYear.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(NumberInYear, , MessageTitle)
            txtYear.Focus()
            txtYear.Clear()
        Catch Exception As OverflowException
            MsgBox(NumberInYear, , MessageTitle)
            txtYear.Focus()
            txtYear.Clear()
        Catch Exception As SystemException
            MsgBox(NumberInYear, , MessageTitle)
            txtYear.Focus()
            txtYear.Clear()
        End Try
        Return ValidityCheck
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Calculate()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstGrowthPerYear.Items.Clear()
        txtFinalAnswer.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub AirLinesGrowth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        txtYear.Focus()
    End Sub
End Class
