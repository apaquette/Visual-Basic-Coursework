<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScoreCalc
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.txtScoreCount = New System.Windows.Forms.TextBox()
        Me.txtAverageScore = New System.Windows.Forms.TextBox()
        Me.txtEnterScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(74, 151)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear Scores"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 151)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(178, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Score total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Score count:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Average:"
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(91, 49)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(58, 23)
        Me.txtTotalScore.TabIndex = 0
        Me.txtTotalScore.TabStop = False
        '
        'txtScoreCount
        '
        Me.txtScoreCount.Location = New System.Drawing.Point(91, 78)
        Me.txtScoreCount.Name = "txtScoreCount"
        Me.txtScoreCount.ReadOnly = True
        Me.txtScoreCount.Size = New System.Drawing.Size(58, 23)
        Me.txtScoreCount.TabIndex = 0
        Me.txtScoreCount.TabStop = False
        '
        'txtAverageScore
        '
        Me.txtAverageScore.Location = New System.Drawing.Point(91, 107)
        Me.txtAverageScore.Name = "txtAverageScore"
        Me.txtAverageScore.ReadOnly = True
        Me.txtAverageScore.Size = New System.Drawing.Size(58, 23)
        Me.txtAverageScore.TabIndex = 0
        Me.txtAverageScore.TabStop = False
        '
        'txtEnterScore
        '
        Me.txtEnterScore.Location = New System.Drawing.Point(91, 20)
        Me.txtEnterScore.Name = "txtEnterScore"
        Me.txtEnterScore.Size = New System.Drawing.Size(58, 23)
        Me.txtEnterScore.TabIndex = 1
        '
        'frmScoreCalc
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(272, 196)
        Me.Controls.Add(Me.txtEnterScore)
        Me.Controls.Add(Me.txtAverageScore)
        Me.Controls.Add(Me.txtScoreCount)
        Me.Controls.Add(Me.txtTotalScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "frmScoreCalc"
        Me.Text = "Score Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalScore As TextBox
    Friend WithEvents txtScoreCount As TextBox
    Friend WithEvents txtAverageScore As TextBox
    Friend WithEvents txtEnterScore As TextBox
End Class
