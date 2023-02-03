<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.mtxtOrderDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxtPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtSocialSecurity = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'mtxtOrderDate
        '
        Me.mtxtOrderDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtOrderDate.Location = New System.Drawing.Point(440, 74)
        Me.mtxtOrderDate.Mask = "00/00/0000"
        Me.mtxtOrderDate.Name = "mtxtOrderDate"
        Me.mtxtOrderDate.Size = New System.Drawing.Size(285, 57)
        Me.mtxtOrderDate.TabIndex = 0
        Me.mtxtOrderDate.ValidatingType = GetType(Date)
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.Location = New System.Drawing.Point(51, 81)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(238, 46)
        Me.lblOrderDate.TabIndex = 1
        Me.lblOrderDate.Text = "Order Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Social Security:"
        '
        'mtxtPhoneNum
        '
        Me.mtxtPhoneNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtPhoneNum.Location = New System.Drawing.Point(440, 178)
        Me.mtxtPhoneNum.Mask = "(999) 000-0000"
        Me.mtxtPhoneNum.Name = "mtxtPhoneNum"
        Me.mtxtPhoneNum.Size = New System.Drawing.Size(285, 57)
        Me.mtxtPhoneNum.TabIndex = 4
        '
        'mtxtSocialSecurity
        '
        Me.mtxtSocialSecurity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtSocialSecurity.Location = New System.Drawing.Point(440, 280)
        Me.mtxtSocialSecurity.Mask = "000-00-0000"
        Me.mtxtSocialSecurity.Name = "mtxtSocialSecurity"
        Me.mtxtSocialSecurity.Size = New System.Drawing.Size(285, 57)
        Me.mtxtSocialSecurity.TabIndex = 5
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.mtxtSocialSecurity)
        Me.Controls.Add(Me.mtxtPhoneNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.mtxtOrderDate)
        Me.Name = "frmOrder"
        Me.Text = "Online Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxtOrderDate As MaskedTextBox
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtPhoneNum As MaskedTextBox
    Friend WithEvents mtxtSocialSecurity As MaskedTextBox
End Class
