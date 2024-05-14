Imports Oracle.ManagedDataAccess.Client

Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT ResultID, ReportID, VehicleID1, VehicleID2, FaultRateDriver1, FaultRateDriver2, DamageAmount, ViolationCode, ViolationNotification FROM CrashResults"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewResults.DataSource = dataTable
    End Sub

    Private Sub btnAddResult_Click(sender As Object, e As EventArgs) Handles btnAddResult.Click
        EditResult.Show()

    End Sub

    Private Sub btnEditResult_Click(sender As Object, e As EventArgs) Handles btnEditResult.Click
        If DataGridViewResults.SelectedRows.Count > 0 Then
            Dim resultId = DataGridViewResults.SelectedRows(0).Cells("ResultID").Value.ToString()

            Dim editResultForm As New EditResult(resultId)
            editResultForm.ShowDialog()
        Else
            MessageBox.Show("Please select a result to edit.")
        End If
    End Sub

End Class