Public Class frmInvoiceTotal

    ' initialize the variables for using an array
    Dim index As Integer = 0
    Dim invoiceTotals(4) As Decimal

    ' initialize the List() variable
    Dim invoiceTotalsList As New List(Of Decimal)

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal

        If txtCustomerType.Text = "R" Then
            If subtotal < 100 Then
                discountPercent = 0
            ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                discountPercent = 0.1D
            ElseIf subtotal >= 250 Then
                discountPercent = 0.25D
            End If
        ElseIf txtCustomerType.Text = "C" Then
            If subtotal < 250 Then
                discountPercent = 0.2D
            Else
                discountPercent = 0.3D
            End If
        Else
            discountPercent = 0.4D
        End If

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        ' add invoice total to array
        invoiceTotals(index) = invoiceTotal
        index += 1

        ' add invoice total to list
        invoiceTotalsList.Add(invoiceTotal)

        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)

        txtCustomerType.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        ' display the message box for the array
        Array.Sort(invoiceTotals)
        Dim message As String = ""
        For Each total As Decimal In invoiceTotals
            If total <> 0D Then
                message &= total.ToString("c") & vbCrLf
            End If
        Next
        MessageBox.Show(message, "Order Totals - Array")

        ' display the message box for the list
        invoiceTotalsList.Sort()
        message = ""
        For Each total As Decimal In invoiceTotalsList
            message &= total.ToString("c") & vbCrLf
        Next
        MessageBox.Show(message, "Order Totals - List")

        Me.Close()
    End Sub

End Class