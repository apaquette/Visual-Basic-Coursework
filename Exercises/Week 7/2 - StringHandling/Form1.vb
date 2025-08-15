Imports System.Text
Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEditPhoneNumber_Click(sender As Object, e As EventArgs) Handles btnEditPhoneNumber.Click

        'Dim phoneNumber As String = txtPhoneNumber.Text.Trim
        'Dim digitsOnly As String = phoneNumber
        'digitsOnly = digitsOnly.Replace("(", "")
        'digitsOnly = digitsOnly.Replace(")", "")
        'digitsOnly = digitsOnly.Replace(".", "")
        'digitsOnly = digitsOnly.Replace(" ", "")
        'digitsOnly = digitsOnly.Replace("-", "")

        'Dim standardFormat As String = digitsOnly
        'standardFormat = standardFormat.Insert(3, "-")
        'standardFormat = standardFormat.Insert(7, "-")
        'txtPhoneNumber.Text = standardFormat

        Dim phoneNumber As String = txtPhoneNumber.Text.Trim
        Dim digitsOnlySB As StringBuilder = New StringBuilder(phoneNumber)
        digitsOnlySB = digitsOnlySB.Replace("(", "")
        digitsOnlySB = digitsOnlySB.Replace(")", "")
        digitsOnlySB = digitsOnlySB.Replace(".", "")
        digitsOnlySB = digitsOnlySB.Replace(" ", "")
        digitsOnlySB = digitsOnlySB.Replace("-", "")
        Dim digitsOnly As String = digitsOnlySB.ToString

        Dim standardFormatSB As StringBuilder = New StringBuilder(digitsOnly)
        standardFormatSB = standardFormatSB.Insert(3, "-")
        standardFormatSB = standardFormatSB.Insert(7, "-")
        Dim standardFormat As String = standardFormatSB.ToString
        txtPhoneNumber.Text = standardFormat

        MessageBox.Show("Entered: " & vbTab & vbTab & phoneNumber & vbCrLf &
                        "Digits only: " & vbTab & digitsOnly & vbCrLf &
                        "Standard format: " & vbTab & standardFormat, "Edit Phone Number")

    End Sub


    Private Sub btnParseName_Click(sender As Object, e As EventArgs) Handles btnParseName.Click

        Dim fullName As String = txtName.Text
        Dim names As String() = fullName.Trim.Split
        Dim firstName As String = ""
        Dim middleName As String = ""
        Dim lastName As String = ""

        If names.Length = 1 Then
            firstName = names(0)
        ElseIf names.Length = 2 Then
            firstName = names(0)
            lastName = names(1)
        ElseIf names.Length = 3 Then
            firstName = names(0)
            middleName = names(1)
            lastName = names(2)
        End If

        MessageBox.Show("First name:  " & FormatName(firstName) & vbCrLf &
                        "Middle name: " & FormatName(middleName) & vbCrLf &
                        "Last name:   " & FormatName(lastName), "String Handling")
    End Sub

    Private Function FormatName(s As String) As String
        If s.Length > 0 Then
            Dim initialCap As String = s.Substring(0, 1).ToUpper
            Dim lowerCaseLetters As String = s.Substring(1).ToLower
            s = initialCap & lowerCaseLetters
        End If
        Return s
    End Function
End Class
