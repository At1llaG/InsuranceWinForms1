Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditDriver

    Private connString As String = DatabaseSettings.connString
    Private driverId As String

    Public Sub New()
        ' Initialize the component
        InitializeComponent()

        ' Set the driver ID to an empty string or any default value as needed
        Me.driverId = String.Empty
    End Sub

    ' Constructor that accepts the driver ID
    Public Sub New(driverId As String)
        ' Initialize the component
        InitializeComponent()

        ' Store the driver ID
        Me.driverId = driverId
    End Sub

    Private Sub EditDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(driverId) Then
            Dim driverTable As DataTable = FetchDriverDetails(driverId)

            ' Bind the DataTable to DataGridView
            ' DataGridView1.DataSource = driverTable
        End If
    End Sub

    Private Function FetchDriverDetails(driverId As String) As DataTable
        Dim driverTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM Drivers WHERE DriverID = :driverId"

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":driverId", OracleDbType.Int32).Value = Convert.ToInt32(driverId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(driverTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching driver details: {ex.Message}")
        End Try

        Return driverTable
    End Function

    'Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click
    '    Dim firstName As String = txtFirstName.Text
    '    Dim lastName As String = txtLastName.Text
    '    Dim identityNumber As String = txtIdentityNumber.Text
    '    Dim dateOfBirth As Date
    '    If Date.TryParse(txtDateOfBirth.Text, dateOfBirth) Then
    '        Dim licenseIssuanceDate As Date
    '        If Date.TryParse(txtLicenseIssuanceDate.Text, licenseIssuanceDate) Then
    '            Dim licenseValidUntilDate As Date
    '            If Date.TryParse(txtLicenseValidUntilDate.Text, licenseValidUntilDate) Then
    '                Dim licenseClass As String = txtLicenseClass.Text
    '                Dim licenseNumber As String = txtLicenseNumber.Text
    '                Dim licenseIssuedBy As String = txtLicenseIssuedBy.Text
    '                Dim address As String = txtAddress.Text
    '                Dim phoneNumber As String = txtPhoneNumber.Text

    '                ' Insert the driver into the database
    '                InsertDriver(firstName, lastName, identityNumber, dateOfBirth, licenseIssuanceDate, licenseValidUntilDate, licenseClass, licenseNumber, licenseIssuedBy, address, phoneNumber)
    '            Else
    '                MessageBox.Show("Invalid license valid until date.")
    '            End If
    '        Else
    '            MessageBox.Show("Invalid license issuance date.")
    '        End If
    '    Else
    '        MessageBox.Show("Invalid date of birth.")
    '    End If
    'End Sub

    'Private Sub btnUpdateDriver_Click(sender As Object, e As EventArgs) Handles btnUpdateDriver.Click
    '    Dim driverID As Integer
    '    If Integer.TryParse(txtDriverID.Text, driverID) Then
    '        Dim firstName As String = txtFirstName.Text
    '        Dim lastName As String = txtLastName.Text
    '        Dim identityNumber As String = txtIdentityNumber.Text
    '        Dim dateOfBirth As Date
    '        If Date.TryParse(txtDateOfBirth.Text, dateOfBirth) Then
    '            Dim licenseIssuanceDate As Date
    '            If Date.TryParse(txtLicenseIssuanceDate.Text, licenseIssuanceDate) Then
    '                Dim licenseValidUntilDate As Date
    '                If Date.TryParse(txtLicenseValidUntilDate.Text, licenseValidUntilDate) Then
    '                    Dim licenseClass As String = txtLicenseClass.Text
    '                    Dim licenseNumber As String = txtLicenseNumber.Text
    '                    Dim licenseIssuedBy As String = txtLicenseIssuedBy.Text
    '                    Dim address As String = txtAddress.Text
    '                    Dim phoneNumber As String = txtPhoneNumber.Text

    '                    ' Update the driver in the database
    '                    UpdateDriver(driverID, firstName, lastName, identityNumber, dateOfBirth, licenseIssuanceDate, licenseValidUntilDate, licenseClass, licenseNumber, licenseIssuedBy, address, phoneNumber)
    '                Else
    '                    MessageBox.Show("Invalid license valid until date.")
    '                End If
    '            Else
    '                MessageBox.Show("Invalid license issuance date.")
    '            End If
    '        Else
    '            MessageBox.Show("Invalid date of birth.")
    '        End If
    '    Else
    '        MessageBox.Show("Invalid driver ID.")
    '    End If
    'End Sub

    'Private Sub btnDeleteDriver_Click(sender As Object, e As EventArgs) Handles btnDeleteDriver.Click
    '    Dim driverID As Integer
    '    If Integer.TryParse(txtDriverID.Text, driverID) Then
    '        ' Delete the driver from the database
    '        DeleteDriver(driverID)
    '    Else
    '        MessageBox.Show("Invalid driver ID.")
    '    End If
    'End Sub

    Private Sub InsertDriver(firstName As String, lastName As String, identityNumber As String, dateOfBirth As Date, licenseIssuanceDate As Date, licenseValidUntilDate As Date, licenseClass As String, licenseNumber As String, licenseIssuedBy As String, address As String, phoneNumber As String)
        Dim query As String = "INSERT INTO Drivers (FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber) " &
                              "VALUES (:firstName, :lastName, :identityNumber, :dateOfBirth, :licenseIssuanceDate, :licenseValidUntilDate, :licenseClass, :licenseNumber, :licenseIssuedBy, :address, :phoneNumber)"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = firstName
                    cmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = lastName
                    cmd.Parameters.Add(":identityNumber", OracleDbType.Varchar2).Value = identityNumber
                    cmd.Parameters.Add(":dateOfBirth", OracleDbType.Date).Value = dateOfBirth
                    cmd.Parameters.Add(":licenseIssuanceDate", OracleDbType.Date).Value = licenseIssuanceDate
                    cmd.Parameters.Add(":licenseValidUntilDate", OracleDbType.Date).Value = licenseValidUntilDate
                    cmd.Parameters.Add(":licenseClass", OracleDbType.Varchar2).Value = licenseClass
                    cmd.Parameters.Add(":licenseNumber", OracleDbType.Varchar2).Value = licenseNumber
                    cmd.Parameters.Add(":licenseIssuedBy", OracleDbType.Varchar2).Value = licenseIssuedBy
                    cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error inserting driver: {ex.Message}")
        End Try
    End Sub

    Private Sub UpdateDriver(driverID As Integer, firstName As String, lastName As String, identityNumber As String, dateOfBirth As Date, licenseIssuanceDate As Date, licenseValidUntilDate As Date, licenseClass As String, licenseNumber As String, licenseIssuedBy As String, address As String, phoneNumber As String)
        Dim query As String = "UPDATE Drivers SET FirstName = :firstName, LastName = :lastName, IdentityNumber = :identityNumber, " &
                              "DateOfBirth = :dateOfBirth, LicenseIssuanceDate = :licenseIssuanceDate, LicenseValidUntilDate = :licenseValidUntilDate, " &
                              "LicenseClass = :licenseClass, LicenseNumber = :licenseNumber, LicenseIssuedBy = :licenseIssuedBy, " &
                              "Address = :address, PhoneNumber = :phoneNumber WHERE DriverID = :driverID"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = firstName
                    cmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = lastName
                    cmd.Parameters.Add(":identityNumber", OracleDbType.Varchar2).Value = identityNumber
                    cmd.Parameters.Add(":dateOfBirth", OracleDbType.Date).Value = dateOfBirth
                    cmd.Parameters.Add(":licenseIssuanceDate", OracleDbType.Date).Value = licenseIssuanceDate
                    cmd.Parameters.Add(":licenseValidUntilDate", OracleDbType.Date).Value = licenseValidUntilDate
                    cmd.Parameters.Add(":licenseClass", OracleDbType.Varchar2).Value = licenseClass
                    cmd.Parameters.Add(":licenseNumber", OracleDbType.Varchar2).Value = licenseNumber
                    cmd.Parameters.Add(":licenseIssuedBy", OracleDbType.Varchar2).Value = licenseIssuedBy
                    cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber
                    cmd.Parameters.Add(":driverID", OracleDbType.Int32).Value = driverID

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating driver: {ex.Message}")
        End Try
    End Sub

    Private Sub DeleteDriver(driverID As Integer)
        Dim query As String = "DELETE FROM Drivers WHERE DriverID = :driverID"

        Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":driverID", OracleDbType.Int32).Value = driverID

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting driver: {ex.Message}")
        End Try
    End Sub

End Class
