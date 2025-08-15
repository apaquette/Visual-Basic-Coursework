Public Class frmSimpleCalculator
    'Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOpOne.Text = "" 'Clear first Operand
        txtOpTwo.Text = "" 'Clear Second Operand
        txtOperator.Text = "" 'Clear Operator
        txtResult.Text = "" 'Clear Results
    End Sub

    'Dual Argument Operations
    Private Sub dualArgs(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMult.Click, btnDiv.Click, btnModulus.Click, btnExpnt.Click, btnMax.Click, btnMin.Click
        Dim temp As Double 'temp parse variable
        If (Double.TryParse(txtOpOne.Text, temp) And Double.TryParse(txtOpTwo.Text, temp)) Then  'Only perform operations if two numbers are entered
            Dim numOne As Decimal = txtOpOne.Text 'First Num
            Dim numTwo As Decimal = txtOpTwo.Text 'Second Num

            txtOperator.Text = sender.Text  'display operator
            Select Case sender.Text 'Determine arithmetic operation
                Case "+" 'Addition
                    txtResult.Text = numOne + numTwo
                Case "-" 'Subtraction
                    txtResult.Text = numOne - numTwo
                Case "x" 'Multiplication
                    txtResult.Text = numOne * numTwo
                Case "÷" 'Division
                    txtResult.Text = numOne / numTwo
                Case "%" 'Modulus
                    txtResult.Text = numOne Mod numTwo
                Case "x^y" 'Exponents
                    txtResult.Text = numOne ^ numTwo
                Case "Min" 'Minimum
                    txtResult.Text = Math.Min(numOne, numTwo)
                Case "Max" 'Maximum
                    txtResult.Text = Math.Max(numOne, numTwo)
            End Select

        End If
    End Sub

    'Single Argument Operations
    Private Sub singleArgs(sender As Object, e As EventArgs) Handles btnSqrRt.Click, btnRound.Click
        Dim temp As Double 'Temp parse variable
        If (Double.TryParse(txtOpOne.Text, temp)) Then 'Only perform operations if the first number is entered
            Dim numOne As Decimal = txtOpOne.Text 'number to perform arithmetics
            txtOpTwo.Text = "" 'clear second operand
            Select Case sender.Text 'Determine arithmetic operation
                Case "√" 'Square Root
                    txtResult.Text = Math.Sqrt(numOne)
                Case "Round" 'Rounding
                    txtResult.Text = Math.Round(numOne, MidpointRounding.AwayFromZero)
            End Select
        End If
    End Sub
End Class