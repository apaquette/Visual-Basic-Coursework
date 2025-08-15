Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)
        'Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
        StateComboBox.SelectedIndex = -1
    End Sub

    Private Sub FillByCustomerIDToolStripButton_Click(
            sender As Object, e As EventArgs) _
            Handles FillByCustomerIDToolStripButton.Click
        Try
            Me.CustomersTableAdapter.FillByCustomerID(
                Me.MMABooksDataSet.Customers,
                CType(CustomerIDToolStripTextBox.Text, Integer))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorCancelItem_Click(
            sender As Object, e As EventArgs) _
            Handles BindingNavigatorCancelItem.Click
        CustomersBindingSource.CancelEdit()
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(
            sender As Object, e As EventArgs) _
            Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object,
            e As EventArgs) Handles FillToolStripButton.Click
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
    End Sub

    Private Sub FillByStateToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StateToolStripButton1_Click(sender As Object, e As EventArgs) Handles StateToolStripButton1.Click
        Try
            Me.CustomersTableAdapter.FillByState(Me.MMABooksDataSet.Customers, StateToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
