<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.lstInventoryId = New System.Windows.Forms.ListBox()
        Me.lblFoodTruck = New System.Windows.Forms.Label()
        Me.grpDepreicationType = New System.Windows.Forms.GroupBox()
        Me.radDoubleDeclining = New System.Windows.Forms.RadioButton()
        Me.radStraightLine = New System.Windows.Forms.RadioButton()
        Me.btnCalculateDepreciation = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.lstPresentValue = New System.Windows.Forms.ListBox()
        Me.lstYearDepreciation = New System.Windows.Forms.ListBox()
        Me.lstTotalDepreciation = New System.Windows.Forms.ListBox()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.lblYearDepreciation = New System.Windows.Forms.Label()
        Me.lblTotalDepreciation = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.picTruck = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDepreicationType.SuspendLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(165, 22)
        Me.mnuDisplay.Text = "&Display Inventory"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(165, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(165, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectItem.ForeColor = System.Drawing.Color.Gray
        Me.lblSelectItem.Location = New System.Drawing.Point(231, 96)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(156, 16)
        Me.lblSelectItem.TabIndex = 2
        Me.lblSelectItem.Text = "Select Inventory Item:"
        '
        'lstInventoryId
        '
        Me.lstInventoryId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstInventoryId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInventoryId.ForeColor = System.Drawing.Color.Gray
        Me.lstInventoryId.FormattingEnabled = True
        Me.lstInventoryId.ItemHeight = 16
        Me.lstInventoryId.Location = New System.Drawing.Point(234, 116)
        Me.lstInventoryId.Name = "lstInventoryId"
        Me.lstInventoryId.Size = New System.Drawing.Size(153, 84)
        Me.lstInventoryId.TabIndex = 3
        '
        'lblFoodTruck
        '
        Me.lblFoodTruck.AutoSize = True
        Me.lblFoodTruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodTruck.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblFoodTruck.Location = New System.Drawing.Point(228, 41)
        Me.lblFoodTruck.Name = "lblFoodTruck"
        Me.lblFoodTruck.Size = New System.Drawing.Size(444, 33)
        Me.lblFoodTruck.TabIndex = 4
        Me.lblFoodTruck.Text = "Chef Shack Burger Food Truck"
        '
        'grpDepreicationType
        '
        Me.grpDepreicationType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpDepreicationType.Controls.Add(Me.radDoubleDeclining)
        Me.grpDepreicationType.Controls.Add(Me.radStraightLine)
        Me.grpDepreicationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepreicationType.ForeColor = System.Drawing.Color.Gray
        Me.grpDepreicationType.Location = New System.Drawing.Point(453, 96)
        Me.grpDepreicationType.Name = "grpDepreicationType"
        Me.grpDepreicationType.Size = New System.Drawing.Size(219, 104)
        Me.grpDepreicationType.TabIndex = 5
        Me.grpDepreicationType.TabStop = False
        Me.grpDepreicationType.Text = "Select Depreciation Method:"
        '
        'radDoubleDeclining
        '
        Me.radDoubleDeclining.AutoSize = True
        Me.radDoubleDeclining.Location = New System.Drawing.Point(6, 63)
        Me.radDoubleDeclining.Name = "radDoubleDeclining"
        Me.radDoubleDeclining.Size = New System.Drawing.Size(207, 20)
        Me.radDoubleDeclining.TabIndex = 1
        Me.radDoubleDeclining.TabStop = True
        Me.radDoubleDeclining.Text = "Double-Declining Balance"
        Me.radDoubleDeclining.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Checked = True
        Me.radStraightLine.Location = New System.Drawing.Point(6, 37)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(113, 20)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-Line"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'btnCalculateDepreciation
        '
        Me.btnCalculateDepreciation.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCalculateDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateDepreciation.ForeColor = System.Drawing.Color.White
        Me.btnCalculateDepreciation.Location = New System.Drawing.Point(322, 215)
        Me.btnCalculateDepreciation.Name = "btnCalculateDepreciation"
        Me.btnCalculateDepreciation.Size = New System.Drawing.Size(214, 33)
        Me.btnCalculateDepreciation.TabIndex = 6
        Me.btnCalculateDepreciation.Text = "Calculate Depreciation"
        Me.btnCalculateDepreciation.UseVisualStyleBackColor = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Gray
        Me.lblYear.Location = New System.Drawing.Point(73, 311)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(65, 32)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Present " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year"
        Me.lblYear.Visible = False
        '
        'lstYear
        '
        Me.lstYear.ForeColor = System.Drawing.Color.Gray
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.Location = New System.Drawing.Point(76, 346)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(88, 69)
        Me.lstYear.TabIndex = 8
        Me.lstYear.Visible = False
        '
        'lstPresentValue
        '
        Me.lstPresentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lstPresentValue.FormattingEnabled = True
        Me.lstPresentValue.Location = New System.Drawing.Point(223, 346)
        Me.lstPresentValue.Name = "lstPresentValue"
        Me.lstPresentValue.Size = New System.Drawing.Size(88, 69)
        Me.lstPresentValue.TabIndex = 9
        Me.lstPresentValue.Visible = False
        '
        'lstYearDepreciation
        '
        Me.lstYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstYearDepreciation.FormattingEnabled = True
        Me.lstYearDepreciation.Location = New System.Drawing.Point(370, 346)
        Me.lstYearDepreciation.Name = "lstYearDepreciation"
        Me.lstYearDepreciation.Size = New System.Drawing.Size(88, 69)
        Me.lstYearDepreciation.TabIndex = 10
        Me.lstYearDepreciation.Visible = False
        '
        'lstTotalDepreciation
        '
        Me.lstTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstTotalDepreciation.FormattingEnabled = True
        Me.lstTotalDepreciation.Location = New System.Drawing.Point(517, 346)
        Me.lstTotalDepreciation.Name = "lstTotalDepreciation"
        Me.lstTotalDepreciation.Size = New System.Drawing.Size(88, 69)
        Me.lstTotalDepreciation.TabIndex = 11
        Me.lstTotalDepreciation.Visible = False
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lblPresentValue.Location = New System.Drawing.Point(220, 311)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(61, 32)
        Me.lblPresentValue.TabIndex = 12
        Me.lblPresentValue.Text = "Present" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPresentValue.Visible = False
        '
        'lblYearDepreciation
        '
        Me.lblYearDepreciation.AutoSize = True
        Me.lblYearDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblYearDepreciation.Location = New System.Drawing.Point(367, 313)
        Me.lblYearDepreciation.Name = "lblYearDepreciation"
        Me.lblYearDepreciation.Size = New System.Drawing.Size(97, 32)
        Me.lblYearDepreciation.TabIndex = 13
        Me.lblYearDepreciation.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblYearDepreciation.Visible = False
        '
        'lblTotalDepreciation
        '
        Me.lblTotalDepreciation.AutoSize = True
        Me.lblTotalDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalDepreciation.Location = New System.Drawing.Point(514, 313)
        Me.lblTotalDepreciation.Name = "lblTotalDepreciation"
        Me.lblTotalDepreciation.Size = New System.Drawing.Size(97, 32)
        Me.lblTotalDepreciation.TabIndex = 14
        Me.lblTotalDepreciation.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblTotalDepreciation.Visible = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.Color.Gray
        Me.lblItem.Location = New System.Drawing.Point(294, 257)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(278, 16)
        Me.lblItem.TabIndex = 15
        Me.lblItem.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblItem.Visible = False
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Gray
        Me.lblQuantity.Location = New System.Drawing.Point(385, 277)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(89, 16)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "XXXXXXXXX"
        Me.lblQuantity.Visible = False
        '
        'picTruck
        '
        Me.picTruck.Image = Global.Depreciation.My.Resources.Resources.Truck
        Me.picTruck.Location = New System.Drawing.Point(0, 28)
        Me.picTruck.Name = "picTruck"
        Me.picTruck.Size = New System.Drawing.Size(206, 245)
        Me.picTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTruck.TabIndex = 1
        Me.picTruck.TabStop = False
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblTotalDepreciation)
        Me.Controls.Add(Me.lblYearDepreciation)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lstTotalDepreciation)
        Me.Controls.Add(Me.lstYearDepreciation)
        Me.Controls.Add(Me.lstPresentValue)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.btnCalculateDepreciation)
        Me.Controls.Add(Me.grpDepreicationType)
        Me.Controls.Add(Me.lblFoodTruck)
        Me.Controls.Add(Me.lstInventoryId)
        Me.Controls.Add(Me.lblSelectItem)
        Me.Controls.Add(Me.picTruck)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmDepreciation"
        Me.Text = "Compute Depreciation by Method"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDepreicationType.ResumeLayout(False)
        Me.grpDepreicationType.PerformLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lblSelectItem As Label
    Friend WithEvents lstInventoryId As ListBox
    Friend WithEvents lblFoodTruck As Label
    Friend WithEvents grpDepreicationType As GroupBox
    Friend WithEvents radDoubleDeclining As RadioButton
    Friend WithEvents radStraightLine As RadioButton
    Friend WithEvents btnCalculateDepreciation As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents lstYear As ListBox
    Friend WithEvents lstPresentValue As ListBox
    Friend WithEvents lstYearDepreciation As ListBox
    Friend WithEvents lstTotalDepreciation As ListBox
    Friend WithEvents lblPresentValue As Label
    Friend WithEvents lblYearDepreciation As Label
    Friend WithEvents lblTotalDepreciation As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblQuantity As Label
End Class
