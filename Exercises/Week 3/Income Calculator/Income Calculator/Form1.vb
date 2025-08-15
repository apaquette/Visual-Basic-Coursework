Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim income As Decimal = txtTaxIncome.Text
        Dim taxOwed As Decimal = 0

        If income <= 50197 Then
            taxOwed = income * 0.15D
        ElseIf income > 50197 AndAlso income <= 100392 Then
            taxOwed = (50197 * 0.15D) + ((income - 50197) * 0.205D)
        ElseIf income > 100392 AndAlso income <= 155625 Then
            taxOwed = (50197 * 0.15D) + (50195 * 0.205D) + ((income - 100392) * 0.26D)
        ElseIf income > 155625 AndAlso income <= 221708 Then
            taxOwed = (50197 * 0.15D) + (50195 * 0.205D) + (55233 * 0.26D) + ((income - 155625) * 0.29D)
        ElseIf income > 221708 Then
            taxOwed = (50197 * 0.15D) + (50195 * 0.205D) + (55233 * 0.26D) + (66083 * 0.29D) + ((income - 221708) * 0.33D)
        End If

        txtTaxOwed.Text = Math.Round(taxOwed, 2)
    End Sub
End Class
