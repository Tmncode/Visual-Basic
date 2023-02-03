<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthySnackSelection
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
        Me.lblHealthySnack = New System.Windows.Forms.Label()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.picSnackImage = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConformation = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnBeanBurrito = New System.Windows.Forms.Button()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.btnGreekYogurt = New System.Windows.Forms.Button()
        Me.btnSpringRolls = New System.Windows.Forms.Button()
        CType(Me.picSnackImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHealthySnack
        '
        Me.lblHealthySnack.AutoSize = True
        Me.lblHealthySnack.BackColor = System.Drawing.Color.White
        Me.lblHealthySnack.Font = New System.Drawing.Font("Tahoma", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthySnack.ForeColor = System.Drawing.Color.Red
        Me.lblHealthySnack.Location = New System.Drawing.Point(139, 73)
        Me.lblHealthySnack.Name = "lblHealthySnack"
        Me.lblHealthySnack.Size = New System.Drawing.Size(707, 58)
        Me.lblHealthySnack.TabIndex = 0
        Me.lblHealthySnack.Text = "Healthy International Snack"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(37, 183)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(540, 36)
        Me.lblSelection.TabIndex = 1
        Me.lblSelection.Text = "Select which free snack would you like?"
        '
        'picSnackImage
        '
        Me.picSnackImage.Location = New System.Drawing.Point(343, 260)
        Me.picSnackImage.Name = "picSnackImage"
        Me.picSnackImage.Size = New System.Drawing.Size(549, 398)
        Me.picSnackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSnackImage.TabIndex = 3
        Me.picSnackImage.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(721, 707)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(214, 89)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblConformation
        '
        Me.lblConformation.AutoSize = True
        Me.lblConformation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConformation.Location = New System.Drawing.Point(337, 732)
        Me.lblConformation.Name = "lblConformation"
        Me.lblConformation.Size = New System.Drawing.Size(281, 36)
        Me.lblConformation.TabIndex = 5
        Me.lblConformation.Text = "Enjoy your selection"
        Me.lblConformation.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(43, 707)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(214, 89)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Final select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnBeanBurrito
        '
        Me.btnBeanBurrito.Location = New System.Drawing.Point(68, 260)
        Me.btnBeanBurrito.Name = "btnBeanBurrito"
        Me.btnBeanBurrito.Size = New System.Drawing.Size(189, 74)
        Me.btnBeanBurrito.TabIndex = 7
        Me.btnBeanBurrito.Text = "Bean burrito"
        Me.btnBeanBurrito.UseVisualStyleBackColor = True
        '
        'btnFalafel
        '
        Me.btnFalafel.Location = New System.Drawing.Point(68, 368)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(189, 74)
        Me.btnFalafel.TabIndex = 8
        Me.btnFalafel.Text = "Falafel"
        Me.btnFalafel.UseVisualStyleBackColor = True
        '
        'btnGreekYogurt
        '
        Me.btnGreekYogurt.Location = New System.Drawing.Point(68, 476)
        Me.btnGreekYogurt.Name = "btnGreekYogurt"
        Me.btnGreekYogurt.Size = New System.Drawing.Size(189, 74)
        Me.btnGreekYogurt.TabIndex = 9
        Me.btnGreekYogurt.Text = "Greek Yogurt"
        Me.btnGreekYogurt.UseVisualStyleBackColor = True
        '
        'btnSpringRolls
        '
        Me.btnSpringRolls.Location = New System.Drawing.Point(68, 584)
        Me.btnSpringRolls.Name = "btnSpringRolls"
        Me.btnSpringRolls.Size = New System.Drawing.Size(189, 74)
        Me.btnSpringRolls.TabIndex = 10
        Me.btnSpringRolls.Text = "spring Rolls"
        Me.btnSpringRolls.UseVisualStyleBackColor = True
        '
        'HealthySnackSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 921)
        Me.Controls.Add(Me.btnSpringRolls)
        Me.Controls.Add(Me.btnGreekYogurt)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.btnBeanBurrito)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblConformation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picSnackImage)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lblHealthySnack)
        Me.Name = "HealthySnackSelection"
        Me.Text = "Healthy Snack Selection"
        CType(Me.picSnackImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHealthySnack As Label
    Friend WithEvents lblSelection As Label
    Friend WithEvents picSnackImage As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConformation As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnBeanBurrito As Button
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnGreekYogurt As Button
    Friend WithEvents btnSpringRolls As Button
End Class
