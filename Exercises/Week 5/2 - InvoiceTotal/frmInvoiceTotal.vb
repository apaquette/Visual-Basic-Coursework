Public Class frmInvoiceTotal

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        If Not IsValidCustomerType(txtCustomerType.Text) Then
            Exit Sub
        End If

        If Not IsValidSubtotal(txtSubtotal.Text) Then
            Exit Sub
        End If

        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal

        Me.GetDiscountPercent(txtCustomerType.Text, subtotal, discountPercent)

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)

        txtCustomerType.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function IsValidSubtotal(subtotal As String) As Boolean
        If subtotal = "" Then
            MessageBox.Show("Subtotal is a required field.")
            txtSubtotal.Select()
            Return False
        End If
        Try
            Convert.ToDecimal(subtotal)
        Catch ex As FormatException
            MessageBox.Show("Subtotal must be a numeric value.")
            Return False
        End Try
        If CDec(subtotal) <= 0 Or CDec(subtotal) > 1000 Then
            MessageBox.Show("Subtotal must be greater than zero" & vbCrLf &
                            "and not greater than 1000.")
            Return False
        End If
        Return True
    End Function

    Private Function IsValidCustomerType(customerType As String) As Boolean
        If customerType = "R" Or customerType = "C" Or customerType = "T" Then
            Return True
        Else
            MessageBox.Show("Customer type must be R or C or T")
            Return False
        End If
    End Function

    Private Sub GetDiscountPercent(customerType As String, subtotal As Decimal,
                                   ByRef discountPercent As Decimal)
        If customerType = "R" Then
            If subtotal < 100 Then
                discountPercent = 0
            ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                discountPercent = 0.1D
            ElseIf subtotal >= 250 Then
                discountPercent = 0.25D
            End If
        ElseIf customerType = "C" Then
            If subtotal < 250 Then
                discountPercent = 0.2D
            Else
                discountPercent = 0.3D
            End If
        ElseIf customerType = "T" Then
            discountPercent = 0.4D
            'Else
            '    discountPercent = 0.4D
        End If
    End Sub

    Private Sub ClearResultBoxes(sender As Object,
            e As EventArgs) _
            Handles txtCustomerType.TextChanged, txtSubtotal.TextChanged
        txtDiscountPercent.Text = ""
        txtDiscountAmount.Text = ""
        txtTotal.Text = ""
    End Sub
End Class