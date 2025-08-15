Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim changeDue As Integer = txtChangeDue.Text
        Dim quarters As Integer = 0
        Dim dimes As Integer = 0
        Dim nickels As Integer = 0
        Dim pennies As Integer = 0

        quarters = Math.Floor(changeDue / 25)
        changeDue -= (quarters * 25)
        dimes = Math.Floor(changeDue / 10)
        changeDue -= (dimes * 10)
        nickels = Math.Floor(changeDue / 5)
        changeDue -= (nickels * 5)
        pennies = changeDue

        txtQuarters.Text = quarters
        txtDimes.Text = dimes
        txtNickels.Text = nickels
        txtPennies.Text = pennies

    End Sub
End Class
