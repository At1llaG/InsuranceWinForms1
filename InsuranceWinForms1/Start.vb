Imports Oracle.ManagedDataAccess.Client

Public Class Start
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers.Show()
    End Sub

    Private Sub btnVehicles_Click(sender As Object, e As EventArgs) Handles btnVehicles.Click
        EditVehicles.Show()
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
        ShowResults.Show()

    End Sub

    Private Sub btnClaims_Click(sender As Object, e As EventArgs) Handles btnClaims.Click
        ' Claims.Show()
    End Sub

    Private Sub btnInitializeCreate_Click(sender As Object, e As EventArgs) Handles btnInitializeCreate.Click
        ' Create an instance of the DatabaseInitialize class
        Dim dbInitializer As New DatabaseInitialize()

        ' Call the InitializeCreate method
        Dim success As Boolean = dbInitializer.InitializeCreate()

        ' Check the success status
        If success Then
            ' Initialization succeeded
            MessageBox.Show("Database initialization successful.")
        Else
            ' Initialization failed
            MessageBox.Show("Database initialization failed.")
        End If
    End Sub

    Private Sub btnInitializeDrop_Click(sender As Object, e As EventArgs) Handles btnInitializeDrop.Click
        ' Create an instance of the DatabaseInitialize class
        Dim dbInitializer As New DatabaseInitialize()

        ' Call the InitializeCreate method
        Dim success As Boolean = dbInitializer.InitializeDrop()

        ' Check the success status
        If success Then
            ' Initialization succeeded
            MessageBox.Show("Database DROP initialization successful.")
        Else
            ' Initialization failed
            MessageBox.Show("Database DROP initialization failed.")
        End If
    End Sub

    Private Sub btnAddTestData_Click(sender As Object, e As EventArgs) Handles btnAddTestData.Click
        ' Create an instance of the DatabaseInitialize class
        Dim dbTestDataPopulator As New DatabaseAddTestData()

        ' Call the InitializeCreate method
        dbTestDataPopulator.PopulateTestData()

    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        EditCustomer.Show()
    End Sub

    Public Function CalculateTotalPremium() As Decimal
        Dim totalPremium As Decimal = 0

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()
                Using cmd As New OracleCommand("BEGIN :result := CalculateTotalPremium(); END;", conn)
                    cmd.Parameters.Add("result", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue
                    cmd.ExecuteNonQuery()
                    totalPremium = Convert.ToDecimal(cmd.Parameters("result").Value)
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return totalPremium
    End Function


End Class
