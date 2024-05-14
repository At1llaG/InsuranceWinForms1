Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class Start

    Private connString As String = DatabaseSettings.connString

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalPremium.Text = CalculateTotalPremium().ToString() & "$"
        Console.WriteLine(CalculateTotalPremium().ToString())
        lblTotalDamages.Text = CalculateTotalDamageAmount().ToString()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers.Show()
    End Sub

    Private Sub btnVehicles_Click(sender As Object, e As EventArgs) Handles btnVehicles.Click
        Vehicles.Show()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Drivers.Show()
    End Sub

    Private Sub btnPolicies_Click(sender As Object, e As EventArgs) Handles btnPolicies.Click
        Policies.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Reports.Show()

    End Sub

    Private Sub btnDisputes_Click(sender As Object, e As EventArgs) Handles btnDisputes.Click
        Disputes.Show()

    End Sub
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Results.Show()

    End Sub

    Private Sub btnClaims_Click(sender As Object, e As EventArgs) Handles btnClaims.Click
        ' Claims.Show()
    End Sub

    Private Sub btnInitializeCreate_Click(sender As Object, e As EventArgs) Handles btnInitializeCreate.Click
        Dim dbInitializer As New DatabaseInitialize()

        Dim success As Boolean = dbInitializer.InitializeCreate()

        If success Then
            MessageBox.Show("Database initialization successful.")
        Else
            MessageBox.Show("Database initialization failed.")
        End If
    End Sub

    Private Sub btnInitializeDrop_Click(sender As Object, e As EventArgs) Handles btnInitializeDrop.Click
        Dim dbInitializer As New DatabaseInitialize()

        Dim success As Boolean = dbInitializer.InitializeDrop()

        If success Then
            MessageBox.Show("Database DROP initialization successful.")
        Else
            MessageBox.Show("Database DROP initialization failed.")
        End If
    End Sub

    Private Sub btnAddTestData_Click(sender As Object, e As EventArgs) Handles btnAddTestData.Click
        Dim dbTestDataPopulator As New DatabaseAddTestData()

        dbTestDataPopulator.PopulateTestData()

    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        EditCustomer.Show()
    End Sub

    Public Function CalculateTotalPremium() As Decimal
        Dim totalPremium As Decimal = 0
        ' SELECT CalculateTotalPremium() AS Total_Premium FROM dual;

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()
                Using cmd As New OracleCommand("BEGIN :result := CalculateTotalPremium(); END;", conn)
                    cmd.Parameters.Add("result", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue
                    cmd.ExecuteNonQuery()
                    Dim oracleDecimalValue As OracleDecimal = DirectCast(cmd.Parameters("result").Value, OracleDecimal)
                    totalPremium = oracleDecimalValue.Value
                    ' totalPremium = Convert.ToDecimal(cmd.Parameters("result").Value)
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return totalPremium
    End Function

    Public Function CalculateTotalDamageAmount() As Decimal
        Dim totalDamageAmount As Decimal = 0

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT SUM(DamageAmount) FROM CrashResults"

                Using cmd As New OracleCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        totalDamageAmount = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error calculating total damage amount: {ex.Message}")
        End Try

        Return totalDamageAmount
    End Function


End Class
