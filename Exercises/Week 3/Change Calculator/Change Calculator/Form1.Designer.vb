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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of change due (0-99):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quarters:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dimes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nickels:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pennies:"
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(181, 64)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.ReadOnly = True
        Me.txtQuarters.Size = New System.Drawing.Size(51, 23)
        Me.txtQuarters.TabIndex = 5
        Me.txtQuarters.TabStop = False
        '
        'txtNickels
        '
        Me.txtNickels.Location = New System.Drawing.Point(181, 136)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.ReadOnly = True
        Me.txtNickels.Size = New System.Drawing.Size(51, 23)
        Me.txtNickels.TabIndex = 6
        Me.txtNickels.TabStop = False
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(181, 100)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.ReadOnly = True
        Me.txtDimes.Size = New System.Drawing.Size(51, 23)
        Me.txtDimes.TabIndex = 7
        Me.txtDimes.TabStop = False
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(181, 172)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.ReadOnly = True
        Me.txtPennies.Size = New System.Drawing.Size(51, 23)
        Me.txtPennies.TabIndex = 8
        Me.txtPennies.TabStop = False
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Location = New System.Drawing.Point(181, 7)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.Size = New System.Drawing.Size(51, 23)
        Me.txtChangeDue.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(76, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(157, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(246, 253)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents txtNickels As TextBox
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
