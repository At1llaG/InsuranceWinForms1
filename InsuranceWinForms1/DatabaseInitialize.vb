﻿Imports Oracle.ManagedDataAccess.Client

Public Class DatabaseInitialize

    Private connString As String = DatabaseSettings.connString
    Private conn As OracleConnection = New OracleConnection(connString)


    Public Shared createCustomersTableSql As String = "
        CREATE TABLE Customers (
            CustomerID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            FirstName VARCHAR2(100),
            LastName VARCHAR2(100),
            Email VARCHAR2(255),
            Phone VARCHAR2(20),
            Address VARCHAR2(255),
            PRIMARY KEY (CustomerID)
        )"

    Public Shared createVehiclesTableSql As String = "
        CREATE TABLE Vehicles (
            VehicleID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            CustomerID NUMBER,
            Make VARCHAR2(100),
            Model VARCHAR2(100),
            Year NUMBER(4),
            Color VARCHAR2(50),
            RegistrationNumber VARCHAR2(20),
            PRIMARY KEY (VehicleID),
            FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
        )"

    Public Shared createPoliciesTableSql As String = "
        CREATE TABLE Policies (
            PolicyID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            CustomerID NUMBER,
            VehicleID NUMBER,
            PolicyType VARCHAR2(50),
            StartDate DATE,
            EndDate DATE,
            Premium NUMBER(10, 2),
            PRIMARY KEY (PolicyID),
            FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
            FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID)
        )"

    Public Shared createDriversTableSql As String = "
        CREATE TABLE Drivers (
            DriverID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            FirstName VARCHAR2(100),
            LastName VARCHAR2(100),
            IdentityNumber VARCHAR2(20),
            DateOfBirth DATE,
            LicenseIssuanceDate DATE,
            LicenseValidUntilDate DATE,
            LicenseClass VARCHAR2(20),
            LicenseNumber VARCHAR2(20),
            LicenseIssuedBy VARCHAR2(100),
            Address VARCHAR2(255),
            PhoneNumber VARCHAR2(20),
            PRIMARY KEY (DriverID)
        )"

    Public Shared createCrashReportsTableSql As String = "
        CREATE TABLE CrashReports (
            ReportID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            VehicleID1 NUMBER,
            VehicleID2 NUMBER,
            DriverID1 NUMBER,
            DriverID2 NUMBER,
            ReportDate DATE,
            Location VARCHAR2(255),
            Description VARCHAR2(1000),
            Testimonial1 VARCHAR2(1000),
            Testimonial2 VARCHAR2(1000),
            PRIMARY KEY (ReportID),
            FOREIGN KEY (VehicleID1) REFERENCES Vehicles(VehicleID),
            FOREIGN KEY (VehicleID2) REFERENCES Vehicles(VehicleID),
            FOREIGN KEY (DriverID1) REFERENCES Drivers(DriverID),
            FOREIGN KEY (DriverID2) REFERENCES Drivers(DriverID)
        )"

    Public Shared createCrashResultsTableSql As String = "
        CREATE TABLE CrashResults (
            ResultID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            ReportID NUMBER,
            DamageAmount NUMBER(10, 2),
            ViolationCode VARCHAR2(100),
            PRIMARY KEY (ResultID),
            FOREIGN KEY (ReportID) REFERENCES CrashReports(ReportID)
        )"

    Dim createClaimsTableSql As String = "
        CREATE TABLE Claims (
            ClaimID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
            PolicyID NUMBER,
            DateFiled DATE,
            Status VARCHAR2(50),
            Description VARCHAR2(1000),
            PRIMARY KEY (ClaimID),
            FOREIGN KEY (PolicyID) REFERENCES Policies(PolicyID)
        )"

    Public Function CreateTable(createTableSql As String) As Boolean
        Try
            conn.Open()
            Using createTableCmd As New OracleCommand(createTableSql, conn)
                createTableCmd.ExecuteNonQuery()
                Console.WriteLine("Table created successfully.")
                Return True
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error creating table : {ex.Message}")
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function InitializeCreate() As Boolean
        Try
            If CreateTable(createCustomersTableSql) Then
                If CreateTable(createVehiclesTableSql) Then
                    If CreateTable(createPoliciesTableSql) Then
                        If CreateTable(createDriversTableSql) Then
                            If CreateTable(createCrashReportsTableSql) Then
                                If CreateTable(createCrashResultsTableSql) Then
                                    If CreateTable(createClaimsTableSql) Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error initializing database: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DropTable(tableName As String) As Boolean
        Try
            Dim dropTableSql As String = $"DROP TABLE {tableName}"
            conn.Open()
            Using dropTableCmd As New OracleCommand(dropTableSql, conn)
                dropTableCmd.ExecuteNonQuery()
                Console.WriteLine($"Table {tableName} dropped successfully.")
                Return True
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error dropping table {tableName}: {ex.Message}")
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function InitializeDrop() As Boolean
        Try
            Dim tableNames As String() = {"Customers", "Vehicles", "Policies", "Drivers", "CrashReports", "CrashResults", "Claims"}
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
