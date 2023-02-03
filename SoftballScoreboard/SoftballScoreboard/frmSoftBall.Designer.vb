<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftBall
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
        Me.mnuSoftball = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.lstInning = New System.Windows.Forms.ListBox()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.mnuSoftball.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuSoftball
        '
        Me.mnuSoftball.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuSoftball.Location = New System.Drawing.Point(0, 0)
        Me.mnuSoftball.Name = "mnuSoftball"
        Me.mnuSoftball.Size = New System.Drawing.Size(612, 24)
        Me.mnuSoftball.TabIndex = 0
        Me.mnuSoftball.Text = "MenuStrip1"
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
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(197, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(218, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Softball Scorebroad"
        '
        'btnScore
        '
        Me.btnScore.BackColor = System.Drawing.Color.Transparent
        Me.btnScore.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScore.ForeColor = System.Drawing.Color.Red
        Me.btnScore.Location = New System.Drawing.Point(501, 101)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(99, 33)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "Enter Score"
        Me.btnScore.UseVisualStyleBackColor = False
        '
        'lstInning
        '
        Me.lstInning.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInning.ForeColor = System.Drawing.Color.Red
        Me.lstInning.FormattingEnabled = True
        Me.lstInning.ItemHeight = 16
        Me.lstInning.Location = New System.Drawing.Point(538, 150)
        Me.lstInning.Name = "lstInning"
        Me.lstInning.Size = New System.Drawing.Size(27, 132)
        Me.lstInning.TabIndex = 3
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalScore.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.ForeColor = System.Drawing.Color.Red
        Me.lblTotalScore.Location = New System.Drawing.Point(455, 339)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(145, 19)
        Me.lblTotalScore.TabIndex = 4
        Me.lblTotalScore.Text = "Total score is XX"
        Me.lblTotalScore.Visible = False
        '
        'frmSoftBall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SoftballScoreboard.My.Resources.Resources.softball
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 367)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.lstInning)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuSoftball)
        Me.MainMenuStrip = Me.mnuSoftball
        Me.Name = "frmSoftBall"
        Me.Text = "Softball Scoreboard"
        Me.mnuSoftball.ResumeLayout(False)
        Me.mnuSoftball.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSoftball As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnScore As Button
    Friend WithEvents lstInning As ListBox
    Friend WithEvents lblTotalScore As Label
End Class
