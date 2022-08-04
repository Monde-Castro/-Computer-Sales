<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerSales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostPrize = New System.Windows.Forms.TextBox()
        Me.txtDiskSize = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtProductNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonthInstallment = New System.Windows.Forms.Label()
        Me.radLaptop = New System.Windows.Forms.RadioButton()
        Me.radPersonalComputer = New System.Windows.Forms.RadioButton()
        Me.radMainFrame = New System.Windows.Forms.RadioButton()
        Me.btnCalc_Installment = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtCostPrize)
        Me.GroupBox1.Controls.Add(Me.txtDiskSize)
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.txtProductNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Details"
        '
        'txtCostPrize
        '
        Me.txtCostPrize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPrize.Location = New System.Drawing.Point(182, 139)
        Me.txtCostPrize.Name = "txtCostPrize"
        Me.txtCostPrize.Size = New System.Drawing.Size(177, 29)
        Me.txtCostPrize.TabIndex = 7
        '
        'txtDiskSize
        '
        Me.txtDiskSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskSize.Location = New System.Drawing.Point(182, 104)
        Me.txtDiskSize.Name = "txtDiskSize"
        Me.txtDiskSize.Size = New System.Drawing.Size(177, 29)
        Me.txtDiskSize.TabIndex = 6
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(182, 70)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(177, 29)
        Me.txtColor.TabIndex = 5
        '
        'txtProductNum
        '
        Me.txtProductNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductNum.Location = New System.Drawing.Point(182, 32)
        Me.txtProductNum.Name = "txtProductNum"
        Me.txtProductNum.Size = New System.Drawing.Size(177, 29)
        Me.txtProductNum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost Prize:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Disk Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Color:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Number:"
        '
        'lblMonthInstallment
        '
        Me.lblMonthInstallment.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMonthInstallment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthInstallment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthInstallment.Location = New System.Drawing.Point(32, 196)
        Me.lblMonthInstallment.Name = "lblMonthInstallment"
        Me.lblMonthInstallment.Size = New System.Drawing.Size(349, 105)
        Me.lblMonthInstallment.TabIndex = 8
        Me.lblMonthInstallment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'radLaptop
        '
        Me.radLaptop.AutoSize = True
        Me.radLaptop.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radLaptop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLaptop.Location = New System.Drawing.Point(22, 343)
        Me.radLaptop.Name = "radLaptop"
        Me.radLaptop.Size = New System.Drawing.Size(85, 28)
        Me.radLaptop.TabIndex = 9
        Me.radLaptop.TabStop = True
        Me.radLaptop.Text = "Laptop"
        Me.radLaptop.UseVisualStyleBackColor = False
        '
        'radPersonalComputer
        '
        Me.radPersonalComputer.AutoSize = True
        Me.radPersonalComputer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radPersonalComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPersonalComputer.Location = New System.Drawing.Point(105, 304)
        Me.radPersonalComputer.Name = "radPersonalComputer"
        Me.radPersonalComputer.Size = New System.Drawing.Size(190, 28)
        Me.radPersonalComputer.TabIndex = 10
        Me.radPersonalComputer.TabStop = True
        Me.radPersonalComputer.Text = "Personal Computer"
        Me.radPersonalComputer.UseVisualStyleBackColor = False
        '
        'radMainFrame
        '
        Me.radMainFrame.AutoSize = True
        Me.radMainFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMainFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMainFrame.Location = New System.Drawing.Point(252, 343)
        Me.radMainFrame.Name = "radMainFrame"
        Me.radMainFrame.Size = New System.Drawing.Size(129, 28)
        Me.radMainFrame.TabIndex = 11
        Me.radMainFrame.TabStop = True
        Me.radMainFrame.Text = "Main Frame"
        Me.radMainFrame.UseVisualStyleBackColor = False
        '
        'btnCalc_Installment
        '
        Me.btnCalc_Installment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc_Installment.Location = New System.Drawing.Point(22, 377)
        Me.btnCalc_Installment.Name = "btnCalc_Installment"
        Me.btnCalc_Installment.Size = New System.Drawing.Size(359, 34)
        Me.btnCalc_Installment.TabIndex = 12
        Me.btnCalc_Installment.Text = "Calcalute I&nstallment"
        Me.btnCalc_Installment.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(22, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(306, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmComputerSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 462)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc_Installment)
        Me.Controls.Add(Me.radMainFrame)
        Me.Controls.Add(Me.radPersonalComputer)
        Me.Controls.Add(Me.radLaptop)
        Me.Controls.Add(Me.lblMonthInstallment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmComputerSales"
        Me.Text = "Computer Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostPrize As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskSize As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtProductNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMonthInstallment As System.Windows.Forms.Label
    Friend WithEvents radLaptop As System.Windows.Forms.RadioButton
    Friend WithEvents radPersonalComputer As System.Windows.Forms.RadioButton
    Friend WithEvents radMainFrame As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalc_Installment As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
