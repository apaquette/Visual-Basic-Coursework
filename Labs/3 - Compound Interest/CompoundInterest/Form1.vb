Public Class frmCpndInterest
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dummy As Double
        'Ensures bare requirements are filled
        If (Double.TryParse(txtTerm.Text, dummy) AndAlso Double.TryParse(txtInterestRate.Text, dummy) AndAlso bxInterval.Text IsNot "") Then
            Dim deposits As Decimal = If(Decimal.TryParse(txtDeposits.Text, deposits), txtDeposits.Text, 0) 'if empty, set to zero
            Dim futureValue As Decimal = If(Decimal.TryParse(txtInitialBalance.Text, futureValue), txtInitialBalance.Text, 0) 'if empty, set to zero
            Dim interestEarned As Decimal = 0
            Dim rate As Decimal = (txtInterestRate.Text / 100.0)    'convert interest rate to decimal number
            Dim term As Integer

            'Determin the term length by month and multiply deposit by same amount
            Select Case bxInterval.Text
                Case "Monthly"
                    term = txtTerm.Text * 12
                    rate /= 12
                Case "Bi-Monthly"
                    term = txtTerm.Text * 6
                    rate /= 6
                    deposits *= 2
                Case "Quarterly"
                    term = txtTerm.Text * 4
                    rate /= 4
                    deposits *= 4
                Case "Half-Yearly"
                    term = txtTerm.Text * 2
                    rate /= 2
                    deposits *= 6
                Case "Yearly"
                    term = txtTerm.Text
                    deposits *= 12
            End Select

            'Each loops applies the accrued interest
            For i As Integer = 1 To term
                futureValue += deposits
                interestEarned += Math.Round((futureValue * rate), 2)
                futureValue += Math.Round((futureValue * rate), 2)
            Next

            txtFutureValue.Text = FormatCurrency(futureValue, 2)
            txtInterestEarned.Text = FormatCurrency(interestEarned, 2)
        Else
            txtFutureValue.Text = ""
            txtInterestEarned.Text = ""
        End If
    End Sub
End Class
