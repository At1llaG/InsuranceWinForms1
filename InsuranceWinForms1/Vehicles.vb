Imports Oracle.ManagedDataAccess.Client

Public Class Vehicles

    Dim connString As String = DatabaseSettings.connString

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT VehicleID, CustomerID, Plate, Make, Model, Year, Color, RegistrationNumber FROM Vehicles"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewVehicles.DataSource = dataTable
    End Sub

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        EditVehicle.Show()
    End Sub

    Private Sub btnEditVehicle_Click(sender As Object, e As EventArgs) Handles btnEditVehicle.Click
        If DataGridViewVehicles.SelectedRows.Count > 0 Then
            Dim vehicleId = DataGridViewVehicles.SelectedRows(0).Cells("VehicleID").Value.ToString()

            Dim editVehicleForm As New EditVehicle(vehicleId)
            editVehicleForm.ShowDialog()
        Else
            MessageBox.Show("Please select a vehicle to edit.")
        End If
    End Sub

End Class