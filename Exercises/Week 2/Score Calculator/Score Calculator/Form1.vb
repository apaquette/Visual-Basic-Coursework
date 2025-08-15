Public Class frmScoreCalc
    'globala variables
    Dim totalScore As Integer = 0
    Dim scoreCount As Integer = 0
    Dim scoreAverage As Decimal = 0.0

    'text boxes
    Public Function updateForm()
        txtTotalScore.Text = totalScore
        txtAverageScore.Text = scoreAverage
        txtScoreCount.Text = scoreCount

        Return Nothing
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'calculations
        totalScore += txtEnterScore.Text
        scoreCount += 1
        scoreAverage = totalScore / scoreCount

        updateForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        totalScore = 0
        scoreCount = 0
        scoreAverage = 0.0

        updateForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
