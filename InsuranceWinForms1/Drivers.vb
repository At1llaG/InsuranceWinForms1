Imports Oracle.ManagedDataAccess.Client

Public Class Drivers

    Dim connString As String = DatabaseSettings.connString

    Private Sub Drivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT DriverID, FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address FROM Drivers"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewDrivers.DataSource = dataTable
    End Sub

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click
        EditDriver.Show()

    End Sub

    Private Sub btnEditDriver_Click(sender As Object, e As EventArgs) Handles btnEditDriver.Click
        If DataGridViewDrivers.SelectedRows.Count > 0 Then
            Dim driverId = DataGridViewDrivers.SelectedRows(0).Cells("DriverID").Value.ToString()

            Dim editDriverForm As New EditDriver(driverId)
            editDriverForm.ShowDialog()
        Else
            MessageBox.Show("Please select a driver to edit.")
        End If

    End Sub
End Class