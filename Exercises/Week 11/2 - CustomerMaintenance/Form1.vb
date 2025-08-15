Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 
        'MMABooksDataSet.Customers' table.
        'You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(
            sender As Object, e As EventArgs) _
            Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Try
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
        Catch ex As DBConcurrencyException
            MessageBox.Show("A concurrency error occurred. " &
                "Some rows were not updated.", "Concurrency Error")
            Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
        Catch ex As DataException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            CustomersBindingSource.CancelEdit()
        Catch ex As SqlException
            MessageBox.Show("Database error # " & ex.Number &
                ": " & ex.Message, ex.GetType.ToString)
        End Try
    End Sub

End Class
