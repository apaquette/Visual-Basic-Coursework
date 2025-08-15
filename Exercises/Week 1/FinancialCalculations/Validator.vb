Public Class Validator
    Private Shared m_Title As String = "Entry Error"

    Public Shared Property Title()
        Get
            Return m_Title
        End Get
        Set(ByVal value)
            m_Title = value
        End Set
    End Property

    Public Shared Function IsPresent(textBox As TextBox) As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(textBox.Tag & " is a required field.", Title)
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsNumeric(textBox As TextBox) As Boolean
        If Microsoft.VisualBasic.IsNumeric(textBox.Text) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag & " must be numeric.", Title)
            textBox.Select(0, textBox.Text.Length)
            Return False
        End If
    End Function

    Public Shared Function IsInteger(textBox As TextBox) As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag & " must be an integer.", Title)
            textBox.Select(0, textBox.Text.Length)
            Return False
        End If
    End Function

    Public Shared Function IsWithinRange(textBox As TextBox,
            dMinimum As Decimal, dMaximum As Decimal) As Boolean
        Dim dNumber As Decimal = CDec(textBox.Text)
        If dNumber < dMinimum OrElse dNumber > dMaximum Then
            MessageBox.Show(textBox.Tag & " must be between " & dMinimum &
                " and " & dMaximum & ".", Title)
            textBox.Select(0, textBox.Text.Length)
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsSelected(comboBox As ComboBox) As Boolean
        If comboBox.SelectedIndex < 0 Then
            MessageBox.Show("You must select a value for " & comboBox.Tag & ".", Title)
            comboBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

End Class
