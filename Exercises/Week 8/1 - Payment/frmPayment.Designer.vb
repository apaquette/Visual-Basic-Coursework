<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCreditCardType = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.cboExpirationYear = New System.Windows.Forms.ComboBox()
        Me.cboExpirationMonth = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoBillCustomer = New System.Windows.Forms.RadioButton()
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCreditCardType
        '
        Me.lstCreditCardType.FormattingEnabled = True
        Me.lstCreditCardType.Location = New System.Drawing.Point(118, 81)
        Me.lstCreditCardType.Name = "lstCreditCardType"
        Me.lstCreditCardType.Size = New System.Drawing.Size(216, 69)
        Me.lstCreditCardType.TabIndex = 19
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(259, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(169, 272)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "&OK"
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.Checked = True
        Me.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefault.Location = New System.Drawing.Point(14, 233)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(158, 17)
        Me.chkDefault.TabIndex = 26
        Me.chkDefault.Text = "Set as default billing method"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(118, 161)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(216, 20)
        Me.txtCardNumber.TabIndex = 20
        Me.txtCardNumber.Text = "1111390008727492"
        '
        'cboExpirationYear
        '
        Me.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationYear.FormattingEnabled = True
        Me.cboExpirationYear.Location = New System.Drawing.Point(237, 193)
        Me.cboExpirationYear.Name = "cboExpirationYear"
        Me.cboExpirationYear.Size = New System.Drawing.Size(97, 21)
        Me.cboExpirationYear.TabIndex = 25
        '
        'cboExpirationMonth
        '
        Me.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationMonth.FormattingEnabled = True
        Me.cboExpirationMonth.Location = New System.Drawing.Point(118, 193)
        Me.cboExpirationMonth.Name = "cboExpirationMonth"
        Me.cboExpirationMonth.Size = New System.Drawing.Size(104, 21)
        Me.cboExpirationMonth.TabIndex = 22
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 196)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Expiration date:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 164)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 13)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Card number:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 81)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 13)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Credit card type:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rdoBillCustomer)
        Me.groupBox1.Controls.Add(Me.rdoCreditCard)
        Me.groupBox1.Location = New System.Drawing.Point(14, 9)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(320, 56)
        Me.groupBox1.TabIndex = 29
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Billing"
        '
        'rdoBillCustomer
        '
        Me.rdoBillCustomer.AutoSize = True
        Me.rdoBillCustomer.Location = New System.Drawing.Point(179, 24)
        Me.rdoBillCustomer.Name = "rdoBillCustomer"
        Me.rdoBillCustomer.Size = New System.Drawing.Size(84, 17)
        Me.rdoBillCustomer.TabIndex = 1
        Me.rdoBillCustomer.Text = "Bill customer"
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.AutoSize = True
        Me.rdoCreditCard.Checked = True
        Me.rdoCreditCard.Location = New System.Drawing.Point(16, 24)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(76, 17)
        Me.rdoCreditCard.TabIndex = 0
        Me.rdoCreditCard.TabStop = True
        Me.rdoCreditCard.Text = "Credit card"
        '
        'frmPayment
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(353, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstCreditCardType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.cboExpirationYear)
        Me.Controls.Add(Me.cboExpirationMonth)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.Text = "Payment"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lstCreditCardType As System.Windows.Forms.ListBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents chkDefault As System.Windows.Forms.CheckBox
    Private WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Private WithEvents cboExpirationYear As System.Windows.Forms.ComboBox
    Private WithEvents cboExpirationMonth As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rdoBillCustomer As System.Windows.Forms.RadioButton
    Private WithEvents rdoCreditCard As System.Windows.Forms.RadioButton
End Class
