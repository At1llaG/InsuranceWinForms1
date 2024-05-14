Imports Oracle.ManagedDataAccess.Client

Public Class Policies

    Dim connString As String = DatabaseSettings.connString

    Private Sub Policies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT PolicyID, CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium FROM Policies"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewPolicies.DataSource = dataTable
    End Sub

    Private Sub btnAddPolicy_Click(sender As Object, e As EventArgs) Handles btnAddPolicy.Click
        EditPolicy.Show()

    End Sub

    Private Sub btnEditPolicy_Click(sender As Object, e As EventArgs) Handles btnEditPolicy.Click
        If DataGridViewPolicies.SelectedRows.Count > 0 Then
            Dim policyId = DataGridViewPolicies.SelectedRows(0).Cells("PolicyID").Value.ToString()

            Dim editPolicyForm As New EditPolicy(policyId)
            editPolicyForm.Show()
        Else
            MessageBox.Show("Please select a customer to edit.")
        End If
    End Sub
End Class