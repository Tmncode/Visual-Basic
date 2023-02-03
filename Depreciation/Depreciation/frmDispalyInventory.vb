' The frmDisplayInventory class is opened by frmDepreciation
' and displays the Inventory file in sorted order.

Option Strict On

Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This frmDisplayInventory load event is the second forms that
        ' displays the sorted inventory items

        Dim strItem As String
        ' sorts the _strInventoryItem Array
        Array.Sort(frmDepreciation._strInventoryItem)

        ' Displays the _strInventoryItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' The sub procedure opens the first form
        Dim frmFirst As New frmDepreciation

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class