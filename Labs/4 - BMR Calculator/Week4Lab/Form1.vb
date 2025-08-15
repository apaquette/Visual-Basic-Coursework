Public Class Form1
	'Calculates the BMR based on a given age, height, weight, gender, and optionally body fat percentage
	Private Function Calculate_BMR(age As Integer, height As Integer, weight As Decimal, genderConst As Integer, Optional bodyFat As Decimal = 0.0) As Integer
		Dim BMR As Integer
		If bodyFat = 0 Then 'If the body fat is zero, use formula without bodyfat
			BMR = 10 * weight + 6.25 * height - 5 * age + genderConst
		Else 'use formula with bodyfat
			BMR = 370 + 21.6 * (1 - bodyFat) * weight
		End If

		Return BMR
	End Function

	'converts a value to percentile decimal
	Private Function convertToPercent(num As Integer)
		Return num / 100 'divide by 100 and return the result
	End Function

	'Changes the gender constant based on the selection
	Private Sub toggleGender(ByRef genderConst)
		If radioMale.Checked Then
			genderConst = 5
		Else
			genderConst = -161
		End If
	End Sub

	'Empty the total when additional values are changed or entered
	Private Sub reset() Handles txtAge.TextChanged, txtHeight.TextChanged, txtWeight.TextChanged, txtBodyFat.TextChanged, radioFemale.CheckedChanged, radioMale.CheckedChanged
		txtTotal.Text = ""
	End Sub

	'Check that the values entered are numbers
	Private Sub checkNums(sender As Object, e As EventArgs) Handles txtAge.KeyUp, txtBodyFat.KeyUp, txtHeight.KeyUp, txtWeight.KeyUp
		If Not IsNumeric(sender.Text) Then
			sender.Text = ""
		End If
	End Sub

	'calculate the BMR
	Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalculate.Click
		Dim genderConst As Integer
		toggleGender(genderConst) 'set the gender constant
		If txtBodyFat.Text = "" Then 'if bodyfat is empty, call function without bodyfat
			txtTotal.Text = Calculate_BMR(txtAge.Text, txtHeight.Text, txtWeight.Text, genderConst)
		Else
			Dim bodyFat As Decimal = convertToPercent(bodyFat) 'convert bodyfat to percentile decimal
			txtTotal.Text = Calculate_BMR(txtAge.Text, txtHeight.Text, txtWeight.Text, genderConst, bodyFat) 'calculate bmr
		End If

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class
