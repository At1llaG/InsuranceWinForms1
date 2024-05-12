Public Class Start
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        ShowResults.Show()

    End Sub

    Private Sub btnClaims_Click(sender As Object, e As EventArgs) Handles btnClaims.Click
        Claims.Show()
    End Sub
End Class
