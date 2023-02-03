<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitness
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
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnWeightLoss = New System.Windows.Forms.Button()
        Me.IstWeightLoss = New System.Windows.Forms.ListBox()
        Me.lblAverageLoss = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuFitness.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFitness
        '
        Me.mnuFitness.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuFitness.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(1553, 49)
        Me.mnuFitness.TabIndex = 0
        Me.mnuFitness.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 56)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(251, 54)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(251, 54)
        Me.mnuExit.Text = "E&xit"
        '
        'btnWeightLoss
        '
        Me.btnWeightLoss.BackColor = System.Drawing.Color.YellowGreen
        Me.btnWeightLoss.Font = New System.Drawing.Font("Tahoma", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeightLoss.Location = New System.Drawing.Point(991, 207)
        Me.btnWeightLoss.Name = "btnWeightLoss"
        Me.btnWeightLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnWeightLoss.Size = New System.Drawing.Size(388, 75)
        Me.btnWeightLoss.TabIndex = 2
        Me.btnWeightLoss.Text = "Enter Weight Loss"
        Me.btnWeightLoss.UseVisualStyleBackColor = False
        '
        'IstWeightLoss
        '
        Me.IstWeightLoss.Font = New System.Drawing.Font("Tahoma", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IstWeightLoss.FormattingEnabled = True
        Me.IstWeightLoss.ItemHeight = 40
        Me.IstWeightLoss.Location = New System.Drawing.Point(1122, 298)
        Me.IstWeightLoss.Name = "IstWeightLoss"
        Me.IstWeightLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IstWeightLoss.Size = New System.Drawing.Size(126, 444)
        Me.IstWeightLoss.TabIndex = 3
        '
        'lblAverageLoss
        '
        Me.lblAverageLoss.AutoSize = True
        Me.lblAverageLoss.BackColor = System.Drawing.Color.YellowGreen
        Me.lblAverageLoss.Font = New System.Drawing.Font("Tahoma", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageLoss.Location = New System.Drawing.Point(889, 773)
        Me.lblAverageLoss.Name = "lblAverageLoss"
        Me.lblAverageLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAverageLoss.Size = New System.Drawing.Size(548, 41)
        Me.lblAverageLoss.TabIndex = 4
        Me.lblAverageLoss.Text = "Average weight loss is XX.X lbs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAverageLoss.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(939, 79)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTitle.Size = New System.Drawing.Size(466, 116)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Fitness Challenge " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team Weight Loss"
        '
        'frmFitness
        '
        Me.AcceptButton = Me.btnWeightLoss
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.FitnessChallenge.My.Resources.Resources.health
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1553, 876)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAverageLoss)
        Me.Controls.Add(Me.IstWeightLoss)
        Me.Controls.Add(Me.btnWeightLoss)
        Me.Controls.Add(Me.mnuFitness)
        Me.MainMenuStrip = Me.mnuFitness
        Me.Name = "frmFitness"
        Me.Text = "Fitness Challenge"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFitness As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnWeightLoss As Button
    Friend WithEvents IstWeightLoss As ListBox
    Friend WithEvents lblAverageLoss As Label
    Friend WithEvents lblTitle As Label
End Class
