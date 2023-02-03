<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.btnPunpkin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.lblInstructionMessage = New System.Windows.Forms.Label()
        Me.lblConfirmationMesssge = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Tahoma", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblMenu.Location = New System.Drawing.Point(292, 38)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(386, 58)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Latte Selection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = Global.LatteSelection.My.Resources.Resources.pumpkin
        Me.picPumpkin.Location = New System.Drawing.Point(137, 141)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(234, 232)
        Me.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'picMocha
        '
        Me.picMocha.Image = Global.LatteSelection.My.Resources.Resources.mocha
        Me.picMocha.Location = New System.Drawing.Point(628, 141)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(234, 232)
        Me.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMocha.TabIndex = 2
        Me.picMocha.TabStop = False
        Me.picMocha.Visible = False
        '
        'btnPunpkin
        '
        Me.btnPunpkin.BackColor = System.Drawing.Color.Bisque
        Me.btnPunpkin.Location = New System.Drawing.Point(79, 407)
        Me.btnPunpkin.Name = "btnPunpkin"
        Me.btnPunpkin.Size = New System.Drawing.Size(244, 91)
        Me.btnPunpkin.TabIndex = 3
        Me.btnPunpkin.Text = "Pumpkin spice"
        Me.btnPunpkin.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Bisque
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(391, 407)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(228, 91)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Latte Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnMocha
        '
        Me.btnMocha.BackColor = System.Drawing.Color.Bisque
        Me.btnMocha.Location = New System.Drawing.Point(687, 407)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(232, 91)
        Me.btnMocha.TabIndex = 5
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = False
        '
        'lblInstructionMessage
        '
        Me.lblInstructionMessage.AutoSize = True
        Me.lblInstructionMessage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionMessage.ForeColor = System.Drawing.Color.Black
        Me.lblInstructionMessage.Location = New System.Drawing.Point(144, 546)
        Me.lblInstructionMessage.Name = "lblInstructionMessage"
        Me.lblInstructionMessage.Size = New System.Drawing.Size(710, 36)
        Me.lblInstructionMessage.TabIndex = 6
        Me.lblInstructionMessage.Text = "Choose a flavor and click on the select button."
        '
        'lblConfirmationMesssge
        '
        Me.lblConfirmationMesssge.AutoSize = True
        Me.lblConfirmationMesssge.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmationMesssge.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmationMesssge.Location = New System.Drawing.Point(296, 636)
        Me.lblConfirmationMesssge.Name = "lblConfirmationMesssge"
        Me.lblConfirmationMesssge.Size = New System.Drawing.Size(407, 36)
        Me.lblConfirmationMesssge.TabIndex = 7
        Me.lblConfirmationMesssge.Text = "Enjoy your latte selection."
        Me.lblConfirmationMesssge.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Bisque
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(391, 719)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(228, 88)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(998, 882)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmationMesssge)
        Me.Controls.Add(Me.lblInstructionMessage)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPunpkin)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "frmLatteSelection"
        Me.Text = "Latte Selection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnPunpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents lblInstructionMessage As Label
    Friend WithEvents lblConfirmationMesssge As Label
    Friend WithEvents btnExit As Button
End Class
