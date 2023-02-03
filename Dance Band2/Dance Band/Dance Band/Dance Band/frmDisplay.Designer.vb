<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.lstSongs2 = New System.Windows.Forms.ListBox()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(126, 277)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(160, 39)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lstSongs2
        '
        Me.lstSongs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSongs2.FormattingEnabled = True
        Me.lstSongs2.ItemHeight = 16
        Me.lstSongs2.Location = New System.Drawing.Point(12, 65)
        Me.lstSongs2.Name = "lstSongs2"
        Me.lstSongs2.Size = New System.Drawing.Size(380, 180)
        Me.lstSongs2.TabIndex = 1
        '
        'cboSort
        '
        Me.cboSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"Current Play Order", "Sorted Song List"})
        Me.cboSort.Location = New System.Drawing.Point(12, 35)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(177, 24)
        Me.cboSort.TabIndex = 2
        Me.cboSort.Text = "Select Order"
        '
        'frmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 358)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.lstSongs2)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmDisplay"
        Me.Text = "Dance Band"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lstSongs2 As ListBox
    Friend WithEvents cboSort As ComboBox
End Class
