Public Class form_InventoryMaintenance
    Public items As New List(Of InventoryItems) 'Public list for items

    'Shared list item sub to list all items from public list in ListBox
    Public Shared Sub listItems()
        form_InventoryMaintenance.listBox_Items.Items.Clear() 'clear listBox

        For x As Integer = 0 To form_InventoryMaintenance.items.Count - 1
            form_InventoryMaintenance.listBox_Items.Items.Add(formatItemText(form_InventoryMaintenance.items(x))) 'list each item in the list formated
        Next

    End Sub

    'format text  for each item
    Public Shared Function formatItemText(item As InventoryItems) As String
        Dim text As String = item.Number & vbTab & item.Description & " ($" & item.Price & ")"
        Return text
    End Function

    'close form
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    'open New Item form
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        form_NewItem.Show()
    End Sub

    'Delete a selected item
    Private Sub button_Delete_Click(sender As Object, e As EventArgs) Handles button_Delete.Click
        If listBox_Items.SelectedIndex <> -1 Then 'ensures an item is selected
            Dim item As InventoryItems = items(listBox_Items.SelectedIndex) 'retrieve selected item
            Dim message As String = "Are you sure you want to delete " & item.Description & "?" 'generate warning message
            Dim button As DialogResult = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then 'if user said yes, proceed with deleting item
                items.RemoveAt(listBox_Items.SelectedIndex)
                listItems() 're-list items
            End If
        End If
    End Sub

    Private Sub form_InventoryMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class