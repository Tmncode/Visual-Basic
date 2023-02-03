<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMAX
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
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.cboTicketChoice = New System.Windows.Forms.ComboBox()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlImage
        '
        Me.pnlImage.BackgroundImage = Global.IMAXTHEATRE.My.Resources.Resources.IMAX
        Me.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlImage.Location = New System.Drawing.Point(1, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(400, 450)
        Me.pnlImage.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(457, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(295, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "IMAX Theatre Tickets"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(484, 133)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(192, 25)
        Me.lblTickets.TabIndex = 2
        Me.lblTickets.Text = "Number of Tickets:"
        Me.lblTickets.Visible = False
        '
        'cboTicketChoice
        '
        Me.cboTicketChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTicketChoice.FormattingEnabled = True
        Me.cboTicketChoice.Items.AddRange(New Object() {"Matinee $16", "Evening $27"})
        Me.cboTicketChoice.Location = New System.Drawing.Point(518, 73)
        Me.cboTicketChoice.Name = "cboTicketChoice"
        Me.cboTicketChoice.Size = New System.Drawing.Size(169, 33)
        Me.cboTicketChoice.TabIndex = 3
        Me.cboTicketChoice.Text = "Select Tickets"
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(682, 130)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(37, 31)
        Me.txtTickets.TabIndex = 4
        Me.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTickets.Visible = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.White
        Me.btnCost.Location = New System.Drawing.Point(552, 188)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(124, 37)
        Me.btnCost.TabIndex = 5
        Me.btnCost.Text = "Ticket Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        Me.btnCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(552, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 37)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(514, 314)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(141, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "XXXXXXXXXXXX"
        Me.lblTotal.Visible = False
        '
        'frmIMAX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 377)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.cboTicketChoice)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlImage)
        Me.Name = "frmIMAX"
        Me.Text = "IMAX THEATRE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlImage As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents cboTicketChoice As ComboBox
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
End Class
