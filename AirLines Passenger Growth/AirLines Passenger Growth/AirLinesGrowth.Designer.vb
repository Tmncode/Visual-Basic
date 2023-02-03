<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AirLinesGrowth
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstGrowthPerYear = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblSelectYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtFinalAnswer = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(150, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Global Airlines Passenger Growth RATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lstGrowthPerYear
        '
        Me.lstGrowthPerYear.FormattingEnabled = True
        Me.lstGrowthPerYear.Location = New System.Drawing.Point(341, 100)
        Me.lstGrowthPerYear.MultiColumn = True
        Me.lstGrowthPerYear.Name = "lstGrowthPerYear"
        Me.lstGrowthPerYear.Size = New System.Drawing.Size(455, 147)
        Me.lstGrowthPerYear.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(526, 253)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 35)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display "
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblSelectYear
        '
        Me.lblSelectYear.AutoSize = True
        Me.lblSelectYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectYear.Location = New System.Drawing.Point(425, 70)
        Me.lblSelectYear.Name = "lblSelectYear"
        Me.lblSelectYear.Size = New System.Drawing.Size(197, 16)
        Me.lblSelectYear.TabIndex = 5
        Me.lblSelectYear.Text = "Enter a Year from 2017 thru 2027"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(637, 67)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(72, 22)
        Me.txtYear.TabIndex = 6
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFinalAnswer
        '
        Me.txtFinalAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalAnswer.Location = New System.Drawing.Point(341, 294)
        Me.txtFinalAnswer.Multiline = True
        Me.txtFinalAnswer.Name = "txtFinalAnswer"
        Me.txtFinalAnswer.Size = New System.Drawing.Size(455, 43)
        Me.txtFinalAnswer.TabIndex = 7
        Me.txtFinalAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(459, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(613, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.AirLines_Passenger_Growth.My.Resources.Resources.Airline
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 364)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'AirLinesGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 415)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtFinalAnswer)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblSelectYear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstGrowthPerYear)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AirLinesGrowth"
        Me.Text = "Airlines Passenger Growth"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstGrowthPerYear As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblSelectYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtFinalAnswer As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
