<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalDownLoad
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTotalDownLoad = New System.Windows.Forms.Label()
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(100, 308)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(159, 42)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return Application"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblTotalDownLoad
        '
        Me.lblTotalDownLoad.AutoSize = True
        Me.lblTotalDownLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDownLoad.Location = New System.Drawing.Point(59, 235)
        Me.lblTotalDownLoad.Name = "lblTotalDownLoad"
        Me.lblTotalDownLoad.Size = New System.Drawing.Size(233, 16)
        Me.lblTotalDownLoad.TabIndex = 1
        Me.lblTotalDownLoad.Text = "XXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 16
        Me.lstGames.Location = New System.Drawing.Point(62, 27)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(244, 180)
        Me.lstGames.TabIndex = 2
        '
        'frmTotalDownLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 379)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.lblTotalDownLoad)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmTotalDownLoad"
        Me.Text = "frmTotalDownLoad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTotalDownLoad As Label
    Friend WithEvents lstGames As ListBox
End Class
