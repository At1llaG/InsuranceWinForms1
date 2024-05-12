﻿Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditPolicies

    Private connString As String = DatabaseSettings.connString
    Private policyId As String

    Public Sub New()
        ' Initialize the component
        InitializeComponent()

        ' Set the policy ID to an empty string or any default value as needed
        Me.policyId = String.Empty
    End Sub

    ' Constructor that accepts the policy ID
    Public Sub New(policyId As String)
        ' Initialize the component
        InitializeComponent()

        ' Store the policy ID
        Me.policyId = policyId
    End Sub

    Private Sub EditPolicies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(policyId) Then
            Dim policyTable As DataTable = FetchPolicyDetails(policyId)

            ' Bind the DataTable to DataGridView
            DataGridView1.DataSource = policyTable
        End If
    End Sub

    Private Function FetchPolicyDetails(policyId As String) As DataTable
        Dim policyTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM Policies WHERE PolicyID = :policyId"

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":policyId", OracleDbType.Int32).Value = Convert.ToInt32(policyId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(policyTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching policy details: {ex.Message}")
        End Try

        Return policyTable
    End Function

    Private Sub btnAddPolicy_Click(sender As Object, e As EventArgs) Handles btnAddPolicy.Click
        Dim customerId As Integer
        If Integer.TryParse(txtCustomerID.Text, customerId) Then
            Dim vehicleId As Integer
            If Integer.TryParse(txtVehicleID.Text, vehicleId) Then
                Dim policyType As String = txtPolicyType.Text
                Dim startDate As Date
                If Date.TryParse(txtStartDate.Text, startDate) Then
                    Dim endDate As Date
                    If Date.TryParse(txtEndDate.Text, endDate) Then
                        Dim premium As Decimal
                        If Decimal.TryParse(txtPremium.Text, premium) Then
                            ' Insert the policy into the database
                            InsertPolicy(customerId, vehicleId, policyType, startDate, endDate, premium)
                        Else
                            MessageBox.Show("Invalid premium.")
                        End If
                    Else
                        MessageBox.Show("Invalid end date.")
                    End If
                Else
                    MessageBox.Show("Invalid start date.")
                End If
            Else
                MessageBox.Show("Invalid vehicle ID.")
            End If
        Else
            MessageBox.Show("Invalid customer ID.")
        End If
    End Sub

    Private Sub btnUpdatePolicy_Click(sender As Object, e As EventArgs) Handles btnUpdatePolicy.Click
        Dim policyID As Integer
        If Integer.TryParse(txtPolicyID.Text, policyID) Then
            Dim customerId As Integer
            If Integer.TryParse(txtCustomerID.Text, customerId) Then
                Dim vehicleId As Integer
                If Integer.TryParse(txtVehicleID.Text, vehicleId) Then
                    Dim policyType As String = txtPolicyType.Text
                    Dim startDate As Date
                    If Date.TryParse(txtStartDate.Text, startDate) Then
                        Dim endDate As Date
                        If Date.TryParse(txtEndDate.Text, endDate) Then
                            Dim premium As Decimal
                            If Decimal.TryParse(txtPremium.Text, premium) Then
                                ' Update the policy in the database
                                UpdatePolicy(policyID, customerId, vehicleId, policyType, startDate, endDate, premium)
                            Else
                                MessageBox.Show("Invalid premium.")
                            End If
                        Else
                            MessageBox.Show("Invalid end date.")
                        End If
                    Else
                        MessageBox.Show("Invalid start date.")
                    End If
                Else
                    MessageBox.Show("Invalid vehicle ID.")
                End If
            Else
                MessageBox.Show("Invalid customer ID.")
            End If
        Else
            MessageBox.Show("Invalid policy ID.")
        End If
    End Sub

    Private Sub btnDeletePolicy_Click(sender As Object, e As EventArgs) Handles btnDeletePolicy.Click
        Dim policyID As Integer
        If Integer.TryParse(txtPolicyID.Text, policyID) Then
            ' Delete the policy from the database
            DeletePolicy(policyID)
        Else
            MessageBox.Show("Invalid policy ID.")
        End If
    End Sub

    Private Sub InsertPolicy(customerId As Integer, vehicleId As Integer, policyType As String, startDate As Date, endDate As Date, premium As Decimal)
        Dim query As String = "INSERT INTO Policies (CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium) " &
                              "VALUES (:customerId, :vehicleId, :policyType, :startDate, :endDate, :premium)"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId
                    cmd.Parameters.Add(":vehicleId", OracleDbType.Int32).Value = vehicleId
                    cmd.Parameters.Add(":policyType", OracleDbType.Varchar2).Value = policyType
                    cmd.Parameters.Add(":startDate", OracleDbType.Date).Value = startDate
                    cmd.Parameters.Add(":endDate", OracleDbType.Date).Value = endDate
                    cmd.Parameters.Add(":premium", OracleDbType.Decimal).Value = premium

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error inserting policy: {ex.Message}")
        End Try
    End Sub

    Private Sub UpdatePolicy(policyID As Integer, customerId As Integer, vehicleId As Integer, policyType As String, startDate As Date, endDate As Date, premium As Decimal)
        Dim query As String = "UPDATE Policies SET CustomerID = :customerId, VehicleID = :vehicleId, PolicyType = :policyType, " &
                              "StartDate = :startDate, EndDate = :endDate, Premium = :premium WHERE PolicyID = :policyID"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId
                    cmd.Parameters.Add(":vehicleId", OracleDbType.Int32).Value = vehicleId
                    cmd.Parameters.Add(":policyType", OracleDbType.Varchar2).Value = policyType
                    cmd.Parameters.Add(":startDate", OracleDbType.Date).Value = startDate
                    cmd.Parameters.Add(":endDate", OracleDbType.Date).Value = endDate
                    cmd.Parameters.Add(":premium", OracleDbType.Decimal).Value = premium
                    cmd.Parameters.Add(":policyID", OracleDbType.Int32).Value = policyID

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating policy: {ex.Message}")
        End Try
    End Sub

    Private Sub DeletePolicy(policyID As Integer)
        Dim query As String = "DELETE FROM Policies WHERE PolicyID = :policyID"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":policyID", OracleDbType.Int32).Value = policyID

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting policy: {ex.Message}")
        End Try
    End Sub

End Class