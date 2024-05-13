Imports Oracle.ManagedDataAccess.Client

Public Class Vehicles

    Dim connString As String = DatabaseSettings.connString

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the query to select all customers
        Dim query As String = "SELECT VehicleID, CustomerID, Plate, Make, Model, Year, Color, RegistrationNumber FROM Vehicles"

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
        DataGridViewVehicles.DataSource = dataTable
    End Sub

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        EditVehicle.Show()
    End Sub

    Private Sub btnEditVehicle_Click(sender As Object, e As EventArgs) Handles btnEditVehicle.Click
        ' Check if a row is selected
        If DataGridViewVehicles.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim customerId = DataGridViewVehicles.SelectedRows(0).Cells("CustomerID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editCustomerForm As New EditCustomer(customerId)
            editCustomerForm.ShowDialog()
        Else
            MessageBox.Show("Please select a vehicle to edit.")
        End If
    End Sub

End Class