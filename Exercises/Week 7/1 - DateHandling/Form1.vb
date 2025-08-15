Public Class Form1

    Private Sub btnExit_Click(sender As Object,
        e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateDueDays_Click(sender As Object, e As EventArgs) Handles btnCalculateDueDays.Click
        If IsDate(txtFutureDate.Text) Then
            Dim futureDate As DateTime = CDate(txtFutureDate.Text)
            Dim currentDate As DateTime = DateTime.Today
            Dim ts As TimeSpan = futureDate - currentDate
            Dim daysTillDue As Integer = ts.Days
            MessageBox.Show("Current date:   " & currentDate.ToShortDateString & vbCrLf &
                          "Future date:   " & futureDate.ToShortDateString & vbCrLf & vbCrLf &
                          "Days until due: " & daysTillDue, "Due Days Calculation")
        Else
            MessageBox.Show("Entry isn't a valid date", "Entry Error")
        End If
    End Sub

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs) Handles btnCalculateAge.Click
        If IsDate(txtBirthDate.Text) Then
            Dim birthDate As DateTime = DateTime.Parse(txtBirthDate.Text)
            Dim currentDate As DateTime = DateTime.Today
            Dim age As Integer = currentDate.Year - birthDate.Year
            If birthDate.Month > currentDate.Month Then
                age -= 1
            ElseIf birthDate.Month = currentDate.Month And birthDate.Day > currentDate.Day Then
                age -= 1
            End If
            MessageBox.Show("Current date:   " & currentDate.ToShortDateString & vbCrLf &
                          "Birth date:   " & birthDate.ToShortDateString & vbCrLf & vbCrLf &
                          "Age: " & age.ToString, "Age Calculation")
        Else
            MessageBox.Show("Entry isn't a valid date", "Entry Error")
        End If
    End Sub
End Class
