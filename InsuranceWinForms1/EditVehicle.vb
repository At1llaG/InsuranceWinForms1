﻿Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditVehicle

    Private connString As String = DatabaseSettings.connString
    Private vehicleId As String

    Public Sub New()
        InitializeComponent()
        Me.vehicleId = String.Empty
    End Sub

    ' Constructor that accepts the vehicle ID
    Public Sub New(vehicleId As String)
        InitializeComponent()
        Me.vehicleId = vehicleId
    End Sub

    Private Sub EditVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(vehicleId) Then
            Dim vehicleDetails As DataTable = FetchVehicleDetails(vehicleId)

            If vehicleDetails.Rows.Count > 0 Then
                Dim customerId As String = vehicleDetails.Rows(0)("CustomerID").ToString()
                Dim plate As String = vehicleDetails.Rows(0)("Plate").ToString()
                Dim make As String = vehicleDetails.Rows(0)("Make").ToString()
                Dim model As String = vehicleDetails.Rows(0)("Model").ToString()
                Dim year As String = vehicleDetails.Rows(0)("Year").ToString()
                Dim color As String = vehicleDetails.Rows(0)("Color").ToString()
                Dim registrationNumber As String = vehicleDetails.Rows(0)("RegistrationNumber").ToString()


                lblVehicleId.Text = vehicleId
                txtCustomerID.Text = customerId
                txtPlate.Text = plate
                txtMake.Text = make
                txtModel.Text = model
                txtYear.Text = year
                txtColor.Text = color
                txtRegistrationNumber.Text = registrationNumber
            Else
                MessageBox.Show("Vehicle details not found.")
            End If

        End If
    End Sub

    Private Function FetchVehicleDetails(vehicleId As String) As DataTable
        Dim vehicleTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM Vehicles WHERE VehicleID = :vehicleId"

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":vehicleId", OracleDbType.Int32).Value = Convert.ToInt32(vehicleId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(vehicleTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching vehicle details: {ex.Message}")
        End Try

        Return vehicleTable
    End Function

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        Dim customerId As Integer
        If Integer.TryParse(txtCustomerID.Text, customerId) Then
            Dim plate As String = txtPlate.Text
            Dim make As String = txtMake.Text
            Dim model As String = txtModel.Text
            Dim year As Integer
            If Integer.TryParse(txtYear.Text, year) Then
                Dim color As String = txtColor.Text
                Dim regNumber As String = txtRegistrationNumber.Text

                InsertVehicle(customerId, plate, make, model, year, color, regNumber)
            Else
                MessageBox.Show("Invalid year.")
            End If
        Else
            MessageBox.Show("Invalid customer ID.")
        End If
    End Sub

    Private Sub btnUpdateVehicle_Click(sender As Object, e As EventArgs) Handles btnUpdateVehicle.Click
        Dim vehicleID As Integer
        If Integer.TryParse(lblVehicleId.Text, vehicleID) Then
            Dim customerId As Integer
            If Integer.TryParse(txtCustomerID.Text, customerId) Then
                Dim plate As String = txtPlate.Text
                Dim make As String = txtMake.Text
                Dim model As String = txtModel.Text
                Dim year As Integer
                If Integer.TryParse(txtYear.Text, year) Then
                    Dim color As String = txtColor.Text
                    Dim regNumber As String = txtRegistrationNumber.Text

                    UpdateVehicle(vehicleID, customerId, plate, make, model, year, color, regNumber)
                Else
                    MessageBox.Show("Invalid year.")
                End If
            Else
                MessageBox.Show("Invalid customer ID.")
            End If
        Else
            MessageBox.Show("Invalid vehicle ID.")
        End If
    End Sub

    Private Sub btnDeleteVehicle_Click(sender As Object, e As EventArgs) Handles btnDeleteVehicle.Click
        Dim vehicleID As Integer
        If Integer.TryParse(lblVehicleId.Text, vehicleID) Then
            DeleteVehicle(vehicleID)
        Else
            MessageBox.Show("Invalid vehicle ID.")
        End If
    End Sub

    Private Sub InsertVehicle(customerId As Integer, plate As String, make As String, model As String, year As Integer, color As String, regNumber As String)
        Dim query As String = "INSERT INTO Vehicles (CustomerID, Plate, Make, Model, Year, Color, RegistrationNumber) " &
                              "VALUES (:customerId, :plate, :make, :model, :year, :color, :regNumber)"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId
                cmd.Parameters.Add(":plate", OracleDbType.Varchar2).Value = plate
                cmd.Parameters.Add(":make", OracleDbType.Varchar2).Value = make
                cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = model
                cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year
                cmd.Parameters.Add(":color", OracleDbType.Varchar2).Value = color
                cmd.Parameters.Add(":regNumber", OracleDbType.Varchar2).Value = regNumber

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error inserting data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateVehicle(vehicleID As Integer, customerId As Integer, plate As String, make As String, model As String, year As Integer, color As String, regNumber As String)
        Dim query As String = "UPDATE Vehicles SET CustomerID = :customerId, Plate = :plate, Make = :make, Model = :model, Year = :year, Color = :color, RegistrationNumber = :regNumber " &
                              "WHERE VehicleID = :vehicleID"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId
                cmd.Parameters.Add(":plate", OracleDbType.Varchar2).Value = plate
                cmd.Parameters.Add(":make", OracleDbType.Varchar2).Value = make
                cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = model
                cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year
                cmd.Parameters.Add(":color", OracleDbType.Varchar2).Value = color
                cmd.Parameters.Add(":regNumber", OracleDbType.Varchar2).Value = regNumber
                cmd.Parameters.Add(":vehicleID", OracleDbType.Int32).Value = vehicleID

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error updating data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteVehicle(vehicleID As Integer)
        Dim query As String = "DELETE FROM Vehicles WHERE VehicleID = :vehicleID"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":vehicleID", OracleDbType.Int32).Value = vehicleID

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error deleting data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub


End Class
