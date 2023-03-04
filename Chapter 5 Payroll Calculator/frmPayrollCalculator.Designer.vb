<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iko
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
        Me.picpayrollimage = New System.Windows.Forms.PictureBox()
        Me.lblpaycalculator = New System.Windows.Forms.Label()
        Me.lblpaychck = New System.Windows.Forms.Label()
        Me.lblcalculation = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btncomputetaxes = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblfica = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFicaNumbers = New System.Windows.Forms.Label()
        Me.lblFederalTaxNumber = New System.Windows.Forms.Label()
        Me.lblStateTaxNumber = New System.Windows.Forms.Label()
        Me.lblNetPaycheckIncomedisplay = New System.Windows.Forms.Label()
        CType(Me.picpayrollimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picpayrollimage
        '
        Me.picpayrollimage.Image = Global.Chapter_5_Payroll_Calculator.My.Resources.Resources.payroll
        Me.picpayrollimage.Location = New System.Drawing.Point(1, -2)
        Me.picpayrollimage.Name = "picpayrollimage"
        Me.picpayrollimage.Size = New System.Drawing.Size(316, 361)
        Me.picpayrollimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpayrollimage.TabIndex = 0
        Me.picpayrollimage.TabStop = False
        '
        'lblpaycalculator
        '
        Me.lblpaycalculator.AutoSize = True
        Me.lblpaycalculator.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaycalculator.Location = New System.Drawing.Point(339, 26)
        Me.lblpaycalculator.Name = "lblpaycalculator"
        Me.lblpaycalculator.Size = New System.Drawing.Size(213, 34)
        Me.lblpaycalculator.TabIndex = 1
        Me.lblpaycalculator.Text = "Payroll Calculator"
        '
        'lblpaychck
        '
        Me.lblpaychck.AutoSize = True
        Me.lblpaychck.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaychck.Location = New System.Drawing.Point(395, 107)
        Me.lblpaychck.Name = "lblpaychck"
        Me.lblpaychck.Size = New System.Drawing.Size(96, 24)
        Me.lblpaychck.TabIndex = 2
        Me.lblpaychck.Text = "Paycheck"
        '
        'lblcalculation
        '
        Me.lblcalculation.AutoSize = True
        Me.lblcalculation.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcalculation.Location = New System.Drawing.Point(395, 148)
        Me.lblcalculation.Name = "lblcalculation"
        Me.lblcalculation.Size = New System.Drawing.Size(111, 24)
        Me.lblcalculation.TabIndex = 3
        Me.lblcalculation.Text = "Calculation"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(218, 394)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(139, 24)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(399, 398)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(92, 20)
        Me.txtGrossPay.TabIndex = 5
        '
        'btncomputetaxes
        '
        Me.btncomputetaxes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncomputetaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomputetaxes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncomputetaxes.Location = New System.Drawing.Point(54, 462)
        Me.btncomputetaxes.Name = "btncomputetaxes"
        Me.btncomputetaxes.Size = New System.Drawing.Size(134, 36)
        Me.btncomputetaxes.TabIndex = 6
        Me.btncomputetaxes.Text = "Compute Taxes"
        Me.btncomputetaxes.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(261, 462)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnexit.Location = New System.Drawing.Point(513, 460)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(119, 36)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lblfica
        '
        Me.lblfica.AutoSize = True
        Me.lblfica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfica.Location = New System.Drawing.Point(87, 524)
        Me.lblfica.Name = "lblfica"
        Me.lblfica.Size = New System.Drawing.Size(42, 13)
        Me.lblfica.TabIndex = 9
        Me.lblfica.Text = "FICA: "
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(282, 524)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(82, 13)
        Me.lblFederalTax.TabIndex = 10
        Me.lblFederalTax.Text = "Federal Tax: "
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(510, 524)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(70, 13)
        Me.lblStateTax.TabIndex = 11
        Me.lblStateTax.Text = "State Tax: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 582)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Net Paycheck Income:"
        '
        'lblFicaNumbers
        '
        Me.lblFicaNumbers.AutoSize = True
        Me.lblFicaNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaNumbers.Location = New System.Drawing.Point(155, 526)
        Me.lblFicaNumbers.Name = "lblFicaNumbers"
        Me.lblFicaNumbers.Size = New System.Drawing.Size(45, 13)
        Me.lblFicaNumbers.TabIndex = 14
        Me.lblFicaNumbers.Text = "Label2"
        Me.lblFicaNumbers.Visible = False
        '
        'lblFederalTaxNumber
        '
        Me.lblFederalTaxNumber.AutoSize = True
        Me.lblFederalTaxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTaxNumber.Location = New System.Drawing.Point(396, 524)
        Me.lblFederalTaxNumber.Name = "lblFederalTaxNumber"
        Me.lblFederalTaxNumber.Size = New System.Drawing.Size(45, 13)
        Me.lblFederalTaxNumber.TabIndex = 15
        Me.lblFederalTaxNumber.Text = "Label3"
        Me.lblFederalTaxNumber.Visible = False
        '
        'lblStateTaxNumber
        '
        Me.lblStateTaxNumber.AutoSize = True
        Me.lblStateTaxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTaxNumber.Location = New System.Drawing.Point(604, 524)
        Me.lblStateTaxNumber.Name = "lblStateTaxNumber"
        Me.lblStateTaxNumber.Size = New System.Drawing.Size(45, 13)
        Me.lblStateTaxNumber.TabIndex = 16
        Me.lblStateTaxNumber.Text = "Label4"
        Me.lblStateTaxNumber.Visible = False
        '
        'lblNetPaycheckIncomedisplay
        '
        Me.lblNetPaycheckIncomedisplay.AutoSize = True
        Me.lblNetPaycheckIncomedisplay.Location = New System.Drawing.Point(541, 587)
        Me.lblNetPaycheckIncomedisplay.Name = "lblNetPaycheckIncomedisplay"
        Me.lblNetPaycheckIncomedisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblNetPaycheckIncomedisplay.TabIndex = 17
        Me.lblNetPaycheckIncomedisplay.Text = "Label2"
        '
        'iko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 617)
        Me.Controls.Add(Me.lblNetPaycheckIncomedisplay)
        Me.Controls.Add(Me.lblStateTaxNumber)
        Me.Controls.Add(Me.lblFederalTaxNumber)
        Me.Controls.Add(Me.lblFicaNumbers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblfica)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btncomputetaxes)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblcalculation)
        Me.Controls.Add(Me.lblpaychck)
        Me.Controls.Add(Me.lblpaycalculator)
        Me.Controls.Add(Me.picpayrollimage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "iko"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picpayrollimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picpayrollimage As PictureBox
    Friend WithEvents lblpaycalculator As Label
    Friend WithEvents lblpaychck As Label
    Friend WithEvents lblcalculation As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btncomputetaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblfica As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFicaNumbers As Label
    Friend WithEvents lblFederalTaxNumber As Label
    Friend WithEvents lblStateTaxNumber As Label
    Friend WithEvents lblNetPaycheckIncomedisplay As Label
End Class
