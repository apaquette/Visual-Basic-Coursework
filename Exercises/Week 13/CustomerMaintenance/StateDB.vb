Imports System.Data.SqlClient

Public Class StateDB

    Public Shared Function GetStateList() As List(Of State)
        Dim stateList As New List(Of State)
        Dim connection As SqlConnection = MMABooksDB.GetConnection
        Dim selectStatement As String =
            "SELECT StateCode, StateName " &
            "FROM States " &
            "ORDER BY StateName"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()
            Dim state As State
            Do While reader.Read
                state = New State
                state.StateCode = reader("StateCode").ToString
                state.StateName = reader("StateName").ToString
                stateList.Add(state)
            Loop
            reader.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return stateList
    End Function

End Class
