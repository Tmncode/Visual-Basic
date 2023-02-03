' Program Name: Smart Home Electric Savings
' Author:       Tam M. Nguyen
' Date:         August 9, 2020
' Purpose:      This Windows application opens a text file that lists the monthly savings of a smart home's electric bill in comparison to a previous year
'               without smart device activation. A smart thermostat, lighting system, and water heater were installed one year ago and the text file lists
'               the savings each month. The The user selects a month read from the text file and displays that month's electric bill savings. A Button object
'               displays the average monthly savings with the smart home devices and the month with the most significant savings.

Option Strict On

Public Class ElectricApplication
    ' Class Level Private variables
    Private _intMonthsOfSmartSavings As Integer
    Public Shared _intSizeOfArray As Integer = 11
    Public Shared _strMonthListItem(_intSizeOfArray) As String
    Public Shared _avgCost As Decimal
    Public Shared _ttlOfCosts As Decimal
    Public Shared _mostSavingsPosition As Integer
    Public Shared _highSavingsAmount As Decimal = 0.00D

    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private Sub ElectricApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmSavings load event reads the savings text file and fills the label objects with the savings.

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "H:\Visual Basic 2017\VB17-Chapter.08\savings.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        ' Verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) = True Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                _strMonthListItem(intCount) = objReader.ReadLine()
                _decInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                _ttlOfCosts += _decInitialPrice(intCount)
                If _decInitialPrice(intCount) > _highSavingsAmount Then
                    _highSavingsAmount = _decInitialPrice(intCount)
                    _mostSavingsPosition = intCount
                End If
                intCount += 1
            Loop
            objReader.Close()

            ' Display the array of Months in the textbox
            For intFill = 0 To (_strMonthListItem.Length - 1)
                cboSelectedMonth.Items.Add(_strMonthListItem(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub btnDisplayStatistics_Click(sender As Object, e As EventArgs) Handles btnDisplayStatistics.Click
        ' The btnDisplayStatistics click event calls the savings Sub procedures
        ' Declare variables
        Dim intSelectedMonth As Integer
        Dim decPresentMonthValue As Decimal = 0
        Dim decAverage As Decimal
        Dim strMonthSavings As String = "The electric savings for "
        Dim strAverageMonthlySaving As String = "The average monthly savings: "
        Dim strMonthOfSignificantSavings As String = " had the most significant monthly savings"
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectedMonthError As String = "Select a Month to Continue"

        lblDisplayMonthSavings.Visible = True
        lblDisplayAverageMonthlySavings.Visible = True
        lblDisplayMonthMostSignificantSavings.Visible = True

        ' If the Months Combo Box is selected, then display the statistics
        If cboSelectedMonth.SelectedIndex >= 0 Then
            btnDisplayStatistics.Visible = True
            intSelectedMonth = cboSelectedMonth.SelectedIndex
            decPresentMonthValue = _decInitialPrice(intSelectedMonth)
            decAverage = _ttlOfCosts / 12
            lblDisplayMonthSavings.Text = strMonthSavings & _strMonthListItem(intSelectedMonth) & " " & decPresentMonthValue.ToString("C")
            lblDisplayAverageMonthlySavings.Text = strAverageMonthlySaving & decAverage.ToString("C")
            lblDisplayMonthMostSignificantSavings.Text = _strMonthListItem(_mostSavingsPosition) & " " & strMonthOfSignificantSavings
        Else
            MsgBox(strSelectedMonthError, , strMissingSelection)
        End If
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears and resets the form
        lblDisplayMonthSavings.Text = ""
        lblDisplayAverageMonthlySavings.Text = ""
        lblDisplayMonthMostSignificantSavings.Text = ""
        lblDisplayMonthSavings.Visible = False
        lblDisplayAverageMonthlySavings.Visible = False
        lblDisplayMonthMostSignificantSavings.Visible = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the application
        Application.Exit()
    End Sub

End Class
