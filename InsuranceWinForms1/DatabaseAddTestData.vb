Imports Oracle.ManagedDataAccess.Client
Imports System

Public Class DatabaseAddTestData
    Private connString As String = DatabaseSettings.connString

    Public Sub PopulateTestData()
        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                ' Populate example data for Customers
                PopulateCustomers(conn)

                ' Populate example data for Vehicles
                PopulateVehicles(conn)

                ' Populate example data for Policies
                PopulatePolicies(conn)

                ' Populate example data for Drivers
                PopulateDrivers(conn)

                ' Populate example data for CrashReports
                PopulateCrashReports(conn)

                ' Populate example data for CrashResults
                PopulateCrashResults(conn)

                ' Populate example data for Claims
                PopulateClaims(conn)
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error populating example data: {ex.Message}")
        End Try
    End Sub

    Private Sub PopulateCustomers(conn As OracleConnection)
        Dim insertCustomersSql As String = "
            INSERT INTO Customers (FirstName, LastName, Email, Phone, Address)
            VALUES ('John', 'Doe', 'john.doe@example.com', '1234567890', '123 Main St')"

        ExecuteNonQuery(conn, insertCustomersSql)
    End Sub

    Private Sub PopulateVehicles(conn As OracleConnection)
        Dim insertVehiclesSql As String = "
            INSERT INTO Vehicles (CustomerID, Make, Model, Year, Color, RegistrationNumber)
            VALUES (1, 'Toyota', 'Camry', 2020, 'Silver', 'ABC123')"

        ExecuteNonQuery(conn, insertVehiclesSql)
    End Sub

    Private Sub PopulatePolicies(conn As OracleConnection)
        Dim insertPoliciesSql As String = "
            INSERT INTO Policies (CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium)
            VALUES (1, 1, 'Comprehensive', TO_DATE('2024-01-01', 'YYYY-MM-DD'), TO_DATE('2025-01-01', 'YYYY-MM-DD'), 500)"

        ExecuteNonQuery(conn, insertPoliciesSql)
    End Sub

    Private Sub PopulateDrivers(conn As OracleConnection)
        Dim insertDriversSql As String = "
            INSERT INTO Drivers (FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber)
            VALUES ('Jane', 'Smith', 'ABC123', TO_DATE('1990-01-01', 'YYYY-MM-DD'), TO_DATE('2010-01-01', 'YYYY-MM-DD'), TO_DATE('2030-01-01', 'YYYY-MM-DD'), 'C', 'DL123', 'DMV', '456 Elm St', '9876543210')"

        ExecuteNonQuery(conn, insertDriversSql)
    End Sub

    Private Sub PopulateCrashReports(conn As OracleConnection)
        Dim insertCrashReportsSql As String = "
            INSERT INTO CrashReports (VehicleID, DriverID, ReportDate, Location, Description)
            VALUES (1, 1, TO_DATE('2024-05-01', 'YYYY-MM-DD'), 'Main St', 'Car accident on Main St')"

        ExecuteNonQuery(conn, insertCrashReportsSql)
    End Sub

    Private Sub PopulateCrashResults(conn As OracleConnection)
        Dim insertCrashResultsSql As String = "
            INSERT INTO CrashResults (ReportID, DamageAmount, InjuryType)
            VALUES (1, 2000, 'Minor injuries')"

        ExecuteNonQuery(conn, insertCrashResultsSql)
    End Sub

    Private Sub PopulateClaims(conn As OracleConnection)
        Dim insertClaimsSql As String = "
            INSERT INTO Claims (PolicyID, DateFiled, Status, Description)
            VALUES (1, TO_DATE('2024-05-05', 'YYYY-MM-DD'), 'Pending', 'Claim for car accident damages')"

        ExecuteNonQuery(conn, insertClaimsSql)
    End Sub

    Private Sub ExecuteNonQuery(conn As OracleConnection, sql As String)
        Using cmd As New OracleCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class