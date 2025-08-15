Public Class frmCustomerMaintenance

    Dim customers As List(Of Customer)

    Private Sub frmCustomerMaintenance_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        customers = CustomerDB.GetCustomers
        Me.FillCustomerListBox()
    End Sub

    Private Sub FillCustomerListBox()
        lstCustomers.Items.Clear()
        For Each c As Customer In customers
            lstCustomers.Items.Add(c.GetDisplayText)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object,
            e As EventArgs) Handles btnAdd.Click
        Dim addCustomerForm As New frmAddCustomer
        addCustomerForm.ShowDialog()
        If addCustomerForm.Customer IsNot Nothing Then
            customers.Add(addCustomerForm.Customer)
            CustomerDB.SaveCustomers(customers)
            Me.FillCustomerListBox()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object,
            e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstCustomers.SelectedIndex
        If i <> -1 Then
            Dim customer As Customer = customers(i)
            Dim message As String = "Are you sure you want to delete " &
                customer.FirstName & " " & customer.LastName & "?"
            Dim button As DialogResult = MessageBox.Show(message,
                "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                customers.Remove(customer)
                CustomerDB.SaveCustomers(customers)
                Me.FillCustomerListBox()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
