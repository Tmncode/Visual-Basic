<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatorBMI
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBmiType = New System.Windows.Forms.GroupBox()
        Me.radMetric = New System.Windows.Forms.RadioButton()
        Me.radImperial = New System.Windows.Forms.RadioButton()
        Me.lblHeightUnit = New System.Windows.Forms.Label()
        Me.lblWeightUnit = New System.Windows.Forms.Label()
        Me.grpResult.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBmiType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(354, 299)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(99, 20)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Enter Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(354, 344)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(102, 20)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Enter Weight"
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.txtBMI)
        Me.grpResult.Controls.Add(Me.txtResult)
        Me.grpResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResult.Location = New System.Drawing.Point(44, 379)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(219, 126)
        Me.grpResult.TabIndex = 4
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Result"
        '
        'txtBMI
        '
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.Location = New System.Drawing.Point(12, 35)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(196, 26)
        Me.txtBMI.TabIndex = 15
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(12, 83)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(196, 26)
        Me.txtResult.TabIndex = 16
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(314, 426)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(79, 39)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(411, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(508, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(219, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(177, 33)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "BMI Graphic"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(459, 296)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(53, 26)
        Me.txtHeight.TabIndex = 11
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(459, 341)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(53, 26)
        Me.txtWeight.TabIndex = 12
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMI_Calculator.My.Resources.Resources.BMI
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'grpBmiType
        '
        Me.grpBmiType.Controls.Add(Me.radMetric)
        Me.grpBmiType.Controls.Add(Me.radImperial)
        Me.grpBmiType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBmiType.Location = New System.Drawing.Point(44, 273)
        Me.grpBmiType.Name = "grpBmiType"
        Me.grpBmiType.Size = New System.Drawing.Size(219, 92)
        Me.grpBmiType.TabIndex = 14
        Me.grpBmiType.TabStop = False
        Me.grpBmiType.Text = "Select a BMI type"
        '
        'radMetric
        '
        Me.radMetric.AutoSize = True
        Me.radMetric.Location = New System.Drawing.Point(7, 56)
        Me.radMetric.Name = "radMetric"
        Me.radMetric.Size = New System.Drawing.Size(70, 24)
        Me.radMetric.TabIndex = 1
        Me.radMetric.TabStop = True
        Me.radMetric.Text = "Metric"
        Me.radMetric.UseVisualStyleBackColor = True
        '
        'radImperial
        '
        Me.radImperial.AutoSize = True
        Me.radImperial.Location = New System.Drawing.Point(7, 26)
        Me.radImperial.Name = "radImperial"
        Me.radImperial.Size = New System.Drawing.Size(83, 24)
        Me.radImperial.TabIndex = 0
        Me.radImperial.TabStop = True
        Me.radImperial.Text = "Imperial"
        Me.radImperial.UseVisualStyleBackColor = True
        '
        'lblHeightUnit
        '
        Me.lblHeightUnit.AutoSize = True
        Me.lblHeightUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightUnit.Location = New System.Drawing.Point(518, 299)
        Me.lblHeightUnit.Name = "lblHeightUnit"
        Me.lblHeightUnit.Size = New System.Drawing.Size(0, 20)
        Me.lblHeightUnit.TabIndex = 17
        '
        'lblWeightUnit
        '
        Me.lblWeightUnit.AutoSize = True
        Me.lblWeightUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightUnit.Location = New System.Drawing.Point(518, 344)
        Me.lblWeightUnit.Name = "lblWeightUnit"
        Me.lblWeightUnit.Size = New System.Drawing.Size(0, 20)
        Me.lblWeightUnit.TabIndex = 18
        '
        'frmCalculatorBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(615, 517)
        Me.Controls.Add(Me.lblWeightUnit)
        Me.Controls.Add(Me.lblHeightUnit)
        Me.Controls.Add(Me.grpBmiType)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Name = "frmCalculatorBMI"
        Me.Text = "BMI Calculator"
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBmiType.ResumeLayout(False)
        Me.grpBmiType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpBmiType As GroupBox
    Friend WithEvents radMetric As RadioButton
    Friend WithEvents radImperial As RadioButton
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblHeightUnit As Label
    Friend WithEvents lblWeightUnit As Label
End Class
