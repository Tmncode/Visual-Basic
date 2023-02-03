<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampusMusicCafe
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
        Me.lblCafe = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnMicNight = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMicNight = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCafe
        '
        Me.lblCafe.AutoSize = True
        Me.lblCafe.Font = New System.Drawing.Font("Tahoma", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCafe.Location = New System.Drawing.Point(52, 15)
        Me.lblCafe.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCafe.Name = "lblCafe"
        Me.lblCafe.Size = New System.Drawing.Size(346, 23)
        Me.lblCafe.TabIndex = 0
        Me.lblCafe.Text = "Campus Music Cafe open Mic Night"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Campus_Music_Cafe.My.Resources.Resources.cafe
        Me.PictureBox1.Location = New System.Drawing.Point(24, 51)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(165, 123)
        Me.lblPhrase.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(195, 14)
        Me.lblPhrase.TabIndex = 2
        Me.lblPhrase.Text = "Welcoming all college students"
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(24, 148)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(68, 27)
        Me.btnDate.TabIndex = 3
        Me.btnDate.Text = "Date:"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnMicNight
        '
        Me.btnMicNight.Location = New System.Drawing.Point(24, 192)
        Me.btnMicNight.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnMicNight.Name = "btnMicNight"
        Me.btnMicNight.Size = New System.Drawing.Size(68, 31)
        Me.btnMicNight.TabIndex = 4
        Me.btnMicNight.Text = "Mic Night:"
        Me.btnMicNight.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(24, 242)
        Me.btnTime.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(68, 25)
        Me.btnTime.TabIndex = 5
        Me.btnTime.Text = "Time:"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(106, 155)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 6
        '
        'lblMicNight
        '
        Me.lblMicNight.AutoSize = True
        Me.lblMicNight.Location = New System.Drawing.Point(106, 202)
        Me.lblMicNight.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMicNight.Name = "lblMicNight"
        Me.lblMicNight.Size = New System.Drawing.Size(0, 13)
        Me.lblMicNight.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(106, 248)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 8
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(24, 285)
        Me.btnDetails.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(68, 25)
        Me.btnDetails.TabIndex = 9
        Me.btnDetails.Text = "More Detail"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.Location = New System.Drawing.Point(106, 291)
        Me.lblDetail.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(0, 13)
        Me.lblDetail.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(167, 311)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 33)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCampusMusicCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(444, 374)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblMicNight)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnMicNight)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCafe)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmCampusMusicCafe"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCafe As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents btnDate As Button
    Friend WithEvents btnMicNight As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMicNight As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents lblDetail As Label
    Friend WithEvents btnExit As Button
End Class
