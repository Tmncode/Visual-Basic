<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitnessTracker
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBrithdate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.maskedBirthDate = New System.Windows.Forms.MaskedTextBox()
        Me.maskedCurrentDate = New System.Windows.Forms.MaskedTextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblExerciseHour = New System.Windows.Forms.Label()
        Me.txtExerciseHour = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtDisplayMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(42, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(319, 36)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Enter your first name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(778, 125)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(245, 57)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBrithdate
        '
        Me.lblBrithdate.AutoSize = True
        Me.lblBrithdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrithdate.Location = New System.Drawing.Point(42, 214)
        Me.lblBrithdate.Name = "lblBrithdate"
        Me.lblBrithdate.Size = New System.Drawing.Size(318, 36)
        Me.lblBrithdate.TabIndex = 2
        Me.lblBrithdate.Text = "Enter your Birth date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(42, 294)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(257, 36)
        Me.lblCurrentDate.TabIndex = 4
        Me.lblCurrentDate.Text = "Enter today date:"
        '
        'maskedBirthDate
        '
        Me.maskedBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedBirthDate.Location = New System.Drawing.Point(779, 205)
        Me.maskedBirthDate.Mask = "00/00/0000"
        Me.maskedBirthDate.Name = "maskedBirthDate"
        Me.maskedBirthDate.Size = New System.Drawing.Size(245, 41)
        Me.maskedBirthDate.TabIndex = 5
        Me.maskedBirthDate.ValidatingType = GetType(Date)
        '
        'maskedCurrentDate
        '
        Me.maskedCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedCurrentDate.Location = New System.Drawing.Point(779, 285)
        Me.maskedCurrentDate.Mask = "00/00/0000"
        Me.maskedCurrentDate.Name = "maskedCurrentDate"
        Me.maskedCurrentDate.Size = New System.Drawing.Size(245, 41)
        Me.maskedCurrentDate.TabIndex = 6
        Me.maskedCurrentDate.ValidatingType = GetType(Date)
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(457, 637)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(186, 78)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(773, 637)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 78)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnResult
        '
        Me.btnResult.BackColor = System.Drawing.Color.Yellow
        Me.btnResult.Location = New System.Drawing.Point(141, 637)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(186, 78)
        Me.btnResult.TabIndex = 9
        Me.btnResult.Text = "Get Result"
        Me.btnResult.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(396, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(309, 46)
        Me.lblHeading.TabIndex = 10
        Me.lblHeading.Text = "Fitness Tracker"
        '
        'lblExerciseHour
        '
        Me.lblExerciseHour.AutoSize = True
        Me.lblExerciseHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExerciseHour.Location = New System.Drawing.Point(42, 374)
        Me.lblExerciseHour.Name = "lblExerciseHour"
        Me.lblExerciseHour.Size = New System.Drawing.Size(438, 36)
        Me.lblExerciseHour.TabIndex = 11
        Me.lblExerciseHour.Text = "Enter your total workout hour:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtExerciseHour
        '
        Me.txtExerciseHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExerciseHour.Location = New System.Drawing.Point(779, 359)
        Me.txtExerciseHour.Multiline = True
        Me.txtExerciseHour.Name = "txtExerciseHour"
        Me.txtExerciseHour.Size = New System.Drawing.Size(245, 57)
        Me.txtExerciseHour.TabIndex = 12
        Me.txtExerciseHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(22, 459)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 36)
        Me.lblDisplay.TabIndex = 13
        '
        'txtDisplayMessage
        '
        Me.txtDisplayMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayMessage.Location = New System.Drawing.Point(6, 513)
        Me.txtDisplayMessage.Multiline = True
        Me.txtDisplayMessage.Name = "txtDisplayMessage"
        Me.txtDisplayMessage.Size = New System.Drawing.Size(1083, 89)
        Me.txtDisplayMessage.TabIndex = 14
        '
        'frmFitnessTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 744)
        Me.Controls.Add(Me.txtDisplayMessage)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtExerciseHour)
        Me.Controls.Add(Me.lblExerciseHour)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.maskedCurrentDate)
        Me.Controls.Add(Me.maskedBirthDate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblBrithdate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmFitnessTracker"
        Me.Text = "Fitness Tracker Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblBrithdate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents maskedBirthDate As MaskedTextBox
    Friend WithEvents maskedCurrentDate As MaskedTextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblExerciseHour As Label
    Friend WithEvents txtExerciseHour As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtDisplayMessage As TextBox
End Class
