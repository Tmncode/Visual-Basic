<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectricApplication
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDisplayStatistics = New System.Windows.Forms.Button()
        Me.cboSelectedMonth = New System.Windows.Forms.ComboBox()
        Me.lblDisplayMonthSavings = New System.Windows.Forms.Label()
        Me.lblDisplayAverageMonthlySavings = New System.Windows.Forms.Label()
        Me.lblDisplayMonthMostSignificantSavings = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelect = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Electric_Savings.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(349, 56)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 84)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Smart Home " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        '
        'btnDisplayStatistics
        '
        Me.btnDisplayStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStatistics.Location = New System.Drawing.Point(257, 345)
        Me.btnDisplayStatistics.Name = "btnDisplayStatistics"
        Me.btnDisplayStatistics.Size = New System.Drawing.Size(181, 38)
        Me.btnDisplayStatistics.TabIndex = 2
        Me.btnDisplayStatistics.Text = "Display Statistics"
        Me.btnDisplayStatistics.UseVisualStyleBackColor = True
        '
        'cboSelectedMonth
        '
        Me.cboSelectedMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectedMonth.FormattingEnabled = True
        Me.cboSelectedMonth.Location = New System.Drawing.Point(419, 198)
        Me.cboSelectedMonth.Name = "cboSelectedMonth"
        Me.cboSelectedMonth.Size = New System.Drawing.Size(143, 28)
        Me.cboSelectedMonth.TabIndex = 3
        '
        'lblDisplayMonthSavings
        '
        Me.lblDisplayMonthSavings.AutoSize = True
        Me.lblDisplayMonthSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayMonthSavings.Location = New System.Drawing.Point(153, 306)
        Me.lblDisplayMonthSavings.Name = "lblDisplayMonthSavings"
        Me.lblDisplayMonthSavings.Size = New System.Drawing.Size(369, 20)
        Me.lblDisplayMonthSavings.TabIndex = 4
        Me.lblDisplayMonthSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblDisplayMonthSavings.Visible = False
        '
        'lblDisplayAverageMonthlySavings
        '
        Me.lblDisplayAverageMonthlySavings.AutoSize = True
        Me.lblDisplayAverageMonthlySavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayAverageMonthlySavings.Location = New System.Drawing.Point(153, 406)
        Me.lblDisplayAverageMonthlySavings.Name = "lblDisplayAverageMonthlySavings"
        Me.lblDisplayAverageMonthlySavings.Size = New System.Drawing.Size(369, 20)
        Me.lblDisplayAverageMonthlySavings.TabIndex = 5
        Me.lblDisplayAverageMonthlySavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblDisplayAverageMonthlySavings.Visible = False
        '
        'lblDisplayMonthMostSignificantSavings
        '
        Me.lblDisplayMonthMostSignificantSavings.AutoSize = True
        Me.lblDisplayMonthMostSignificantSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayMonthMostSignificantSavings.Location = New System.Drawing.Point(153, 449)
        Me.lblDisplayMonthMostSignificantSavings.Name = "lblDisplayMonthMostSignificantSavings"
        Me.lblDisplayMonthMostSignificantSavings.Size = New System.Drawing.Size(369, 20)
        Me.lblDisplayMonthMostSignificantSavings.TabIndex = 6
        Me.lblDisplayMonthMostSignificantSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblDisplayMonthMostSignificantSavings.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(415, 175)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(120, 20)
        Me.lblSelect.TabIndex = 8
        Me.lblSelect.Text = "Select Month:"
        '
        'ElectricApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 493)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblDisplayMonthMostSignificantSavings)
        Me.Controls.Add(Me.lblDisplayAverageMonthlySavings)
        Me.Controls.Add(Me.lblDisplayMonthSavings)
        Me.Controls.Add(Me.cboSelectedMonth)
        Me.Controls.Add(Me.btnDisplayStatistics)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ElectricApplication"
        Me.Text = "Smart Home Monthly Electric Saving "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDisplayStatistics As Button
    Friend WithEvents cboSelectedMonth As ComboBox
    Friend WithEvents lblDisplayMonthSavings As Label
    Friend WithEvents lblDisplayAverageMonthlySavings As Label
    Friend WithEvents lblDisplayMonthMostSignificantSavings As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblSelect As Label
End Class
