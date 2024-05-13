Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditResults

    Private connString As String = DatabaseSettings.connString
    Private resultId As String

    Public Sub New()
        ' Initialize the component
        InitializeComponent()

        ' Set the result ID to an empty string or any default value as needed
        Me.resultId = String.Empty
    End Sub

    ' Constructor that accepts the result ID
    Public Sub New(resultId As String)
        ' Initialize the component
        InitializeComponent()

        ' Store the result ID
        Me.resultId = resultId
    End Sub

    Private Sub EditResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(resultId) Then
            LoadCrashResultDetails(resultId)
        End If
    End Sub

    'Private Sub btnAddCrashResult_Click(sender As Object, e As EventArgs) Handles btnAddCrashResult.Click
    '    AddCrashResult()
    'End Sub

    'Private Sub btnUpdateCrashResult_Click(sender As Object, e As EventArgs) Handles btnUpdateCrashResult.Click
    '    UpdateCrashResult()
    'End Sub

    'Private Sub btnDeleteCrashResult_Click(sender As Object, e As EventArgs) Handles btnDeleteCrashResult.Click
    '    DeleteCrashResult()
    'End Sub

    Private Sub LoadCrashResultDetails(resultId As String)
        Dim resultDetailsTable As DataTable = FetchCrashResultDetails(resultId)

        'If resultDetailsTable.Rows.Count > 0 Then
        '    txtReportID.Text = resultDetailsTable.Rows(0)("ReportID").ToString()
        '    txtDamageAmount.Text = resultDetailsTable.Rows(0)("DamageAmount").ToString()
        '    txtViolationCode.Text = resultDetailsTable.Rows(0)("ViolationCode").ToString()
        'Else
        '    MessageBox.Show("Crash result details not found.")
        'End If
    End Sub

    Private Function FetchCrashResultDetails(resultId As String) As DataTable
        Dim resultDetailsTable As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM CrashResults WHERE ResultID = :resultId"

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

    'Private Sub AddCrashResult()
    '    Dim reportID As Integer
    '    Dim damageAmount As Decimal
    '    Dim violationCode As String = txtViolationCode.Text

    '    If Integer.TryParse(txtReportID.Text, reportID) AndAlso
    '       Decimal.TryParse(txtDamageAmount.Text, damageAmount) Then

    '        Dim query As String = "INSERT INTO CrashResults (ReportID, DamageAmount, ViolationCode) " &
    '                              "VALUES (:reportID, :damageAmount, :violationCode)"

    '        Try
    '            Using conn As New OracleConnection(connString)
    '                Using cmd As New OracleCommand(query, conn)
    '                    cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID
    '                    cmd.Parameters.Add(":damageAmount", OracleDbType.Decimal).Value = damageAmount
    '                    cmd.Parameters.Add(":violationCode", OracleDbType.Varchar2).Value = violationCode

    '                    conn.Open()
    '                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
    '                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show($"Error adding crash result: {ex.Message}")
    '        End Try
    '    Else
    '        MessageBox.Show("Invalid input data.")
    '    End If
    'End Sub

    'Private Sub UpdateCrashResult()
    '    Dim resultID As Integer
    '    If Integer.TryParse(resultID, resultID) Then
    '        Dim reportID As Integer
    '        Dim damageAmount As Decimal
    '        Dim violationCode As String = txtViolationCode.Text

    '        If Integer.TryParse(txtReportID.Text, reportID) AndAlso
    '           Decimal.TryParse(txtDamageAmount.Text, damageAmount) Then

    '            Dim query As String = "UPDATE CrashResults SET ReportID = :reportID, DamageAmount = :damageAmount, " &
    '                                  "ViolationCode = :violationCode WHERE ResultID = :resultID"

    '            Try
    '                Using conn As New OracleConnection(connString)
    '                    Using cmd As New OracleCommand(query, conn)
    '                        cmd.Parameters.Add(":reportID", OracleDbType.Int32).Value = reportID
    '                        cmd.Parameters.Add(":damageAmount", OracleDbType.Decimal).Value = damageAmount
    '                        cmd.Parameters.Add(":violationCode", OracleDbType.Varchar2).Value = violationCode
    '                        cmd.Parameters.Add(":resultID", OracleDbType.Int32).Value = resultID

    '                        conn.Open()
    '                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
    '                        MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
    '                    End Using
    '                End Using
    '            Catch ex As Exception
    '                MessageBox.Show($"Error updating crash result: {ex.Message}")
    '            End Try
    '        Else
    '            MessageBox.Show("Invalid input data.")
    '        End If
    '    Else
    '        MessageBox.Show("Invalid result ID.")
    '    End If
    'End Sub

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
