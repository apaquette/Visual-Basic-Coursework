Imports System.Globalization

Public Class frmFutureValue

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Try
            If IsValidData() Then
                Dim monthlyInvestment As Decimal =
                    Decimal.Parse(txtMonthlyInvestment.Text, NumberStyles.Currency)
                Dim yearlyInterestRate As Decimal =
                    Decimal.Parse(txtInterestRate.Text, NumberStyles.Number)
                Dim years As Integer = Integer.Parse(txtYears.Text, NumberStyles.None)

                Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
                Dim months As Integer = years * 12

                Dim futureValue As Decimal = Me.FutureValue(
                    monthlyInvestment, monthlyInterestRate, months)

                txtFutureValue.Text = FormatCurrency(futureValue)
                txtMonthlyInvestment.Select()
            End If
        Catch ex As OverflowException
            MessageBox.Show(
                "An overflow exception has occurred. Please enter smaller values.",
                "Entry Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf &
                ex.GetType.ToString & vbCrLf & vbCrLf &
                ex.StackTrace, "Exception")
        End Try
    End Sub

    Private Function IsValidData() As Boolean
        Return _
            IsPresent(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsCurrency(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) AndAlso
            IsPresent(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsDecimal(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 15) AndAlso
            IsPresent(txtYears, "Number of Years") AndAlso
            IsInt32(txtYears, "Number of Years") AndAlso
            IsWithinRange(txtYears, "Number of Years", 1, 50)
    End Function

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
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a decimal value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsCurrency(textBox As TextBox, name As String) _
            As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be in currency format.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If

    End Function

    Private Function IsInt32(textBox As TextBox, name As String) _
            As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, NumberStyles.None, CultureInfo.CurrentCulture, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be an integer.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsWithinRange(textBox As TextBox,
            name As String, min As Decimal,
            max As Decimal) As Boolean
        Dim number As Decimal = Decimal.Parse(textBox.Text, NumberStyles.Currency)
        If number < min Or number > max Then
            MessageBox.Show(name & " must be between " & min &
                " and " & max & ".", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
        Return True
    End Function

    Private Function FutureValue(monthlyInvestment As Decimal,
            monthlyInterestRate As Decimal, months As Integer) _
            As Decimal
        For i As Integer = 1 To months
            FutureValue = (FutureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
        Next
    End Function

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class