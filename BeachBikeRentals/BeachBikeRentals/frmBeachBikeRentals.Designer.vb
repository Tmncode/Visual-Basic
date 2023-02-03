<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeachBikeRentals
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumOfRental = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblDisplayCost = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picBikes = New System.Windows.Forms.PictureBox()
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(261, 45)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(502, 61)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Beach Bike Rentals"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(375, 130)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(275, 46)
        Me.lblCostHeading.TabIndex = 1
        Me.lblCostHeading.Text = "$9.95 per day"
        '
        'lblNumOfRental
        '
        Me.lblNumOfRental.AutoSize = True
        Me.lblNumOfRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfRental.Location = New System.Drawing.Point(76, 219)
        Me.lblNumOfRental.Name = "lblNumOfRental"
        Me.lblNumOfRental.Size = New System.Drawing.Size(451, 46)
        Me.lblNumOfRental.TabIndex = 2
        Me.lblNumOfRental.Text = "Number of rental Days:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(76, 310)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(500, 46)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total Cost of Bike Rental:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(666, 212)
        Me.txtNumberOfDays.Multiline = True
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(100, 53)
        Me.txtNumberOfDays.TabIndex = 4
        Me.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDisplayCost
        '
        Me.lblDisplayCost.AutoSize = True
        Me.lblDisplayCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayCost.Location = New System.Drawing.Point(657, 306)
        Me.lblDisplayCost.Name = "lblDisplayCost"
        Me.lblDisplayCost.Size = New System.Drawing.Size(0, 49)
        Me.lblDisplayCost.TabIndex = 5
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAccept.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(99, 385)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(208, 74)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "Find Cost"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(405, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(208, 74)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(711, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(208, 74)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picBikes
        '
        Me.picBikes.Image = Global.BeachBikeRentals.My.Resources.Resources.bike
        Me.picBikes.Location = New System.Drawing.Point(52, 479)
        Me.picBikes.Name = "picBikes"
        Me.picBikes.Size = New System.Drawing.Size(921, 340)
        Me.picBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBikes.TabIndex = 9
        Me.picBikes.TabStop = False
        '
        'frmBeachBikeRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 873)
        Me.Controls.Add(Me.picBikes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblDisplayCost)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblNumOfRental)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "frmBeachBikeRentals"
        Me.Text = "Bike Rentals"
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumOfRental As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblDisplayCost As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picBikes As PictureBox
End Class
