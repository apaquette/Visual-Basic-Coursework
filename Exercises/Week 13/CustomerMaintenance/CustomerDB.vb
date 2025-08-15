Imports System.Data.SqlClient

Public Class CustomerDB

    Public Shared Function GetCustomer(customerID As Integer) As Customer
        Dim customer As New Customer
        Dim connection As SqlConnection = MMABooksDB.GetConnection
        Dim selectStatement As String =
            "SELECT CustomerID, Name, Address, City, State, ZipCode " &
            "FROM Customers " &
            "WHERE CustomerID = @CustomerID"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@CustomerID", customerID)
        Try
            connection.Open()
            Dim reader As SqlDataReader =
                selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                customer.CustomerID = CInt(reader("CustomerID"))
                customer.Name = reader("Name").ToString
                customer.Address = reader("Address").ToString
                customer.City = reader("City").ToString
                customer.State = reader("State").ToString
                customer.ZipCode = reader("ZipCode").ToString
            Else
                customer = Nothing
            End If
            reader.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customer
    End Function

    Public Shared Function AddCustomer(customer As Customer) As Integer
        Dim connection As SqlConnection = MMABooksDB.GetConnection
        Dim insertStatement As String =
            "INSERT Customers " &
            "(Name, Address, City, State, ZipCode) " &
            "VALUES (@Name, @Address, @City, @State, @ZipCode)"
        Dim insertCommand As New SqlCommand(insertStatement, connection)
        insertCommand.Parameters.AddWithValue("@Name", customer.Name)
        insertCommand.Parameters.AddWithValue("@Address", customer.Address)
        insertCommand.Parameters.AddWithValue("@City", customer.City)
        insertCommand.Parameters.AddWithValue("@State", customer.State)
        insertCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode)
        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()
            Dim selectStatement As String =
                "SELECT IDENT_CURRENT('Customers') FROM Customers"
            Dim selectCommand As New SqlCommand(selectStatement, connection)
            Dim customerID As Integer = CInt(selectCommand.ExecuteScalar)
            Return customerID
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function UpdateCustomer(oldCustomer As Customer,
            newCustomer As Customer) As Boolean
        Dim connection As SqlConnection = MMABooksDB.GetConnection()
        Dim updateStatement As String =
            "UPDATE Customers SET " &
            "Name = @NewName, " &
            "Address = @NewAddress, " &
            "City = @NewCity, " &
            "State = @NewState, " &
            "ZipCode = @NewZipCode " &
            "WHERE CustomerID = @OldCustomerID " &
            "AND Name = @OldName " &
            "AND Address = @OldAddress " &
            "AND City = @OldCity " &
            "AND State = @OldState " &
            "AND ZipCode = @OldZipCode "
        Dim updateCommand As New SqlCommand(updateStatement, connection)
        updateCommand.Parameters.AddWithValue("@NewName", newCustomer.Name)
        updateCommand.Parameters.AddWithValue("@NewAddress", newCustomer.Address)
        updateCommand.Parameters.AddWithValue("@NewCity", newCustomer.City)
        updateCommand.Parameters.AddWithValue("@NewState", newCustomer.State)
        updateCommand.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode)
        updateCommand.Parameters.AddWithValue("@OldCustomerID", oldCustomer.CustomerID)
        updateCommand.Parameters.AddWithValue("@OldName", oldCustomer.Name)
        updateCommand.Parameters.AddWithValue("@OldAddress", oldCustomer.Address)
        updateCommand.Parameters.AddWithValue("@OldCity", oldCustomer.City)
        updateCommand.Parameters.AddWithValue("@OldState", oldCustomer.State)
        updateCommand.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode)

        Try
            connection.Open()
            Dim count As Integer = updateCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function DeleteCustomer(customer As Customer) As Boolean
        Dim connection As SqlConnection = MMABooksDB.GetConnection()
        Dim deleteStatement As String =
            "DELETE FROM Customers " &
            "WHERE CustomerID = @CustomerID " &
            "AND Name = @Name " &
            "AND Address = @Address " &
            "AND City = @City " &
            "AND State = @State " &
            "AND ZipCode = @ZipCode"
        Dim deleteCommand As New SqlCommand(deleteStatement, connection)
        deleteCommand.Parameters.AddWithValue("@CustomerID", customer.CustomerID)
        deleteCommand.Parameters.AddWithValue("@Name", customer.Name)
        deleteCommand.Parameters.AddWithValue("@Address", customer.Address)
        deleteCommand.Parameters.AddWithValue("@City", customer.City)
        deleteCommand.Parameters.AddWithValue("@State", customer.State)
        deleteCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode)

        Try
            connection.Open()
            Dim count As Integer = deleteCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

End Class
