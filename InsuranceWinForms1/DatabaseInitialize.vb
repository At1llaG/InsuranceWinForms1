Imports Oracle.ManagedDataAccess.Client

Public Class DatabaseInitialize

    Private connString As String = DatabaseSettings.connString
    Private conn As OracleConnection = New OracleConnection(connString)


    Public Shared createCustomersTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Shared createVehiclesTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Shared createPoliciesTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Shared createDriversTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Shared createReportsTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Shared createResultsTableSql As String = "
    CREATE TABLE IF NOT EXISTS DRIVERS (
        studentId INT,
        firstName VARCHAR(100),
        lastName VARCHAR(100),
        sport VARCHAR(255)

    )"

    Public Function CreateCustomersTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")   
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function CreateVehiclesTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function CreatePoliciesTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function CreateDriversTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function CreateReportsTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function CreateResultsTable() As Boolean
        Try
            conn.Open()
            Using createCustomersTableCmd As New OracleCommand(createCustomersTableSql, conn)
                createCustomersTableCmd.ExecuteNonQuery()
                MessageBox.Show("Customers table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating customers table: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function InitializeCreate() As Boolean
        Try
            If CreateCustomersTable() Then
                If CreateVehiclesTable() Then
                    If CreatePoliciesTable() Then
                        If CreateDriversTable() Then
                            If CreateReportsTable() Then
                                If CreateResultsTable() Then
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error initializing database: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DropTable(tableName As String) As Boolean
        Try
            Dim dropTableSql As String = $"DROP TABLE {tableName}"
            Using conn As New OracleConnection(connString)
                conn.Open()
                Using dropTableCmd As New OracleCommand(dropTableSql, conn)
                    dropTableCmd.ExecuteNonQuery()
                    Console.WriteLine($"Table {tableName} dropped successfully.")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error dropping table {tableName}: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function InitializeDrop() As Boolean
        Try
            Dim tableNames As String() = {"table1", "table2", "table3"} ' Add your table names here
            For Each tableName In tableNames
                If Not DropTable(tableName) Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Console.WriteLine($"Error initializing drop: {ex.Message}")
            Return False
        End Try
    End Function



End Class
