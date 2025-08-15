Public Class frmFutureValue

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        Try
            If IsValidData() Then
                Dim monthlyInvestment As Decimal = CDec(txtMonthlyInvestment.Text)
                Dim yearlyInterestRate As Decimal = CDec(txtInterestRate.Text)
                Dim years As Integer = CInt(txtYears.Text)

                Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
                Dim months As Integer = years * 12

                Dim futureValue As Decimal = Me.FutureValue(monthlyInvestment, monthlyInterestRate, months)

                txtFutureValue.Text = FormatCurrency(futureValue)
                txtMonthlyInvestment.Select()
            End If
            'Catch ex As InvalidCastException
            '    MessageBox.Show("Please check entries for valid numeric data.",
            '        ex.GetType.ToString)
            'Catch ex As OverflowException
            '    MessageBox.Show("Please check to make sure entries aren't too large.",
            '        ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.StackTrace, ex.GetType.ToString)
        End Try
    End Sub

    Private Function IsValidData() As Boolean
        Return _
            IsPresent(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsDecimal(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) AndAlso
            IsPresent(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsDecimal(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 15) AndAlso
            IsPresent(txtYears, "Number of Years") AndAlso
            IsInt32(txtYears, "Number of Years") AndAlso
            IsWithinRange(txtYears, "Number of Years", 1, 50)
    End Function

    Private Function FutureValue(monthlyInvestment As Decimal,
                monthlyInterestRate As Decimal, months As Integer) _
                As Decimal
        For i As Integer = 1 To months
            FutureValue = (FutureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
        Next
        'Throw New Exception("An unexpected error occurred.")
    End Function

    Private Sub ClearFutureValue(sender As Object,
            e As EventArgs) Handles txtMonthlyInvestment.TextChanged,
            txtYears.TextChanged, txtInterestRate.TextChanged
        txtFutureValue.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Function IsPresent(textBox As TextBox, name As String) _
         As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(name & " is a required field.", "Entry Error")
            textBox.Select()
            Return False
        End If
        Return True
    End Function

    Private Function IsDecimal(textBox As TextBox, name As String) _
            As Boolean
        Try
            Convert.ToDecimal(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(name & " must be a decimal value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try

    End Function

    Private Function IsInt32(textBox As TextBox, name As String) _
            As Boolean
        Try
            Convert.ToInt32(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(name & " must be an integer value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try
    End Function

    Private Function IsWithinRange(textBox As TextBox,
            name As String, min As Decimal,
            max As Decimal) As Boolean
        Dim number As Decimal = CDec(textBox.Text)
        If number < min Or number > max Then
            MessageBox.Show(name & " must be between " & min &
                " and " & max & ".", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
        Return True
    End Function

End Class