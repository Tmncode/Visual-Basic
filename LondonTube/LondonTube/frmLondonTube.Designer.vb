<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLondonTube
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.grpZone = New System.Windows.Forms.GroupBox()
        Me.radZone1 = New System.Windows.Forms.RadioButton()
        Me.radZone2 = New System.Windows.Forms.RadioButton()
        Me.radZone3 = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTicketCost = New System.Windows.Forms.Label()
        Me.grpZone.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(164, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "London Tube Ticket"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.ForeColor = System.Drawing.Color.Blue
        Me.lblTicket.Location = New System.Drawing.Point(167, 164)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(337, 39)
        Me.lblTicket.TabIndex = 1
        Me.lblTicket.Text = "Enter ticket amount:"
        '
        'txtTicket
        '
        Me.txtTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicket.Location = New System.Drawing.Point(603, 161)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(100, 45)
        Me.txtTicket.TabIndex = 2
        Me.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpZone
        '
        Me.grpZone.Controls.Add(Me.radZone3)
        Me.grpZone.Controls.Add(Me.radZone2)
        Me.grpZone.Controls.Add(Me.radZone1)
        Me.grpZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpZone.ForeColor = System.Drawing.Color.Blue
        Me.grpZone.Location = New System.Drawing.Point(199, 263)
        Me.grpZone.Name = "grpZone"
        Me.grpZone.Size = New System.Drawing.Size(504, 256)
        Me.grpZone.TabIndex = 3
        Me.grpZone.TabStop = False
        Me.grpZone.Text = "Select Zone"
        '
        'radZone1
        '
        Me.radZone1.AutoSize = True
        Me.radZone1.Location = New System.Drawing.Point(7, 56)
        Me.radZone1.Name = "radZone1"
        Me.radZone1.Size = New System.Drawing.Size(198, 43)
        Me.radZone1.TabIndex = 0
        Me.radZone1.TabStop = True
        Me.radZone1.Text = "Zone 1-3"
        Me.radZone1.UseVisualStyleBackColor = True
        '
        'radZone2
        '
        Me.radZone2.AutoSize = True
        Me.radZone2.Location = New System.Drawing.Point(7, 123)
        Me.radZone2.Name = "radZone2"
        Me.radZone2.Size = New System.Drawing.Size(198, 43)
        Me.radZone2.TabIndex = 1
        Me.radZone2.TabStop = True
        Me.radZone2.Text = "Zone 1-5"
        Me.radZone2.UseVisualStyleBackColor = True
        '
        'radZone3
        '
        Me.radZone3.AutoSize = True
        Me.radZone3.Location = New System.Drawing.Point(7, 188)
        Me.radZone3.Name = "radZone3"
        Me.radZone3.Size = New System.Drawing.Size(198, 43)
        Me.radZone3.TabIndex = 2
        Me.radZone3.TabStop = True
        Me.radZone3.Text = "Zone 1-6"
        Me.radZone3.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Blue
        Me.btnCalculate.Location = New System.Drawing.Point(47, 666)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(231, 90)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Location = New System.Drawing.Point(341, 666)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(231, 90)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(624, 666)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(231, 90)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTicketCost
        '
        Me.lblTicketCost.AutoSize = True
        Me.lblTicketCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCost.ForeColor = System.Drawing.Color.Blue
        Me.lblTicketCost.Location = New System.Drawing.Point(169, 560)
        Me.lblTicketCost.Name = "lblTicketCost"
        Me.lblTicketCost.Size = New System.Drawing.Size(208, 39)
        Me.lblTicketCost.TabIndex = 7
        Me.lblTicketCost.Text = "Ticket Cost:"
        '
        'frmLondonTube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 852)
        Me.Controls.Add(Me.lblTicketCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpZone)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLondonTube"
        Me.Text = "London Tube Ticket"
        Me.grpZone.ResumeLayout(False)
        Me.grpZone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents grpZone As GroupBox
    Friend WithEvents radZone3 As RadioButton
    Friend WithEvents radZone2 As RadioButton
    Friend WithEvents radZone1 As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTicketCost As Label
End Class
