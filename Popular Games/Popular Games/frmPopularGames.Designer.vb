<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopularGames
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
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.lblGameDownload = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(97, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(239, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Top selling video games"
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 16
        Me.lstGames.Location = New System.Drawing.Point(55, 121)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(318, 148)
        Me.lstGames.TabIndex = 1
        '
        'cboSelect
        '
        Me.cboSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(55, 89)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(318, 24)
        Me.cboSelect.TabIndex = 2
        Me.cboSelect.Text = "Select Games"
        '
        'lblGameDownload
        '
        Me.lblGameDownload.AutoSize = True
        Me.lblGameDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameDownload.Location = New System.Drawing.Point(98, 292)
        Me.lblGameDownload.Name = "lblGameDownload"
        Me.lblGameDownload.Size = New System.Drawing.Size(143, 16)
        Me.lblGameDownload.TabIndex = 4
        Me.lblGameDownload.Text = "XXXXXXXXXXXXXXX"
        Me.lblGameDownload.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(180, 22)
        Me.mnuDisplay.Text = "&Display Downloads"
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
        'frmPopularGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 384)
        Me.Controls.Add(Me.lblGameDownload)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPopularGames"
        Me.Text = "Most Popular Games Sold"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstGames As ListBox
    Friend WithEvents cboSelect As ComboBox
    Friend WithEvents lblGameDownload As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
