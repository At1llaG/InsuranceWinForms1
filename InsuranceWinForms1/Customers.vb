Imports Oracle.ManagedDataAccess.Client

Public Class Customers

    Dim connString As String = DatabaseSettings.connString

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT CustomerID, FirstName, LastName, Email, Phone, Address FROM Customers"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewCustomers.DataSource = dataTable
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        EditCustomer.Show()

    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        If DataGridViewCustomers.SelectedRows.Count > 0 Then
            Dim customerId = DataGridViewCustomers.SelectedRows(0).Cells("CustomerID").Value.ToString()

            Dim editCustomerForm As New EditCustomer(customerId)
            editCustomerForm.ShowDialog()
        Else
            MessageBox.Show("Please select a customer to edit.")
        End If


    End Sub


End Class