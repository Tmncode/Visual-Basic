<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVirtualRealityHeadset
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picCrown = New System.Windows.Forms.PictureBox()
        Me.picEarbud = New System.Windows.Forms.PictureBox()
        Me.btnCrown = New System.Windows.Forms.Button()
        Me.btnEarbud = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VR Forward"
        '
        'picCrown
        '
        Me.picCrown.Image = Global.Virtual_Reality_Headset.My.Resources.Resources.crown
        Me.picCrown.Location = New System.Drawing.Point(57, 187)
        Me.picCrown.Name = "picCrown"
        Me.picCrown.Size = New System.Drawing.Size(441, 335)
        Me.picCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCrown.TabIndex = 1
        Me.picCrown.TabStop = False
        Me.picCrown.Visible = False
        '
        'picEarbud
        '
        Me.picEarbud.Image = Global.Virtual_Reality_Headset.My.Resources.Resources.earbud
        Me.picEarbud.Location = New System.Drawing.Point(578, 187)
        Me.picEarbud.Name = "picEarbud"
        Me.picEarbud.Size = New System.Drawing.Size(441, 335)
        Me.picEarbud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEarbud.TabIndex = 2
        Me.picEarbud.TabStop = False
        Me.picEarbud.Visible = False
        '
        'btnCrown
        '
        Me.btnCrown.Location = New System.Drawing.Point(155, 544)
        Me.btnCrown.Name = "btnCrown"
        Me.btnCrown.Size = New System.Drawing.Size(230, 96)
        Me.btnCrown.TabIndex = 3
        Me.btnCrown.Text = "VR Crown"
        Me.btnCrown.UseVisualStyleBackColor = True
        '
        'btnEarbud
        '
        Me.btnEarbud.Location = New System.Drawing.Point(683, 544)
        Me.btnEarbud.Name = "btnEarbud"
        Me.btnEarbud.Size = New System.Drawing.Size(230, 96)
        Me.btnEarbud.TabIndex = 4
        Me.btnEarbud.Text = "VR Earbud"
        Me.btnEarbud.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(426, 685)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(230, 96)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmVirtualRealityHeadset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 819)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEarbud)
        Me.Controls.Add(Me.btnCrown)
        Me.Controls.Add(Me.picEarbud)
        Me.Controls.Add(Me.picCrown)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVirtualRealityHeadset"
        Me.Text = "Virtual Reality Headset"
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picCrown As PictureBox
    Friend WithEvents picEarbud As PictureBox
    Friend WithEvents btnCrown As Button
    Friend WithEvents btnEarbud As Button
    Friend WithEvents btnExit As Button
End Class
