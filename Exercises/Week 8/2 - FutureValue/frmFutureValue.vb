Public Class frmFutureValue

    Private Sub frmFutureValue_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        For counter As Integer = 1 To 20
            cboYears.Items.Add(counter)
        Next
        cboYears.SelectedIndex = 2
    End Sub

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Try
            If IsValidData() Then
                Dim monthlyInvestment As Decimal =
                    Convert.ToDecimal(txtMonthlyInvestment.Text)
                Dim yearlyInterestRate As Decimal =
                    Convert.ToDecimal(txtInterestRate.Text)
                Dim years As Integer = Convert.ToInt32(cboYears.SelectedItem)

                Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
                Dim months As Integer = years * 12

                Dim futureValue As Decimal = Me.FutureValue(
                    monthlyInvestment, monthlyInterestRate, months)

                lstFutureValue.Text = FormatCurrency(futureValue)
                txtMonthlyInvestment.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf &
                ex.GetType.ToString & vbCrLf & vbCrLf &
                ex.StackTrace, "Exception")
        End Try
    End Sub

    Private Function IsValidData() As Boolean
        Return _
            IsPresent(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsDecimal(txtMonthlyInvestment, "Monthly Investment") AndAlso
            IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) AndAlso
            IsPresent(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsDecimal(txtInterestRate, "Yearly Interest Rate") AndAlso
            IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 15)
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
        If Decimal.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a decimal value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If

    End Function

    Private Function IsInt32(textBox As TextBox, name As String) _
            As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be an integer value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
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

    Private Function FutureValue(monthlyInvestment As Decimal,
            monthlyInterestRate As Decimal, months As Integer) _
            As Decimal
        lstFutureValue.Items.Clear()
        For i As Integer = 1 To months
            FutureValue = (FutureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
            If i Mod 12 = 0 Then
                lstFutureValue.Items.Add("Year " & CStr(i / 12) & ": " & FormatCurrency(FutureValue))
            End If
        Next
    End Function

    Private Sub ClearFutureValue(sender As Object,
            e As EventArgs) Handles txtMonthlyInvestment.TextChanged,
             txtInterestRate.TextChanged, cboYears.SelectedIndexChanged
        lstFutureValue.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class