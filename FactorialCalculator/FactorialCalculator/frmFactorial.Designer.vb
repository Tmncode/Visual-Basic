<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactorial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuFactorial = New System.Windows.Forms.MenuStrip()
        Me.lstFactorialNumber = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mnuFactorial
        '
        Me.mnuFactorial.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuFactorial.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnuFactorial.Location = New System.Drawing.Point(0, 0)
        Me.mnuFactorial.Name = "mnuFactorial"
        Me.mnuFactorial.Padding = New System.Windows.Forms.Padding(14, 5, 0, 5)
        Me.mnuFactorial.Size = New System.Drawing.Size(818, 24)
        Me.mnuFactorial.TabIndex = 0
        Me.mnuFactorial.Text = "MenuStrip1"
        '
        'lstFactorialNumber
        '
        Me.lstFactorialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFactorialNumber.ForeColor = System.Drawing.Color.Red
        Me.lstFactorialNumber.FormattingEnabled = True
        Me.lstFactorialNumber.ItemHeight = 36
        Me.lstFactorialNumber.Location = New System.Drawing.Point(415, 202)
        Me.lstFactorialNumber.Margin = New System.Windows.Forms.Padding(7)
        Me.lstFactorialNumber.Name = "lstFactorialNumber"
        Me.lstFactorialNumber.Size = New System.Drawing.Size(356, 364)
        Me.lstFactorialNumber.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Red
        Me.btnOk.Location = New System.Drawing.Point(88, 204)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(7)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(203, 80)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Result"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Red
        Me.lblInstruction.Location = New System.Drawing.Point(12, 98)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(492, 40)
        Me.lblInstruction.TabIndex = 4
        Me.lblInstruction.Text = "Enter a number for factorial "
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.Red
        Me.txtInput.Location = New System.Drawing.Point(583, 93)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(188, 48)
        Me.txtInput.TabIndex = 5
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Red
        Me.btnRefresh.Location = New System.Drawing.Point(88, 345)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(203, 80)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(88, 486)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(203, 80)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 612)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lstFactorialNumber)
        Me.Controls.Add(Me.mnuFactorial)
        Me.MainMenuStrip = Me.mnuFactorial
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "frmFactorial"
        Me.Text = "Factorial Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFactorial As MenuStrip
    Friend WithEvents lstFactorialNumber As ListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExit As Button
End Class
