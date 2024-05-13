Imports Oracle.ManagedDataAccess.Client

Public Class Policies

    Dim connString As String = DatabaseSettings.connString

    Private Sub Policies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the query to select all customers
        Dim query As String = "SELECT PolicyID, CustomerID, VehicleID, PolicyType, StartDate, EndDate, Premium FROM Policies"

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
        DataGridViewPolicies.DataSource = dataTable
    End Sub

    Private Sub btnAddPolicy_Click(sender As Object, e As EventArgs) Handles btnAddPolicy.Click
        EditPolicy.Show()

    End Sub

    Private Sub btnEditPolicy_Click(sender As Object, e As EventArgs) Handles btnEditPolicy.Click
        ' Check if a row is selected
        If DataGridViewPolicies.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim policyId = DataGridViewPolicies.SelectedRows(0).Cells("PolicyID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editCustomerForm As New EditCustomer(policyId)
            editCustomerForm.Show()
        Else
            MessageBox.Show("Please select a customer to edit.")
        End If
    End Sub
End Class