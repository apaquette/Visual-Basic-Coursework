Public Class Form1

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.MMABooksDataSet.Products)

    End Sub

    Private Sub ProductsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ProductsDataGridView.DataError
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error occurred." & vbCrLf &
            "Row: " & row & vbCrLf &
            "Error: " & e.Exception.Message
        MessageBox.Show(errorMessage, "Data Error")
    End Sub

End Class
