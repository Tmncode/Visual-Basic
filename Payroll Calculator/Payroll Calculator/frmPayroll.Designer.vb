<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblBiWeekly = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnTotalIncome = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblFICAtax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFICAdeduction = New System.Windows.Forms.Label()
        Me.lblFederalDeduction = New System.Windows.Forms.Label()
        Me.lblStateDeduction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBiWeekly
        '
        Me.lblBiWeekly.AutoSize = True
        Me.lblBiWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiWeekly.Location = New System.Drawing.Point(62, 120)
        Me.lblBiWeekly.Name = "lblBiWeekly"
        Me.lblBiWeekly.Size = New System.Drawing.Size(435, 36)
        Me.lblBiWeekly.TabIndex = 0
        Me.lblBiWeekly.Text = "Enter your Bi-Weekly income:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(636, 115)
        Me.txtGrossPay.Multiline = True
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(160, 51)
        Me.txtGrossPay.TabIndex = 1
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTotalIncome
        '
        Me.btnTotalIncome.BackColor = System.Drawing.Color.Yellow
        Me.btnTotalIncome.Location = New System.Drawing.Point(54, 547)
        Me.btnTotalIncome.Name = "btnTotalIncome"
        Me.btnTotalIncome.Size = New System.Drawing.Size(160, 77)
        Me.btnTotalIncome.TabIndex = 2
        Me.btnTotalIncome.Text = "Get Total"
        Me.btnTotalIncome.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Location = New System.Drawing.Point(337, 547)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 77)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(636, 547)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 77)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(459, 451)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(0, 39)
        Me.lblNetPay.TabIndex = 5
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(298, 39)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(254, 46)
        Me.lblHeading.TabIndex = 6
        Me.lblHeading.Text = "PayRoll LLC"
        '
        'lblFICAtax
        '
        Me.lblFICAtax.AutoSize = True
        Me.lblFICAtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICAtax.Location = New System.Drawing.Point(62, 197)
        Me.lblFICAtax.Name = "lblFICAtax"
        Me.lblFICAtax.Size = New System.Drawing.Size(310, 36)
        Me.lblFICAtax.TabIndex = 7
        Me.lblFICAtax.Text = "FICA Tax Deduction:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(62, 275)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(345, 36)
        Me.lblFederalTax.TabIndex = 8
        Me.lblFederalTax.Text = "Federal Tax Deduction:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(62, 347)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(311, 36)
        Me.lblStateTax.TabIndex = 9
        Me.lblStateTax.Text = "State Tax Deduction:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(254, 453)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(153, 36)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Net Total:"
        '
        'lblFICAdeduction
        '
        Me.lblFICAdeduction.AutoSize = True
        Me.lblFICAdeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICAdeduction.Location = New System.Drawing.Point(636, 200)
        Me.lblFICAdeduction.Name = "lblFICAdeduction"
        Me.lblFICAdeduction.Size = New System.Drawing.Size(0, 36)
        Me.lblFICAdeduction.TabIndex = 14
        '
        'lblFederalDeduction
        '
        Me.lblFederalDeduction.AutoSize = True
        Me.lblFederalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalDeduction.Location = New System.Drawing.Point(636, 275)
        Me.lblFederalDeduction.Name = "lblFederalDeduction"
        Me.lblFederalDeduction.Size = New System.Drawing.Size(0, 36)
        Me.lblFederalDeduction.TabIndex = 15
        '
        'lblStateDeduction
        '
        Me.lblStateDeduction.AutoSize = True
        Me.lblStateDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateDeduction.Location = New System.Drawing.Point(636, 347)
        Me.lblStateDeduction.Name = "lblStateDeduction"
        Me.lblStateDeduction.Size = New System.Drawing.Size(0, 36)
        Me.lblStateDeduction.TabIndex = 16
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(851, 667)
        Me.Controls.Add(Me.lblStateDeduction)
        Me.Controls.Add(Me.lblFederalDeduction)
        Me.Controls.Add(Me.lblFICAdeduction)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICAtax)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalIncome)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblBiWeekly)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Calulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBiWeekly As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnTotalIncome As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFICAtax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFICAdeduction As Label
    Friend WithEvents lblFederalDeduction As Label
    Friend WithEvents lblStateDeduction As Label
End Class
