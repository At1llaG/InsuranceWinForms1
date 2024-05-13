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

        Dim insertCustomersSql2 As String = "
            INSERT INTO Customers (FirstName, LastName, Email, Phone, Address)
            VALUES ('Jane', 'Doe', 'jane.doe@example.com', '1234567890', '123 Main St')"

        ExecuteNonQuery(conn, insertCustomersSql2)
    End Sub

    Private Sub PopulateVehicles(conn As OracleConnection)
        Dim insertVehiclesSql As String = "
            INSERT INTO Vehicles (CustomerID, Make, Model, Year, Color, RegistrationNumber)
            VALUES (1, 'Toyota', 'Camry', 2020, 'Silver', 'ABC123')"

        ExecuteNonQuery(conn, insertVehiclesSql)

        Dim insertVehiclesSql2 As String = "
            INSERT INTO Vehicles (CustomerID, Make, Model, Year, Color, RegistrationNumber)
            VALUES (2, 'Opel', 'Camry', 2020, 'Silver', 'ABC123')"

        ExecuteNonQuery(conn, insertVehiclesSql2)
    End Sub

    Private Sub PopulatePolicies(conn As OracleConnection)
        Dim insertPoliciesSql As String = "
            INSERT INTO Policies (CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium)
            VALUES (1, 1, 'Comprehensive', TO_DATE('2024-01-01', 'YYYY-MM-DD'), TO_DATE('2025-01-01', 'YYYY-MM-DD'), 500)"

        ExecuteNonQuery(conn, insertPoliciesSql)

        Dim insertPoliciesSql2 As String = "
            INSERT INTO Policies (CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium)
            VALUES (2, 2, 'Comprehensive', TO_DATE('2024-01-01', 'YYYY-MM-DD'), TO_DATE('2025-01-01', 'YYYY-MM-DD'), 500)"

        ExecuteNonQuery(conn, insertPoliciesSql2)
    End Sub

    Private Sub PopulateDrivers(conn As OracleConnection)
        Dim insertDriversSql As String = "
            INSERT INTO Drivers (FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber)
            VALUES ('Jane', 'Smith', 'ABC123', TO_DATE('1990-01-01', 'YYYY-MM-DD'), TO_DATE('2010-01-01', 'YYYY-MM-DD'), TO_DATE('2030-01-01', 'YYYY-MM-DD'), 'C', 'DL123', 'DMV', '456 Elm St', '9876543210')"

        ExecuteNonQuery(conn, insertDriversSql)

        Dim insertDriversSql2 As String = "
            INSERT INTO Drivers (FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber)
            VALUES ('John', 'Smith', 'ABC123', TO_DATE('1990-01-01', 'YYYY-MM-DD'), TO_DATE('2010-01-01', 'YYYY-MM-DD'), TO_DATE('2030-01-01', 'YYYY-MM-DD'), 'C', 'DL123', 'DMV', '456 Elm St', '9876543210')"

        ExecuteNonQuery(conn, insertDriversSql2)
    End Sub

    Private Sub PopulateCrashReports(conn As OracleConnection)
        Dim insertCrashReportsSql As String = "
        INSERT INTO CrashReports (VehicleID1, VehicleID2, DriverID1, DriverID2, PolicyID1, PolicyID2, ReportDate, Location, Description, Testimonial1, Testimonial2)
        VALUES (1, 2, 1, 2, 1, 2, TO_DATE('2024-05-01', 'YYYY-MM-DD'), 'Main St', 'Car accident on Main St', 'Driver 1 testimonial', 'Driver 2 testimonial')"

        ExecuteNonQuery(conn, insertCrashReportsSql)
    End Sub

    Private Sub PopulateCrashResults(conn As OracleConnection)
        Dim insertCrashResultsSql As String = "
        INSERT INTO CrashResults (ReportID, DamageAmount, ViolationCode)
        VALUES (1, 2000, 'Violation123')"

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