Imports Microsoft.VisualBasic

Public Class DataValidation
	'Used for data validation

	'Used to make sure required textbox is filled
	Public Shared Function IsPresent(textbox As TextBox, name As String) As Boolean
		If textbox.Text = "" Then
			MessageBox.Show(name & " is a required field.", "Entry Error")
			textbox.Select()
			textbox.SelectAll()
			Return False
		End If
		Return True
	End Function

	'Check if field is an integer
	Public Shared Function IsInt32(textBox As TextBox, name As String) As Boolean
		Dim state As Boolean
		Try 'Try to convert to integer
			Convert.ToInt32(textBox.Text)
			state = True 'return true if successful
		Catch ex As FormatException 'catch error thrown
			MessageBox.Show(name & " must be an integer value.", "Entry Error")
			state = False
		Finally
			textBox.Select()
			textBox.SelectAll()
		End Try
		Return state
	End Function

	'Check if field is a Decimal
	Public Shared Function IsDecimal(textBox As TextBox, name As String) As Boolean
		Dim state As Boolean
		Try 'Try to convert to Decimal
			Convert.ToDecimal(textBox.Text)
			state = True 'return true if successful
		Catch ex As FormatException 'catch error thrown
			MessageBox.Show(name & " must be a decimal value.", "Entry Error")
			state = False
		Finally
			textBox.Select()
			textBox.SelectAll()
		End Try
		Return state
	End Function

	'Check to make sure value is within a given range (includisve)
	Public Shared Function IsWithinRange(textBox As TextBox, name As String, min As Decimal, max As Decimal) As Boolean
		Dim number As Decimal = CDec(textBox.Text) 'convert to decimal
		If number < min Or number > max Then 'check if within the given range
			MessageBox.Show(name & " must be between " & min & " and " & max & ".", "Entry Error")
			textBox.Select()
			textBox.SelectAll()
			Return False 'return false if outside of range
		End If
		Return True 'true if inside range
	End Function

	'Check if an item in the listbox is selected
	Public Shared Function IsSelected(listBox As ListBox, name As String)
		If listBox.SelectedIndex <> -1 Then 'if not -1, an item is selected
			Return True
		Else
			MessageBox.Show(name & " must be selected", "Entry Error")
			Return False
		End If
	End Function

	Public Shared Function IsNotNegative(textBox As TextBox, name As String)
		Dim number As Decimal = CDec(textBox.Text) 'convert to decimal
		If number >= 0 Then
			Return True 'return true if not negative
		Else
			MessageBox.Show(name & " must be greater than zero", "Entry Error")
			textBox.Select()
			textBox.SelectAll()
			Return False 'return false if negative
		End If
	End Function
End Class
