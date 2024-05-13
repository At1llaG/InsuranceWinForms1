Imports Oracle.ManagedDataAccess.Client

Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Define the query to select all customers
        Dim query As String = "SELECT ReportID, VehicleID1, VehicleID2, DriverID1, DriverID2, PolicyID1, PolicyID2, ReportDate, Location, Testimonial1, Testimonial2 FROM CrashReports"

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
        DataGridViewReports.DataSource = dataTable

    End Sub

    Private Sub btnAddReport_Click(sender As Object, e As EventArgs) Handles btnAddReport.Click
        EditReport.Show()

    End Sub

    Private Sub btnEditReport_Click(sender As Object, e As EventArgs) Handles btnEditReport.Click
        ' Check if a row is selected
        If DataGridViewReports.SelectedRows.Count > 0 Then
            ' Retrieve the selected customer ID
            Dim reportId = DataGridViewReports.SelectedRows(0).Cells("ReportID").Value.ToString()

            ' Open the EditCustomer form and pass the customer ID to it
            Dim editReportForm As New EditReport(reportId)
            editReportForm.Show()
        Else
            MessageBox.Show("Please select a report to edit.")
        End If

    End Sub

End Class