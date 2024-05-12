﻿Imports Oracle.ManagedDataAccess.Client

Public Class AddDriver

    Private connString As String = DatabaseSettings.connString
    Private conn As OracleConnection = New OracleConnection(connString)


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click

        Dim name As String = txtName.Text
        Dim surname As String = txtSurname.Text
        Dim identityNumber As String = txtIdentityNumber.Text
        Dim dob As Date = dobPicker.Value
        Dim issuanceDate As Date = issuanceDatePicker.Value
        Dim validUntilDate As Date = validUntilDatePicker.Value
        Dim licenseClass As String = txtLicenseClass.Text
        Dim licenseNumber As String = txtLicenseNumber.Text
        Dim issuedBy As String = txtIssuedBy.Text
        Dim address As String = txtAddress.Text
        Dim phoneNumber As String = txtPhoneNumber.Text

        Dim query As String = "INSERT INTO Drivers (Name, Surname, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber) " &
                              "VALUES (:name, :surname, :identityNumber, :dob, :issuanceDate, :validUntilDate, :licenseClass, :licenseNumber, :issuedBy, :address, :phoneNumber)"

        Using cmd As OracleCommand = New OracleCommand(query, conn)
            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name
            cmd.Parameters.Add(":surname", OracleDbType.Varchar2).Value = surname
            cmd.Parameters.Add(":identityNumber", OracleDbType.Varchar2).Value = identityNumber
            cmd.Parameters.Add(":dob", OracleDbType.Date).Value = dob
            cmd.Parameters.Add(":issuanceDate", OracleDbType.Date).Value = issuanceDate
            cmd.Parameters.Add(":validUntilDate", OracleDbType.Date).Value = validUntilDate
            cmd.Parameters.Add(":licenseClass", OracleDbType.Varchar2).Value = licenseClass
            cmd.Parameters.Add(":licenseNumber", OracleDbType.Varchar2).Value = licenseNumber
            cmd.Parameters.Add(":issuedBy", OracleDbType.Varchar2).Value = issuedBy
            cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
            cmd.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Driver added successfully!")
            Catch ex As Exception
                MessageBox.Show("Failed to add driver: " & ex.Message, "Error")
            Finally
                conn.Close()
            End Try
        End Using


    End Sub

End Class