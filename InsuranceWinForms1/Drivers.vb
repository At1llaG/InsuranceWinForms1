Imports Oracle.ManagedDataAccess.Client

Public Class Drivers

    Dim connString As String = DatabaseSettings.connString

    Private Sub Drivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the query to select all customers
        Dim query As String = "SELECT DriverID, FirstName, LastName, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address FROM Drivers"

        ' Create a DataTable to hold the retrieved data
        Dim dataTable As New DataTable()

        ' Establish a connection to the Oracle database
        Using conn As New OracleConnection(connString)
            ' Create a data adapter and fill the DataTable with the results of the query
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Bind the DataTable to the DataGridView
        DataGridViewDrivers.DataSource = dataTable
    End Sub

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click
        EditDriver.Show()

    End Sub

    Private Sub btnEditDriver_Click(sender As Object, e As EventArgs) Handles btnEditDriver.Click
        ' Check if a row is selected
        If DataGridViewDrivers.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim customerId = DataGridViewDrivers.SelectedRows(0).Cells("DriverID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editCustomerForm As New EditCustomer(customerId)
            editCustomerForm.ShowDialog()
        Else
            MessageBox.Show("Please select a driver to edit.")
        End If

    End Sub
End Class