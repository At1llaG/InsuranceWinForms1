Imports Oracle.ManagedDataAccess.Client

Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Define the query to select all customers
        Dim query As String = "SELECT ResultID, ReportID, VehicleID1, VehicleID2, FaultRateDriver1, FaultRateDriver2, DamageAmount, ViolationCode, ViolationNotification FROM CrashResults"

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
        DataGridViewResults.DataSource = dataTable
    End Sub

    Private Sub btnAddResult_Click(sender As Object, e As EventArgs) Handles btnAddResult.Click
        EditResult.Show()

    End Sub

    Private Sub btnEditResult_Click(sender As Object, e As EventArgs) Handles btnEditResult.Click
        ' Check if a row is selected
        If DataGridViewResults.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim resultId = DataGridViewResults.SelectedRows(0).Cells("ResultID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editResultForm As New EditResult(resultId)
            editResultForm.ShowDialog()
        Else
            MessageBox.Show("Please select a result to edit.")
        End If
    End Sub

End Class