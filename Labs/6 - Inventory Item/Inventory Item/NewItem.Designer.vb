<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_NewItem
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
        Me.textBox_ItemNo = New System.Windows.Forms.TextBox()
        Me.textBox_Description = New System.Windows.Forms.TextBox()
        Me.textBox_Price = New System.Windows.Forms.TextBox()
        Me.button_Save = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item no:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price:"
        '
        'textBox_ItemNo
        '
        Me.textBox_ItemNo.Location = New System.Drawing.Point(103, 22)
        Me.textBox_ItemNo.Name = "textBox_ItemNo"
        Me.textBox_ItemNo.Size = New System.Drawing.Size(100, 23)
        Me.textBox_ItemNo.TabIndex = 1
        '
        'textBox_Description
        '
        Me.textBox_Description.Location = New System.Drawing.Point(103, 51)
        Me.textBox_Description.Name = "textBox_Description"
        Me.textBox_Description.Size = New System.Drawing.Size(232, 23)
        Me.textBox_Description.TabIndex = 2
        '
        'textBox_Price
        '
        Me.textBox_Price.Location = New System.Drawing.Point(103, 78)
        Me.textBox_Price.Name = "textBox_Price"
        Me.textBox_Price.Size = New System.Drawing.Size(100, 23)
        Me.textBox_Price.TabIndex = 3
        '
        'button_Save
        '
        Me.button_Save.Location = New System.Drawing.Point(103, 120)
        Me.button_Save.Name = "button_Save"
        Me.button_Save.Size = New System.Drawing.Size(75, 23)
        Me.button_Save.TabIndex = 4
        Me.button_Save.Text = "&Save"
        Me.button_Save.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(260, 120)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 5
        Me.button_Cancel.Text = "&Cancel"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'form_NewItem
        '
        Me.AcceptButton = Me.button_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Cancel
        Me.ClientSize = New System.Drawing.Size(368, 162)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Save)
        Me.Controls.Add(Me.textBox_Price)
        Me.Controls.Add(Me.textBox_Description)
        Me.Controls.Add(Me.textBox_ItemNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_NewItem"
        Me.Text = "New Inventory Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textBox_ItemNo As TextBox
    Friend WithEvents textBox_Description As TextBox
    Friend WithEvents textBox_Price As TextBox
    Friend WithEvents button_Save As Button
    Friend WithEvents button_Cancel As Button
End Class
