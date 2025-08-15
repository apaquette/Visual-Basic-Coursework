Public Class Form1

    'calculate button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Temp As Double 'temp var used to check if values are numbers
        If Double.TryParse(txtNumGrade.Text, Temp) And Temp <= 100 And Temp >= 0 Then 'if parse fails, values not a number, or values not within range don't display grade
            If txtNumGrade.Text >= 90 Then
                txtLetterGrade.Text = "A+"
            ElseIf txtNumGrade.Text >= 85 Then
                txtLetterGrade.Text = "A"
            ElseIf txtNumGrade.Text >= 80 Then
                txtLetterGrade.Text = "A-"
            ElseIf txtNumGrade.Text >= 77 Then
                txtLetterGrade.Text = "B+"
            ElseIf txtNumGrade.Text >= 73 Then
                txtLetterGrade.Text = "B"
            ElseIf txtNumGrade.Text >= 70 Then
                txtLetterGrade.Text = "B-"
            ElseIf txtNumGrade.Text >= 65 Then
                txtLetterGrade.Text = "C+"
            ElseIf txtNumGrade.Text >= 60 Then
                txtLetterGrade.Text = "C"
            ElseIf txtNumGrade.Text >= 55 Then
                txtLetterGrade.Text = "D+"
            ElseIf txtNumGrade.Text >= 50 Then
                txtLetterGrade.Text = "D"
            Else
                txtLetterGrade.Text = "F"
            End If
        Else 'set Letter Grade to blank
            txtLetterGrade.Text = ""
        End If
    End Sub

    'Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
