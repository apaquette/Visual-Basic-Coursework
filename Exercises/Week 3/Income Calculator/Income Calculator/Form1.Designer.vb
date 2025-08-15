<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lablel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTaxIncome = New System.Windows.Forms.TextBox()
        Me.txtTaxOwed = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lablel1
        '
        Me.Lablel1.AutoSize = True
        Me.Lablel1.Location = New System.Drawing.Point(23, 22)
        Me.Lablel1.Name = "Lablel1"
        Me.Lablel1.Size = New System.Drawing.Size(92, 15)
        Me.Lablel1.TabIndex = 0
        Me.Lablel1.Text = "Taxable income:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Income tax owed:"
        '
        'txtTaxIncome
        '
        Me.txtTaxIncome.Location = New System.Drawing.Point(121, 19)
        Me.txtTaxIncome.Name = "txtTaxIncome"
        Me.txtTaxIncome.Size = New System.Drawing.Size(100, 23)
        Me.txtTaxIncome.TabIndex = 1
        '
        'txtTaxOwed
        '
        Me.txtTaxOwed.Location = New System.Drawing.Point(121, 51)
        Me.txtTaxOwed.Name = "txtTaxOwed"
        Me.txtTaxOwed.ReadOnly = True
        Me.txtTaxOwed.Size = New System.Drawing.Size(100, 23)
        Me.txtTaxOwed.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(66, 91)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(147, 91)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(249, 140)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTaxOwed)
        Me.Controls.Add(Me.txtTaxIncome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lablel1)
        Me.Name = "Form1"
        Me.Text = "Income Tax Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lablel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTaxIncome As TextBox
    Friend WithEvents txtTaxOwed As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
