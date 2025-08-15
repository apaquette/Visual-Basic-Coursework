Public Class Form1
    'Get all records
    Private Sub btn_getAllProducts_Click(sender As Object, e As EventArgs) Handles btn_getAllProducts.Click
        Me.ProductsTableAdapter.Fill(Me.MMABooksDataSet.Products) 'fill all records from products
    End Sub

    'Save entry
    Private Sub ProductsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
    End Sub

    'get a specific record
    Private Sub btn_getProduct_Click(sender As Object, e As EventArgs) Handles btn_getProduct.Click
        Try
            Me.ProductsTableAdapter.FillByProductID(Me.MMABooksDataSet.Products, textBox_ProductCode.Text) 'select record based on product code from database
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message) 'throw exception if fail
        End Try
    End Sub
End Class
