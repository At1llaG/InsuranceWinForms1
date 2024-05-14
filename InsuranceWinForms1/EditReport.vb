Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditReport

    Private connString As String = DatabaseSettings.connString
    Private reportId As String

    Public Sub New()
        InitializeComponent()
        Me.reportId = String.Empty
    End Sub

    ' Constructor that accepts the report ID
    Public Sub New(reportId As String)
        InitializeComponent()
        Me.reportId = reportId
    End Sub

    Private Sub EditCrashReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(reportId) Then
            LoadCrashReportDetails(reportId)
        End If
    End Sub

    Private Sub btnAddCrashReport_Click(sender As Object, e As EventArgs) Handles btnAddCrashReport.Click
        AddCrashReport()
    End Sub

    Private Sub btnUpdateCrashReport_Click(sender As Object, e As EventArgs) Handles btnUpdateCrashReport.Click
        UpdateCrashReport()
    End Sub

    Private Sub btnDeleteCrashReport_Click(sender As Object, e As EventArgs) Handles btnDeleteCrashReport.Click
        DeleteCrashReport()
    End Sub

    Private Sub LoadCrashReportDetails(reportId As String)
        Dim reportDetailsTable As DataTable = FetchCrashReportDetails(reportId)

        If reportDetailsTable.Rows.Count > 0 Then
            txtVehicleID1.Text = reportDetailsTable.Rows(0)("VehicleID1").ToString()
            txtVehicleID2.Text = reportDetailsTable.Rows(0)("VehicleID2").ToString()
            txtDriverID1.Text = reportDetailsTable.Rows(0)("DriverID1").ToString()
            txtDriverID2.Text = reportDetailsTable.Rows(0)("DriverID2").ToString()
            txtPolicyID1.Text = reportDetailsTable.Rows(0)("PolicyID1").ToString()
            txtPolicyID2.Text = reportDetailsTable.Rows(0)("PolicyID2").ToString()
            dtReportDate.Value = reportDetailsTable.Rows(0)("ReportDate").ToString()
            txtLocation.Text = reportDetailsTable.Rows(0)("Location").ToString()
            ' txtDescription.Text = reportDetailsTable.Rows(0)("Description").ToString()
            txtTestimonial1.Text = reportDetailsTable.Rows(0)("Testimonial1").ToString()
            txtTestimonial2.Text = reportDetailsTable.Rows(0)("Testimonial2").ToString()
        Else
            MessageBox.Show("Crash report details not found.")
        End If
    End Sub

    Private Function FetchCrashReportDetails(reportId As String) As DataTable
        Dim reportDetailsTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM CrashReports WHERE ReportID = :reportId"

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":reportId", OracleDbType.Int32).Value = Convert.ToInt32(reportId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(reportDetailsTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching crash report details: {ex.Message}")
        End Try

        Return reportDetailsTable
    End Function

    Private Sub AddCrashReport()
        Dim vehicleID1 As Integer
        Dim vehicleID2 As Integer
        Dim driverID1 As Integer
        Dim driverID2 As Integer
        Dim policyID1 As Integer
        Dim policyID2 As Integer
        Dim reportDate As Date = dtReportDate.Value
        Dim location As String = txtLocation.Text
        ' Dim description As String = txtDescription.Text
        Dim testimonial1 As String = txtTestimonial1.Text
        Dim testimonial2 As String = txtTestimonial2.Text

        If Integer.TryParse(txtVehicleID1.Text, vehicleID1) AndAlso
           Integer.TryParse(txtVehicleID2.Text, vehicleID2) AndAlso
           Integer.TryParse(txtDriverID1.Text, driverID1) AndAlso
           Integer.TryParse(txtDriverID2.Text, driverID2) AndAlso
           Integer.TryParse(txtPolicyID1.Text, policyID1) AndAlso
           Integer.TryParse(txtPolicyID2.Text, policyID2) Then

            Dim query As String = "INSERT INTO CrashReports (VehicleID1, VehicleID2, DriverID1, DriverID2, PolicyID1, PolicyID2, ReportDate, Location, Testimonial1, Testimonial2) " &
                                  "VALUES (:vehicleID1, :vehicleID2, :driverID1, :driverID2, :policyID1, :policyID2, :reportDate, :location, :testimonial1, :testimonial2)"

            Try
                Using conn As New OracleConnection(connString)
                    Using cmd As New OracleCommand(query, conn)
                        cmd.Parameters.Add(":vehicleID1", OracleDbType.Int32).Value = vehicleID1
                        cmd.Parameters.Add(":vehicleID2", OracleDbType.Int32).Value = vehicleID2
                        cmd.Parameters.Add(":driverID1", OracleDbType.Int32).Value = driverID1
                        cmd.Parameters.Add(":driverID2", OracleDbType.Int32).Value = driverID2
                        cmd.Parameters.Add(":policyID1", OracleDbType.Int32).Value = policyID1
                        cmd.Parameters.Add(":policyID2", OracleDbType.Int32).Value = policyID2
                        cmd.Parameters.Add(":reportDate", OracleDbType.Date).Value = reportDate
                        cmd.Parameters.Add(":location", OracleDbType.Varchar2).Value = location
                        ' cmd.Parameters.Add(":description", OracleDbType.Varchar2).Value = description
                        cmd.Parameters.Add(":testimonial1", OracleDbType.Varchar2).Value = testimonial1
                        cmd.Parameters.Add(":testimonial2", OracleDbType.Varchar2).Value = testimonial2

                        conn.Open()
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error adding crash report: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Invalid input data.")
        End If
    End Sub

    Private Sub UpdateCrashReport()
        Dim reportID As Integer
        If Integer.TryParse(reportID, reportID) Then
            Dim vehicleID1 As Integer
            Dim vehicleID2 As Integer
            Dim driverID1 As Integer
            Dim driverID2 As Integer
            Dim reportDate As Date = dtReportDate.Value
            Dim location As String = txtLocation.Text
            ' Dim description As String = txtDescription.Text
            Dim testimonial1 As String = txtTestimonial1.Text
            Dim testimonial2 As String = txtTestimonial2.Text

            If Integer.TryParse(txtVehicleID1.Text, vehicleID1) AndAlso
               Integer.TryParse(txtVehicleID2.Text, vehicleID2) AndAlso
               Integer.TryParse(txtDriverID1.Text, driverID1) AndAlso
               Integer.TryParse(txtDriverID2.Text, driverID2) Then
                ' Date.TryParse(txtReportDate.Text, reportDate) Then

                Dim query As String = "UPDATE CrashReports SET VehicleID1 = :vehicleID1, VehicleID2 = :vehicleID2, DriverID1 = :driverID1, " &
                                      "DriverID2 = :driverID2, ReportDate = :reportDate, Location = :location, Description = :description, " &
                                      "Testimonial1 = :testimonial1, Testimonial2 = :testimonial2 WHERE ReportID = :reportID"

                Try
                    Using conn As New OracleConnection(connString)
                        Using cmd As New OracleCommand(query, conn)
                            cmd.Parameters.Add(":vehicleID1", OracleDbType.Int32).Value = vehicleID1
                            cmd.Parameters.Add(":vehicleID2", OracleDbType.Int32).Value = vehicleID2
                            cmd.Parameters.Add(":driverID1", OracleDbType.Int32).Value = driverID1
                            cmd.Parameters.Add(":driverID2", OracleDbType.Int32).Value = driverID2
                            cmd.Parameters.Add(":reportDate", OracleDbType.Date).Value = reportDate
                            cmd.Parameters.Add(":location", OracleDbType.Varchar2).Value = location
                            ' cmd.Parameters.Add(":description", OracleDbType.Varchar2).Value = description
                            cmd.Parameters.Add(":testimonial1", OracleDbType.Varchar2).Value = testimonial1
                            cmd.Parameters.Add(":testimonial2", OracleDbType.Varchar2).Value = testimonial2
                            cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID

                            conn.Open()
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error updating crash report: {ex.Message}")
                End Try
            Else
                MessageBox.Show("Invalid input data.")
            End If
        Else
            MessageBox.Show("Invalid report ID.")
        End If
    End Sub

    Private Sub DeleteCrashReport()
        Dim reportID As Integer
        If Integer.TryParse(reportID, reportID) Then
            Dim query As String = "DELETE FROM CrashReports WHERE ReportID = :reportID"

            Try
                Using conn As New OracleConnection(connString)
                    Using cmd As New OracleCommand(query, conn)
                        cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID

                        conn.Open()
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting crash report: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Invalid report ID.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

    End Sub

    Private Sub dtReportDate_ValueChanged(sender As Object, e As EventArgs) Handles dtReportDate.ValueChanged

    End Sub

    Private Sub lblReportID_Click(sender As Object, e As EventArgs) Handles lblReportID.Click

    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click

    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

    End Sub
End Class
