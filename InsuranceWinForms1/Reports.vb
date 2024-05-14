Imports Oracle.ManagedDataAccess.Client

Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT ReportID, VehicleID1, VehicleID2, DriverID1, DriverID2, PolicyID1, PolicyID2, ReportDate, Location, Testimonial1, Testimonial2 FROM CrashReports"

        Dim dataTable As New DataTable()

        Using conn As New OracleConnection(connString)
            Using adapter As New OracleDataAdapter(query, conn)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridViewReports.DataSource = dataTable

    End Sub

    Private Sub btnAddReport_Click(sender As Object, e As EventArgs) Handles btnAddReport.Click
        EditReport.Show()

    End Sub

    Private Sub btnEditReport_Click(sender As Object, e As EventArgs) Handles btnEditReport.Click
        If DataGridViewReports.SelectedRows.Count > 0 Then
            Dim reportId = DataGridViewReports.SelectedRows(0).Cells("ReportID").Value.ToString()

            Dim editReportForm As New EditReport(reportId)
            editReportForm.Show()
        Else
            MessageBox.Show("Please select a report to edit.")
        End If

    End Sub

End Class