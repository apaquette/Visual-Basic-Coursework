Public Class LunchOrder
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    Private Sub button_PlaceOrder_Click(sender As Object, e As EventArgs) Handles button_PlaceOrder.Click
        Dim tax = 0.0775    'set tax rate
        Dim subtotal = 0.0  'set to zero

        'Main Course Selection
        Dim mainCourse As RadioButton = groupBox_mainCourse.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True) 'get name of selected main course
        Select Case (mainCourse.Name) 'check which main course is selected
            Case "radioButton_Burger"
                subtotal = 6.95
            Case "radioButton_Pizza"
                subtotal = 5.95
            Case "radioButton_Salad"
                subtotal = 4.95
        End Select

        'Add-ons
        For Each box As Object In groupBox_addOns.Controls  'for each item in add-ons groupbox
            If (box.Checked) Then 'check if it is checked
                subtotal += 0.75 'add fee for add-on
            End If
        Next

        'Final Output
        textBox_Subtotal.Text = FormatCurrency(subtotal)
        textBox_Tax.Text = FormatCurrency(subtotal * tax)
        textBox_Total.Text = FormatCurrency(subtotal + (subtotal * tax))
    End Sub
End Class
