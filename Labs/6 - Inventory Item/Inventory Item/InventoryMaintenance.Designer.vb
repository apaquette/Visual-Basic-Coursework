<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_InventoryMaintenance
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
        Me.listBox_Items = New System.Windows.Forms.ListBox()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.button_Delete = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox_Items
        '
        Me.listBox_Items.FormattingEnabled = True
        Me.listBox_Items.ItemHeight = 15
        Me.listBox_Items.Location = New System.Drawing.Point(12, 12)
        Me.listBox_Items.Name = "listBox_Items"
        Me.listBox_Items.Size = New System.Drawing.Size(403, 229)
        Me.listBox_Items.TabIndex = 1
        '
        'button_Add
        '
        Me.button_Add.Location = New System.Drawing.Point(421, 12)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(107, 23)
        Me.button_Add.TabIndex = 2
        Me.button_Add.Text = "&Add item..."
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'button_Delete
        '
        Me.button_Delete.Location = New System.Drawing.Point(421, 41)
        Me.button_Delete.Name = "button_Delete"
        Me.button_Delete.Size = New System.Drawing.Size(107, 23)
        Me.button_Delete.TabIndex = 3
        Me.button_Delete.Text = "&Delete item..."
        Me.button_Delete.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(421, 70)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(107, 23)
        Me.button_Exit.TabIndex = 4
        Me.button_Exit.Text = "E&xit"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'form_InventoryMaintenance
        '
        Me.AcceptButton = Me.button_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(538, 257)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_Delete)
        Me.Controls.Add(Me.button_Add)
        Me.Controls.Add(Me.listBox_Items)
        Me.Name = "form_InventoryMaintenance"
        Me.Text = "InventoryMaintenance"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBox_Items As ListBox
    Friend WithEvents button_Add As Button
    Friend WithEvents button_Delete As Button
    Friend WithEvents button_Exit As Button
End Class
