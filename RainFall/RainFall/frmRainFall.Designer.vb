<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainFall
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
        Me.mnuRainfall = New System.Windows.Forms.MenuStrip()
        Me.lstRainFallAverage = New System.Windows.Forms.ListBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnEnterAverage = New System.Windows.Forms.Button()
        Me.lblAverageRainfall = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRainfall.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(28, 74)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(557, 48)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Most Rainfall in US - Kauai"
        '
        'mnuRainfall
        '
        Me.mnuRainfall.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuRainfall.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnuRainfall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuRainfall.Location = New System.Drawing.Point(0, 0)
        Me.mnuRainfall.Name = "mnuRainfall"
        Me.mnuRainfall.Size = New System.Drawing.Size(1018, 49)
        Me.mnuRainfall.TabIndex = 1
        Me.mnuRainfall.Text = "MenuStrip1"
        '
        'lstRainFallAverage
        '
        Me.lstRainFallAverage.BackColor = System.Drawing.Color.White
        Me.lstRainFallAverage.Font = New System.Drawing.Font("Tahoma", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainFallAverage.ForeColor = System.Drawing.Color.Red
        Me.lstRainFallAverage.FormattingEnabled = True
        Me.lstRainFallAverage.ItemHeight = 33
        Me.lstRainFallAverage.Location = New System.Drawing.Point(788, 74)
        Me.lstRainFallAverage.Name = "lstRainFallAverage"
        Me.lstRainFallAverage.Size = New System.Drawing.Size(40, 301)
        Me.lstRainFallAverage.TabIndex = 2
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Font = New System.Drawing.Font("Tahoma", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.Black
        Me.lblAverage.Location = New System.Drawing.Point(87, 155)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(246, 34)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Rainfall Average"
        '
        'btnEnterAverage
        '
        Me.btnEnterAverage.BackColor = System.Drawing.Color.White
        Me.btnEnterAverage.Font = New System.Drawing.Font("Tahoma", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterAverage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnterAverage.Location = New System.Drawing.Point(36, 223)
        Me.btnEnterAverage.Name = "btnEnterAverage"
        Me.btnEnterAverage.Size = New System.Drawing.Size(222, 63)
        Me.btnEnterAverage.TabIndex = 4
        Me.btnEnterAverage.Text = "Enter Rainfall"
        Me.btnEnterAverage.UseVisualStyleBackColor = False
        '
        'lblAverageRainfall
        '
        Me.lblAverageRainfall.AutoSize = True
        Me.lblAverageRainfall.BackColor = System.Drawing.Color.Transparent
        Me.lblAverageRainfall.Font = New System.Drawing.Font("Tahoma", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRainfall.ForeColor = System.Drawing.Color.Red
        Me.lblAverageRainfall.Location = New System.Drawing.Point(29, 320)
        Me.lblAverageRainfall.Name = "lblAverageRainfall"
        Me.lblAverageRainfall.Size = New System.Drawing.Size(730, 41)
        Me.lblAverageRainfall.TabIndex = 5
        Me.lblAverageRainfall.Text = "Average Rainfall per Month is XX.X inches"
        Me.lblAverageRainfall.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 48)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmRainFall
        '
        Me.AcceptButton = Me.btnEnterAverage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(30.0!, 57.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.RainFall.My.Resources.Resources.hawaii
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 652)
        Me.Controls.Add(Me.lblAverageRainfall)
        Me.Controls.Add(Me.btnEnterAverage)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lstRainFallAverage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuRainfall)
        Me.Font = New System.Drawing.Font("Tahoma", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuRainfall
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmRainFall"
        Me.Text = "Rain Fall"
        Me.mnuRainfall.ResumeLayout(False)
        Me.mnuRainfall.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents mnuRainfall As MenuStrip
    Friend WithEvents lstRainFallAverage As ListBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnEnterAverage As Button
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
