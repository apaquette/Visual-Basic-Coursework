Public Class frmAreaAndPerimeter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim length As Decimal = txtEnterLength.Text
        Dim width As Decimal = txtEnterWidth.Text
        txtPerimeter.Text = 2 * width + 2 * length
        txtArea.Text = width * length
    End Sub
End Class
