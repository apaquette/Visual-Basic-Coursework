<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LunchOrder
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
        Me.groupBox_mainCourse = New System.Windows.Forms.GroupBox()
        Me.radioButton_Salad = New System.Windows.Forms.RadioButton()
        Me.radioButton_Pizza = New System.Windows.Forms.RadioButton()
        Me.radioButton_Burger = New System.Windows.Forms.RadioButton()
        Me.groupBox_addOns = New System.Windows.Forms.GroupBox()
        Me.checkBox_Fries = New System.Windows.Forms.CheckBox()
        Me.checkBox_KMM = New System.Windows.Forms.CheckBox()
        Me.checkBox_LTO = New System.Windows.Forms.CheckBox()
        Me.groupBox_orderTotal = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBox_Total = New System.Windows.Forms.TextBox()
        Me.textBox_Tax = New System.Windows.Forms.TextBox()
        Me.textBox_Subtotal = New System.Windows.Forms.TextBox()
        Me.button_PlaceOrder = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.groupBox_mainCourse.SuspendLayout()
        Me.groupBox_addOns.SuspendLayout()
        Me.groupBox_orderTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox_mainCourse
        '
        Me.groupBox_mainCourse.Controls.Add(Me.radioButton_Salad)
        Me.groupBox_mainCourse.Controls.Add(Me.radioButton_Pizza)
        Me.groupBox_mainCourse.Controls.Add(Me.radioButton_Burger)
        Me.groupBox_mainCourse.Location = New System.Drawing.Point(12, 12)
        Me.groupBox_mainCourse.Name = "groupBox_mainCourse"
        Me.groupBox_mainCourse.Size = New System.Drawing.Size(144, 100)
        Me.groupBox_mainCourse.TabIndex = 1
        Me.groupBox_mainCourse.TabStop = False
        Me.groupBox_mainCourse.Text = "Main course"
        '
        'radioButton_Salad
        '
        Me.radioButton_Salad.AutoSize = True
        Me.radioButton_Salad.Location = New System.Drawing.Point(6, 72)
        Me.radioButton_Salad.Name = "radioButton_Salad"
        Me.radioButton_Salad.Size = New System.Drawing.Size(91, 19)
        Me.radioButton_Salad.TabIndex = 2
        Me.radioButton_Salad.TabStop = True
        Me.radioButton_Salad.Text = "Salad - $4.95"
        Me.radioButton_Salad.UseVisualStyleBackColor = True
        '
        'radioButton_Pizza
        '
        Me.radioButton_Pizza.AutoSize = True
        Me.radioButton_Pizza.Location = New System.Drawing.Point(6, 47)
        Me.radioButton_Pizza.Name = "radioButton_Pizza"
        Me.radioButton_Pizza.Size = New System.Drawing.Size(89, 19)
        Me.radioButton_Pizza.TabIndex = 1
        Me.radioButton_Pizza.TabStop = True
        Me.radioButton_Pizza.Text = "Pizza - $5.95"
        Me.radioButton_Pizza.UseVisualStyleBackColor = True
        '
        'radioButton_Burger
        '
        Me.radioButton_Burger.AutoSize = True
        Me.radioButton_Burger.Location = New System.Drawing.Point(6, 22)
        Me.radioButton_Burger.Name = "radioButton_Burger"
        Me.radioButton_Burger.Size = New System.Drawing.Size(124, 19)
        Me.radioButton_Burger.TabIndex = 0
        Me.radioButton_Burger.TabStop = True
        Me.radioButton_Burger.Text = "Hamburger - $6.95"
        Me.radioButton_Burger.UseVisualStyleBackColor = True
        '
        'groupBox_addOns
        '
        Me.groupBox_addOns.Controls.Add(Me.checkBox_Fries)
        Me.groupBox_addOns.Controls.Add(Me.checkBox_KMM)
        Me.groupBox_addOns.Controls.Add(Me.checkBox_LTO)
        Me.groupBox_addOns.Location = New System.Drawing.Point(12, 118)
        Me.groupBox_addOns.Name = "groupBox_addOns"
        Me.groupBox_addOns.Size = New System.Drawing.Size(200, 100)
        Me.groupBox_addOns.TabIndex = 2
        Me.groupBox_addOns.TabStop = False
        Me.groupBox_addOns.Text = "Add-on items ($.75/each)"
        '
        'checkBox_Fries
        '
        Me.checkBox_Fries.AutoSize = True
        Me.checkBox_Fries.Location = New System.Drawing.Point(6, 72)
        Me.checkBox_Fries.Name = "checkBox_Fries"
        Me.checkBox_Fries.Size = New System.Drawing.Size(87, 19)
        Me.checkBox_Fries.TabIndex = 2
        Me.checkBox_Fries.Text = "French fries"
        Me.checkBox_Fries.UseVisualStyleBackColor = True
        '
        'checkBox_KMM
        '
        Me.checkBox_KMM.AutoSize = True
        Me.checkBox_KMM.Location = New System.Drawing.Point(6, 47)
        Me.checkBox_KMM.Name = "checkBox_KMM"
        Me.checkBox_KMM.Size = New System.Drawing.Size(179, 19)
        Me.checkBox_KMM.TabIndex = 1
        Me.checkBox_KMM.Text = "Ketchup, mustard, and mayo"
        Me.checkBox_KMM.UseVisualStyleBackColor = True
        '
        'checkBox_LTO
        '
        Me.checkBox_LTO.AutoSize = True
        Me.checkBox_LTO.Location = New System.Drawing.Point(6, 22)
        Me.checkBox_LTO.Name = "checkBox_LTO"
        Me.checkBox_LTO.Size = New System.Drawing.Size(175, 19)
        Me.checkBox_LTO.TabIndex = 0
        Me.checkBox_LTO.Text = "Lettuce, tomato, and onions"
        Me.checkBox_LTO.UseVisualStyleBackColor = True
        '
        'groupBox_orderTotal
        '
        Me.groupBox_orderTotal.Controls.Add(Me.Label3)
        Me.groupBox_orderTotal.Controls.Add(Me.Label2)
        Me.groupBox_orderTotal.Controls.Add(Me.Label1)
        Me.groupBox_orderTotal.Controls.Add(Me.textBox_Total)
        Me.groupBox_orderTotal.Controls.Add(Me.textBox_Tax)
        Me.groupBox_orderTotal.Controls.Add(Me.textBox_Subtotal)
        Me.groupBox_orderTotal.Location = New System.Drawing.Point(12, 224)
        Me.groupBox_orderTotal.Name = "groupBox_orderTotal"
        Me.groupBox_orderTotal.Size = New System.Drawing.Size(200, 110)
        Me.groupBox_orderTotal.TabIndex = 0
        Me.groupBox_orderTotal.TabStop = False
        Me.groupBox_orderTotal.Text = "Order Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tax (7.75%)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subtotal:"
        '
        'textBox_Total
        '
        Me.textBox_Total.Location = New System.Drawing.Point(94, 78)
        Me.textBox_Total.Name = "textBox_Total"
        Me.textBox_Total.ReadOnly = True
        Me.textBox_Total.Size = New System.Drawing.Size(100, 23)
        Me.textBox_Total.TabIndex = 2
        Me.textBox_Total.TabStop = False
        '
        'textBox_Tax
        '
        Me.textBox_Tax.Location = New System.Drawing.Point(94, 49)
        Me.textBox_Tax.Name = "textBox_Tax"
        Me.textBox_Tax.ReadOnly = True
        Me.textBox_Tax.Size = New System.Drawing.Size(100, 23)
        Me.textBox_Tax.TabIndex = 1
        Me.textBox_Tax.TabStop = False
        '
        'textBox_Subtotal
        '
        Me.textBox_Subtotal.Location = New System.Drawing.Point(94, 20)
        Me.textBox_Subtotal.Name = "textBox_Subtotal"
        Me.textBox_Subtotal.ReadOnly = True
        Me.textBox_Subtotal.Size = New System.Drawing.Size(100, 23)
        Me.textBox_Subtotal.TabIndex = 0
        Me.textBox_Subtotal.TabStop = False
        '
        'button_PlaceOrder
        '
        Me.button_PlaceOrder.Location = New System.Drawing.Point(12, 340)
        Me.button_PlaceOrder.Name = "button_PlaceOrder"
        Me.button_PlaceOrder.Size = New System.Drawing.Size(92, 23)
        Me.button_PlaceOrder.TabIndex = 3
        Me.button_PlaceOrder.Text = "Place Order"
        Me.button_PlaceOrder.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(137, 340)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.button_Exit.TabIndex = 4
        Me.button_Exit.Text = "E&xit"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'LunchOrder
        '
        Me.AcceptButton = Me.button_PlaceOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(238, 374)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_PlaceOrder)
        Me.Controls.Add(Me.groupBox_orderTotal)
        Me.Controls.Add(Me.groupBox_addOns)
        Me.Controls.Add(Me.groupBox_mainCourse)
        Me.Name = "LunchOrder"
        Me.Text = "Lunch Order"
        Me.groupBox_mainCourse.ResumeLayout(False)
        Me.groupBox_mainCourse.PerformLayout()
        Me.groupBox_addOns.ResumeLayout(False)
        Me.groupBox_addOns.PerformLayout()
        Me.groupBox_orderTotal.ResumeLayout(False)
        Me.groupBox_orderTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox_mainCourse As GroupBox
    Friend WithEvents radioButton_Salad As RadioButton
    Friend WithEvents radioButton_Pizza As RadioButton
    Friend WithEvents radioButton_Burger As RadioButton
    Friend WithEvents groupBox_addOns As GroupBox
    Friend WithEvents groupBox_orderTotal As GroupBox
    Friend WithEvents checkBox_Fries As CheckBox
    Friend WithEvents checkBox_KMM As CheckBox
    Friend WithEvents checkBox_LTO As CheckBox
    Friend WithEvents button_PlaceOrder As Button
    Friend WithEvents button_Exit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textBox_Total As TextBox
    Friend WithEvents textBox_Tax As TextBox
    Friend WithEvents textBox_Subtotal As TextBox
End Class
