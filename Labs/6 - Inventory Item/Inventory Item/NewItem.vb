Public Class form_NewItem
    'close form without changes
    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    'apply changes and close form
    Private Sub button_Save_Click(sender As Object, e As EventArgs) Handles button_Save.Click
        'check that all data entered is valid
        If (IsValidItemNumber(textBox_ItemNo) AndAlso IsValidDescription(textBox_Description) AndAlso IsValidPrice(textBox_Price)) Then
            'assign values
            Dim item As New InventoryItems
            item.Number = textBox_ItemNo.Text
            item.Description = textBox_Description.Text
            item.Price = textBox_Price.Text

            form_InventoryMaintenance.items.Add(item) 'add to public items list
            form_InventoryMaintenance.listItems() 'update listed items
            Me.Close()
        End If
    End Sub

    'checks if item number textbox is valid
    Private Function IsValidItemNumber(textBox As TextBox) As Boolean
        Return _
            DataValidation.IsPresent(textBox, "Item Number") AndAlso
            DataValidation.IsInt32(textBox, "Item Number") AndAlso
            DataValidation.IsNotNegative(textBox, "Item Number")
    End Function
    'checks if price textbox is valid
    Private Function IsValidPrice(textBox As TextBox) As Boolean
        Return _
            DataValidation.IsPresent(textBox, "Price") AndAlso
            DataValidation.IsDecimal(textBox, "Price") AndAlso
            DataValidation.IsNotNegative(textBox, "Price")
    End Function
    'checks if description textbox is valid
    Private Function IsValidDescription(textBox As TextBox) As Boolean
        Return _
            DataValidation.IsPresent(textBox, "Item Description")
    End Function

End Class