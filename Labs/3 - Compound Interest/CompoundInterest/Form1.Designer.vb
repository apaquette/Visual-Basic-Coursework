<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCpndInterest
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInitialBalance = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtDeposits = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFutureValue = New System.Windows.Forms.TextBox()
        Me.txtInterestEarned = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.bxInterval = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Term (years)*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monthly Deposits"
        '
        'txtInitialBalance
        '
        Me.txtInitialBalance.Location = New System.Drawing.Point(26, 38)
        Me.txtInitialBalance.Name = "txtInitialBalance"
        Me.txtInitialBalance.Size = New System.Drawing.Size(100, 23)
        Me.txtInitialBalance.TabIndex = 1
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(140, 38)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 23)
        Me.txtInterestRate.TabIndex = 2
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(26, 94)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(100, 23)
        Me.txtTerm.TabIndex = 4
        '
        'txtDeposits
        '
        Me.txtDeposits.Location = New System.Drawing.Point(140, 94)
        Me.txtDeposits.Name = "txtDeposits"
        Me.txtDeposits.Size = New System.Drawing.Size(100, 23)
        Me.txtDeposits.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Future Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Interest Earned"
        '
        'txtFutureValue
        '
        Me.txtFutureValue.Location = New System.Drawing.Point(26, 151)
        Me.txtFutureValue.Name = "txtFutureValue"
        Me.txtFutureValue.ReadOnly = True
        Me.txtFutureValue.Size = New System.Drawing.Size(100, 23)
        Me.txtFutureValue.TabIndex = 10
        Me.txtFutureValue.TabStop = False
        Me.txtFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestEarned
        '
        Me.txtInterestEarned.Location = New System.Drawing.Point(140, 151)
        Me.txtInterestEarned.Name = "txtInterestEarned"
        Me.txtInterestEarned.ReadOnly = True
        Me.txtInterestEarned.Size = New System.Drawing.Size(100, 23)
        Me.txtInterestEarned.TabIndex = 11
        Me.txtInterestEarned.TabStop = False
        Me.txtInterestEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 193)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(153, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'bxInterval
        '
        Me.bxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bxInterval.FormattingEnabled = True
        Me.bxInterval.Items.AddRange(New Object() {"Monthly", "Bi-Monthly", "Quarterly", "Half-Yearly", "Yearly"})
        Me.bxInterval.Location = New System.Drawing.Point(246, 38)
        Me.bxInterval.Name = "bxInterval"
        Me.bxInterval.Size = New System.Drawing.Size(83, 23)
        Me.bxInterval.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Interval*"
        '
        'frmCpndInterest
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(340, 227)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bxInterval)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInterestEarned)
        Me.Controls.Add(Me.txtFutureValue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDeposits)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtInitialBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCpndInterest"
        Me.Text = "Compound Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInitialBalance As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtTerm As TextBox
    Friend WithEvents txtDeposits As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFutureValue As TextBox
    Friend WithEvents txtInterestEarned As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents bxInterval As ComboBox
    Friend WithEvents Label7 As Label
End Class
