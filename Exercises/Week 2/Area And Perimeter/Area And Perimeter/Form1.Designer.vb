<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaAndPerimeter
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtEnterLength = New System.Windows.Forms.TextBox()
        Me.txtEnterWidth = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtPerimeter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Area:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Perimeter:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(23, 140)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(129, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEnterLength
        '
        Me.txtEnterLength.Location = New System.Drawing.Point(104, 13)
        Me.txtEnterLength.Name = "txtEnterLength"
        Me.txtEnterLength.Size = New System.Drawing.Size(100, 23)
        Me.txtEnterLength.TabIndex = 1
        '
        'txtEnterWidth
        '
        Me.txtEnterWidth.Location = New System.Drawing.Point(104, 42)
        Me.txtEnterWidth.Name = "txtEnterWidth"
        Me.txtEnterWidth.Size = New System.Drawing.Size(100, 23)
        Me.txtEnterWidth.TabIndex = 2
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(104, 71)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(100, 23)
        Me.txtArea.TabIndex = 0
        Me.txtArea.TabStop = False
        '
        'txtPerimeter
        '
        Me.txtPerimeter.Location = New System.Drawing.Point(104, 100)
        Me.txtPerimeter.Name = "txtPerimeter"
        Me.txtPerimeter.ReadOnly = True
        Me.txtPerimeter.Size = New System.Drawing.Size(100, 23)
        Me.txtPerimeter.TabIndex = 0
        Me.txtPerimeter.TabStop = False
        '
        'frmAreaAndPerimeter
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(234, 175)
        Me.Controls.Add(Me.txtPerimeter)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtEnterWidth)
        Me.Controls.Add(Me.txtEnterLength)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAreaAndPerimeter"
        Me.Text = "Area And Perimeter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtEnterLength As TextBox
    Friend WithEvents txtEnterWidth As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtPerimeter As TextBox
End Class
