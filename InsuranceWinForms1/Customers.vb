Imports Oracle.ManagedDataAccess.Client

Public Class Customers

    Dim connString As String = DatabaseSettings.connString

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Define the query to select all customers
        Dim query As String = "SELECT CustomerID, FirstName, LastName, Email, Phone, Address FROM Customers"

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
        DataGridViewCustomers.DataSource = dataTable
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        ' Check if a row is selected
        If DataGridViewCustomers.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim customerId = DataGridViewCustomers.SelectedRows(0).Cells("CustomerID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editCustomerForm As New EditCustomer(customerId)
            editCustomerForm.ShowDialog()
        Else
            MessageBox.Show("Please select a customer to edit.")
        End If


    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        EditCustomer.Show()

    End Sub


End Class