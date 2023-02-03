<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicket
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.lblTicketCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.lblGroup4 = New System.Windows.Forms.Label()
        Me.lblGroup3 = New System.Windows.Forms.Label()
        Me.lblGroup2 = New System.Windows.Forms.Label()
        Me.lblGroup1 = New System.Windows.Forms.Label()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.lblPrice4 = New System.Windows.Forms.Label()
        Me.lblPrice3 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.grpSize.SuspendLayout()
        Me.grpPrice.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Blue
        Me.lblHeading.Location = New System.Drawing.Point(195, 47)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(825, 61)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Broadway Ticket Group Discount"
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.ForeColor = System.Drawing.Color.Blue
        Me.lblTicket.Location = New System.Drawing.Point(302, 160)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(393, 39)
        Me.lblTicket.TabIndex = 1
        Me.lblTicket.Text = "Enter Amount of Ticket:"
        '
        'txtTicket
        '
        Me.txtTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicket.Location = New System.Drawing.Point(836, 157)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(100, 45)
        Me.txtTicket.TabIndex = 2
        Me.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTicketCost
        '
        Me.lblTicketCost.AutoSize = True
        Me.lblTicketCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCost.ForeColor = System.Drawing.Color.Blue
        Me.lblTicketCost.Location = New System.Drawing.Point(209, 575)
        Me.lblTicketCost.Name = "lblTicketCost"
        Me.lblTicketCost.Size = New System.Drawing.Size(299, 39)
        Me.lblTicketCost.TabIndex = 4
        Me.lblTicketCost.Text = "Total Ticket Cost:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Blue
        Me.btnCalculate.Location = New System.Drawing.Point(120, 671)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(211, 88)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Location = New System.Drawing.Point(504, 671)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(211, 88)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(888, 671)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(211, 88)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.lblGroup4)
        Me.grpSize.Controls.Add(Me.lblGroup3)
        Me.grpSize.Controls.Add(Me.lblGroup2)
        Me.grpSize.Controls.Add(Me.lblGroup1)
        Me.grpSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSize.ForeColor = System.Drawing.Color.Blue
        Me.grpSize.Location = New System.Drawing.Point(216, 241)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(363, 286)
        Me.grpSize.TabIndex = 8
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Group Size:"
        '
        'lblGroup4
        '
        Me.lblGroup4.AutoSize = True
        Me.lblGroup4.Location = New System.Drawing.Point(20, 236)
        Me.lblGroup4.Name = "lblGroup4"
        Me.lblGroup4.Size = New System.Drawing.Size(109, 39)
        Me.lblGroup4.TabIndex = 3
        Me.lblGroup4.Text = "25-99"
        '
        'lblGroup3
        '
        Me.lblGroup3.AutoSize = True
        Me.lblGroup3.Location = New System.Drawing.Point(20, 171)
        Me.lblGroup3.Name = "lblGroup3"
        Me.lblGroup3.Size = New System.Drawing.Size(109, 39)
        Me.lblGroup3.TabIndex = 2
        Me.lblGroup3.Text = "13-24"
        '
        'lblGroup2
        '
        Me.lblGroup2.AutoSize = True
        Me.lblGroup2.Location = New System.Drawing.Point(26, 106)
        Me.lblGroup2.Name = "lblGroup2"
        Me.lblGroup2.Size = New System.Drawing.Size(89, 39)
        Me.lblGroup2.TabIndex = 1
        Me.lblGroup2.Text = "9-12"
        '
        'lblGroup1
        '
        Me.lblGroup1.AutoSize = True
        Me.lblGroup1.Location = New System.Drawing.Point(26, 41)
        Me.lblGroup1.Name = "lblGroup1"
        Me.lblGroup1.Size = New System.Drawing.Size(69, 39)
        Me.lblGroup1.TabIndex = 0
        Me.lblGroup1.Text = "1-8"
        '
        'grpPrice
        '
        Me.grpPrice.Controls.Add(Me.lblPrice4)
        Me.grpPrice.Controls.Add(Me.lblPrice3)
        Me.grpPrice.Controls.Add(Me.lblPrice2)
        Me.grpPrice.Controls.Add(Me.lblPrice1)
        Me.grpPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrice.ForeColor = System.Drawing.Color.Blue
        Me.grpPrice.Location = New System.Drawing.Point(689, 241)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Size = New System.Drawing.Size(310, 286)
        Me.grpPrice.TabIndex = 9
        Me.grpPrice.TabStop = False
        Me.grpPrice.Text = "Price per Person:"
        '
        'lblPrice4
        '
        Me.lblPrice4.AutoSize = True
        Me.lblPrice4.Location = New System.Drawing.Point(13, 236)
        Me.lblPrice4.Name = "lblPrice4"
        Me.lblPrice4.Size = New System.Drawing.Size(97, 39)
        Me.lblPrice4.TabIndex = 3
        Me.lblPrice4.Text = "$149"
        '
        'lblPrice3
        '
        Me.lblPrice3.AutoSize = True
        Me.lblPrice3.Location = New System.Drawing.Point(13, 171)
        Me.lblPrice3.Name = "lblPrice3"
        Me.lblPrice3.Size = New System.Drawing.Size(97, 39)
        Me.lblPrice3.TabIndex = 2
        Me.lblPrice3.Text = "$199"
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Location = New System.Drawing.Point(13, 106)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(97, 39)
        Me.lblPrice2.TabIndex = 1
        Me.lblPrice2.Text = "$219"
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Location = New System.Drawing.Point(13, 41)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(97, 39)
        Me.lblPrice1.TabIndex = 0
        Me.lblPrice1.Text = "$249"
        '
        'frmBroadwayTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 814)
        Me.Controls.Add(Me.grpPrice)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTicketCost)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBroadwayTicket"
        Me.Text = "Broadway Ticket Application"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents lblTicketCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents lblGroup2 As Label
    Friend WithEvents lblGroup1 As Label
    Friend WithEvents lblGroup3 As Label
    Friend WithEvents lblGroup4 As Label
    Friend WithEvents grpPrice As GroupBox
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblPrice4 As Label
End Class
