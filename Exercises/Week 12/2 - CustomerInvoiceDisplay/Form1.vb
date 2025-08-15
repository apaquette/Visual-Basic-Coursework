Imports System.Data.SqlClient

Public Class Form1

    Private Sub FillByCustomerIDToolStripButton_Click(
            sender As Object, e As EventArgs) _
            Handles FillByCustomerIDToolStripButton.Click
        Try
            Dim customerID As Integer = Convert.ToInt32(CustomerIDToolStripTextBox.Text)
            Me.CustomersTableAdapter.FillByCustomerID(
                Me.MMABooksDataSet.Customers, customerID)
            Me.InvoicesTableAdapter.FillByCustomerID(
                Me.MMABooksDataSet.Invoices, customerID)
        Catch ex As FormatException
            MessageBox.Show("Customer ID must be an integer.", "Entry Error")
        Catch ex As SqlException
            MessageBox.Show("SQL Server error # " & ex.Number &
                ": " & ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub InvoicesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles InvoicesDataGridView.CellContentClick

    End Sub
End Class
