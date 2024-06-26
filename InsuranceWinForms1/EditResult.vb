﻿Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditResult

    Private connString As String = DatabaseSettings.connString
    Private resultId As String

    Public Sub New()
        InitializeComponent()
        Me.resultId = String.Empty
    End Sub

    ' Constructor that accepts the result ID
    Public Sub New(resultId As String)
        InitializeComponent()
        Me.resultId = resultId
    End Sub

    Private Sub EditResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(resultId) Then
            LoadCrashResultDetails(resultId)
        End If
    End Sub

    Private Sub btnAddCrashResult_Click(sender As Object, e As EventArgs) Handles btnAddResult.Click
        AddCrashResult()
    End Sub

    Private Sub btnUpdateCrashResult_Click(sender As Object, e As EventArgs) Handles btnUpdateResult.Click
        UpdateCrashResult()
    End Sub

    Private Sub btnDeleteCrashResult_Click(sender As Object, e As EventArgs) Handles btnDeleteResult.Click
        DeleteCrashResult()
    End Sub

    Private Sub LoadCrashResultDetails(resultId As String)
        Dim resultDetailsTable As DataTable = FetchCrashResultDetails(resultId)
        Console.WriteLine(resultDetailsTable)

        For Each col As DataColumn In resultDetailsTable.Columns
            Console.Write($"{col.ColumnName}" & vbTab)
        Next
        Console.WriteLine()

        For Each row As DataRow In resultDetailsTable.Rows
            For Each item As Object In row.ItemArray
                Console.Write($"{item}" & vbTab)
            Next
            Console.WriteLine()
        Next

        If resultDetailsTable.Rows.Count > 0 Then
            lblResultID.Text = resultDetailsTable.Rows(0)("ResultID").ToString()
            txtReportID.Text = resultDetailsTable.Rows(0)("ReportID").ToString()
            txtVehicleID1.Text = resultDetailsTable.Rows(0)("VehicleID1").ToString()
            txtVehicleID2.Text = resultDetailsTable.Rows(0)("VehicleID2").ToString()
            txtLocation.Text = resultDetailsTable.Rows(0)("Location").ToString()
            txtDamageAmount.Text = resultDetailsTable.Rows(0)("DamageAmount").ToString()
            txtPlate1.Text = resultDetailsTable.Rows(0)("Plate1").ToString()
            txtPlate2.Text = resultDetailsTable.Rows(0)("Plate2").ToString()
            numFaultRateDriver1.Value = resultDetailsTable.Rows(0)("FaultRateDriver1")
            numFaultRateDriver2.Value = resultDetailsTable.Rows(0)("FaultRateDriver2")
            txtViolationCode.Text = resultDetailsTable.Rows(0)("ViolationCode").ToString()
            txtViolationNotification.Text = resultDetailsTable.Rows(0)("ViolationNotification").ToString()
        Else
            MessageBox.Show("Crash result details not found.")
        End If
    End Sub

    Private Function FetchCrashResultDetails(resultId As String) As DataTable
        Dim resultDetailsTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                ' Dim query As String = "SELECT * FROM CrashResults WHERE ResultID = :resultId"
                'Dim query As String = "
                '    SELECT cr.*, crp.Location
                '    FROM CrashResults cr
                '    INNER JOIN CrashReports crp ON cr.ReportID = crp.ReportID
                '    WHERE cr.ResultID = :resultId
                '"
                'Dim query As String = "
                '    SELECT cr.*, crp.Location, v.Plate
                '    FROM CrashResults cr
                '    INNER JOIN CrashReports crp ON cr.ReportID = crp.ReportID
                '    INNER JOIN Vehicles v ON crp.VehicleID1 = v.VehicleID
                '    WHERE cr.ResultID = :resultId
                '"
                Dim query As String = "
                    SELECT cr.*, crp.Location, v1.Plate AS Plate1, v2.Plate AS Plate2
                    FROM CrashResults cr
                    INNER JOIN CrashReports crp ON cr.ReportID = crp.ReportID
                    INNER JOIN Vehicles v1 ON crp.VehicleID1 = v1.VehicleID
                    INNER JOIN Vehicles v2 ON crp.VehicleID2 = v2.VehicleID
                    WHERE cr.ResultID = :resultId
                "

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":resultId", OracleDbType.Int32).Value = Convert.ToInt32(resultId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(resultDetailsTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching crash result details: {ex.Message}")
        End Try

        Return resultDetailsTable
    End Function

    Private Sub AddCrashResult()
        Dim reportID As Integer
        Dim vehicleID1 As Integer
        Dim vehicleID2 As Integer
        Dim faultRateDriver1 As Decimal
        Dim faultRateDriver2 As Decimal
        Dim damageAmount As Decimal
        Dim violationCode As String = txtViolationCode.Text
        Dim violationNotification As String = txtViolationNotification.Text


        If Integer.TryParse(txtReportID.Text, reportID) AndAlso
           Integer.TryParse(txtVehicleID1.Text, vehicleID1) AndAlso
           Integer.TryParse(txtVehicleID2.Text, vehicleID2) AndAlso
           Decimal.TryParse(numFaultRateDriver1.Value, faultRateDriver1) AndAlso
           Decimal.TryParse(numFaultRateDriver2.Value, faultRateDriver2) AndAlso
           Decimal.TryParse(txtDamageAmount.Text, damageAmount) Then

            Dim query As String = "INSERT INTO CrashResults (ReportID, VehicleID1, VehicleID2, FaultRateDriver1, FaultRateDriver2, " &
                "DamageAmount, ViolationCode, ViolationNotification) " &
                "VALUES (:reportID, :vehicleID1, :vehicleID2, :faultRateDriver1, :faultRateDriver2, :damageAmount, :violationCode, :violationNotification )"

            'Try
            Using conn As New OracleConnection(connString)
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID
                    cmd.Parameters.Add(":vehicleID1", OracleDbType.Int32).Value = vehicleID1
                    cmd.Parameters.Add(":vehicleID2", OracleDbType.Int32).Value = vehicleID2
                    cmd.Parameters.Add(":faultRateDriver1", OracleDbType.Decimal).Value = faultRateDriver1
                    cmd.Parameters.Add(":faultRateDriver2", OracleDbType.Decimal).Value = faultRateDriver2
                    cmd.Parameters.Add(":damageAmount", OracleDbType.Decimal).Value = damageAmount
                    cmd.Parameters.Add(":violationCode", OracleDbType.Varchar2).Value = violationCode
                    cmd.Parameters.Add(":violationNotification", OracleDbType.Varchar2).Value = violationNotification
                    'cmd.Parameters.Add(":violationCode", OracleDbType.Varchar2).Value = violationCode

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                End Using
            End Using
            'Catch ex As Exception
            '    MessageBox.Show($"Error adding crash result: {ex.Message}")
            'End Try
        Else
            MessageBox.Show("Invalid input data.")
        End If
    End Sub

    Private Sub UpdateCrashResult()
        Dim resultID As Integer
        If Integer.TryParse(resultID, resultID) Then
            Dim reportID As Integer
            Dim damageAmount As Decimal
            Dim violationCode As String = txtViolationCode.Text

            If Integer.TryParse(txtReportID.Text, reportID) AndAlso
               Decimal.TryParse(txtDamageAmount.Text, damageAmount) Then

                Dim query As String = "UPDATE CrashResults SET ReportID = :reportID, DamageAmount = :damageAmount, " &
                                      "ViolationCode = :violationCode WHERE ResultID = :resultID"

                Try
                    Using conn As New OracleConnection(connString)
                        Using cmd As New OracleCommand(query, conn)
                            cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID
                            cmd.Parameters.Add(":damageAmount", OracleDbType.Decimal).Value = damageAmount
                            cmd.Parameters.Add(":violationCode", OracleDbType.Varchar2).Value = violationCode
                            cmd.Parameters.Add(":resultID", OracleDbType.Int32).Value = resultID

                            conn.Open()
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error updating crash result: {ex.Message}")
                End Try
            Else
                MessageBox.Show("Invalid input data.")
            End If
        Else
            MessageBox.Show("Invalid result ID.")
        End If
    End Sub

    Private Sub DeleteCrashResult()
        Dim resultID As Integer
        If Integer.TryParse(resultID, resultID) Then
            Dim query As String = "DELETE FROM CrashResults WHERE ResultID = :resultID"

            Try
                Using conn As New OracleConnection(connString)
                    Using cmd As New OracleCommand(query, conn)
                        cmd.Parameters.Add(":resultID", OracleDbType.Int32).Value = resultID

                        conn.Open()
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting crash result: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Invalid result ID.")
        End If
    End Sub

End Class
