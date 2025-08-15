<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
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
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnSqrRt = New System.Windows.Forms.Button()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnExpnt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtOpTwo = New System.Windows.Forms.TextBox()
        Me.txtOpOne = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(6, 62)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 23)
        Me.btnMax.TabIndex = 2
        Me.btnMax.Text = "Max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(6, 91)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(75, 23)
        Me.btnMin.TabIndex = 3
        Me.btnMin.Text = "Min"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnSqrRt
        '
        Me.btnSqrRt.Location = New System.Drawing.Point(6, 149)
        Me.btnSqrRt.Name = "btnSqrRt"
        Me.btnSqrRt.Size = New System.Drawing.Size(75, 23)
        Me.btnSqrRt.TabIndex = 5
        Me.btnSqrRt.Text = "√"
        Me.btnSqrRt.UseVisualStyleBackColor = True
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(6, 33)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(75, 23)
        Me.btnRound.TabIndex = 1
        Me.btnRound.Text = "Round"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(87, 149)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(87, 120)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 9
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(87, 91)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 23)
        Me.btnMult.TabIndex = 8
        Me.btnMult.Text = "x"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(87, 62)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 7
        Me.btnDiv.Text = "÷"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnModulus
        '
        Me.btnModulus.Location = New System.Drawing.Point(87, 33)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(75, 23)
        Me.btnModulus.TabIndex = 6
        Me.btnModulus.Text = "%"
        Me.btnModulus.UseVisualStyleBackColor = True
        '
        'btnExpnt
        '
        Me.btnExpnt.Location = New System.Drawing.Point(6, 120)
        Me.btnExpnt.Name = "btnExpnt"
        Me.btnExpnt.Size = New System.Drawing.Size(75, 23)
        Me.btnExpnt.TabIndex = 4
        Me.btnExpnt.Text = "x^y"
        Me.btnExpnt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Operand 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Operand 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Result"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRound)
        Me.GroupBox1.Controls.Add(Me.btnMax)
        Me.GroupBox1.Controls.Add(Me.btnMin)
        Me.GroupBox1.Controls.Add(Me.btnSqrRt)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnSubtract)
        Me.GroupBox1.Controls.Add(Me.btnExpnt)
        Me.GroupBox1.Controls.Add(Me.btnMult)
        Me.GroupBox1.Controls.Add(Me.btnModulus)
        Me.GroupBox1.Controls.Add(Me.btnDiv)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 194)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operators"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOperator)
        Me.GroupBox2.Controls.Add(Me.txtResult)
        Me.GroupBox2.Controls.Add(Me.txtOpTwo)
        Me.GroupBox2.Controls.Add(Me.txtOpOne)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(185, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 194)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation"
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(105, 78)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.ReadOnly = True
        Me.txtOperator.Size = New System.Drawing.Size(44, 23)
        Me.txtOperator.TabIndex = 0
        Me.txtOperator.TabStop = False
        Me.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(77, 160)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 23)
        Me.txtResult.TabIndex = 0
        Me.txtResult.TabStop = False
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOpTwo
        '
        Me.txtOpTwo.Location = New System.Drawing.Point(77, 119)
        Me.txtOpTwo.Name = "txtOpTwo"
        Me.txtOpTwo.Size = New System.Drawing.Size(100, 23)
        Me.txtOpTwo.TabIndex = 12
        Me.txtOpTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOpOne
        '
        Me.txtOpOne.Location = New System.Drawing.Point(77, 37)
        Me.txtOpOne.Name = "txtOpOne"
        Me.txtOpOne.Size = New System.Drawing.Size(100, 23)
        Me.txtOpOne.TabIndex = 11
        Me.txtOpOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(191, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSimpleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(392, 244)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSimpleCalculator"
        Me.Text = "Simple Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnSqrRt As Button
    Friend WithEvents btnRound As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnModulus As Button
    Friend WithEvents btnExpnt As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOperator As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtOpTwo As TextBox
    Friend WithEvents txtOpOne As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
