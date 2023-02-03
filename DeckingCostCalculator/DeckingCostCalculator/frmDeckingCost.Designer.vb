<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckingCost
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSquareFootage = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.grpDeckingType = New System.Windows.Forms.GroupBox()
        Me.radComposite = New System.Windows.Forms.RadioButton()
        Me.radRedWood = New System.Windows.Forms.RadioButton()
        Me.radLumber = New System.Windows.Forms.RadioButton()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpDeckingType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(23, 63)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(613, 61)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Decking Cost Calculator"
        '
        'lblSquareFootage
        '
        Me.lblSquareFootage.AutoSize = True
        Me.lblSquareFootage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFootage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSquareFootage.Location = New System.Drawing.Point(110, 207)
        Me.lblSquareFootage.Name = "lblSquareFootage"
        Me.lblSquareFootage.Size = New System.Drawing.Size(285, 39)
        Me.lblSquareFootage.TabIndex = 1
        Me.lblSquareFootage.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.BackColor = System.Drawing.Color.White
        Me.txtFootage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.Location = New System.Drawing.Point(477, 201)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(137, 45)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDeckingType
        '
        Me.grpDeckingType.Controls.Add(Me.radComposite)
        Me.grpDeckingType.Controls.Add(Me.radRedWood)
        Me.grpDeckingType.Controls.Add(Me.radLumber)
        Me.grpDeckingType.Font = New System.Drawing.Font("Goudy Old Style", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeckingType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpDeckingType.Location = New System.Drawing.Point(110, 323)
        Me.grpDeckingType.Name = "grpDeckingType"
        Me.grpDeckingType.Size = New System.Drawing.Size(641, 247)
        Me.grpDeckingType.TabIndex = 3
        Me.grpDeckingType.TabStop = False
        Me.grpDeckingType.Text = "Decking Type:"
        '
        'radComposite
        '
        Me.radComposite.AutoSize = True
        Me.radComposite.Location = New System.Drawing.Point(7, 186)
        Me.radComposite.Name = "radComposite"
        Me.radComposite.Size = New System.Drawing.Size(202, 43)
        Me.radComposite.TabIndex = 2
        Me.radComposite.TabStop = True
        Me.radComposite.Text = "Composite"
        Me.radComposite.UseVisualStyleBackColor = True
        '
        'radRedWood
        '
        Me.radRedWood.AutoSize = True
        Me.radRedWood.Location = New System.Drawing.Point(6, 122)
        Me.radRedWood.Name = "radRedWood"
        Me.radRedWood.Size = New System.Drawing.Size(195, 43)
        Me.radRedWood.TabIndex = 1
        Me.radRedWood.TabStop = True
        Me.radRedWood.Text = "RedWood"
        Me.radRedWood.UseVisualStyleBackColor = True
        '
        'radLumber
        '
        Me.radLumber.AutoSize = True
        Me.radLumber.Checked = True
        Me.radLumber.Location = New System.Drawing.Point(7, 58)
        Me.radLumber.Name = "radLumber"
        Me.radLumber.Size = New System.Drawing.Size(403, 43)
        Me.radLumber.TabIndex = 0
        Me.radLumber.TabStop = True
        Me.radLumber.Text = "Pressure-Treated Lumber"
        Me.radLumber.UseVisualStyleBackColor = True
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCostEstimate.Location = New System.Drawing.Point(110, 613)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(269, 39)
        Me.lblCostEstimate.TabIndex = 4
        Me.lblCostEstimate.Text = "Cost Estimates:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(272, 721)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 68)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(627, 721)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(192, 68)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(982, 721)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 68)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DeckingCostCalculator.My.Resources.Resources.deck
        Me.PictureBox1.Location = New System.Drawing.Point(774, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(749, 674)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmDeckingCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1525, 848)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.grpDeckingType)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblSquareFootage)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmDeckingCost"
        Me.Text = "Decking Cost Calculator"
        Me.grpDeckingType.ResumeLayout(False)
        Me.grpDeckingType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFootage As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents grpDeckingType As GroupBox
    Friend WithEvents radComposite As RadioButton
    Friend WithEvents radRedWood As RadioButton
    Friend WithEvents radLumber As RadioButton
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
