Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class EditCustomer

    Private connString As String = DatabaseSettings.connString
    Private customerId As String

    Public Sub New()
        ' Initialize the component
        InitializeComponent()

        ' Set the customer ID to an empty string or any default value as needed
        Me.customerId = String.Empty
    End Sub

    ' Constructor that accepts the customer ID
    Public Sub New(customerId As String)
        ' Initialize the component
        InitializeComponent()

        ' Store the customer ID
        Me.customerId = customerId
    End Sub

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(customerId) Then
            Dim customerDetails As DataTable = FetchCustomerDetails(customerId)

            If customerDetails.Rows.Count > 0 Then
                ' Retrieve customer details from the DataTable
                Dim firstName As String = customerDetails.Rows(0)("FirstName").ToString()
                Dim lastName As String = customerDetails.Rows(0)("LastName").ToString()
                Dim email As String = customerDetails.Rows(0)("Email").ToString()
                Dim phone As String = customerDetails.Rows(0)("Phone").ToString()
                Dim address As String = customerDetails.Rows(0)("Address").ToString()

                ' Populate the text boxes with the retrieved values
                txtFirstName.Text = firstName
                txtLastName.Text = lastName
                txtEmail.Text = email
                txtPhone.Text = phone
                txtAddress.Text = address
                lblCustomerId.Text = customerId
            Else
                MessageBox.Show("Customer details not found.")
            End If
        End If
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim address As String = txtAddress.Text

        ' Insert the customer into the database
        InsertCustomer(firstName, lastName, email, phone, address)
    End Sub

    Private Sub InsertCustomer(firstName As String, lastName As String, email As String, phone As String, address As String)
        Dim query As String = "INSERT INTO Customers (FirstName, LastName, Email, Phone, Address) VALUES (:firstName, :lastName, :email, :phone, :address) RETURNING CustomerID INTO :newCustomerId"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = firstName
                cmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = lastName
                cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email
                cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone
                cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
                cmd.Parameters.Add(":newCustomerId", OracleDbType.Int32).Direction = ParameterDirection.Output

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Retrieve the returned value as OracleDecimal
                    Dim returnedValue As OracleDecimal = DirectCast(cmd.Parameters(":newCustomerId").Value, OracleDecimal)

                    ' Check if the returned value is not null
                    If Not returnedValue.IsNull Then
                        ' Convert the OracleDecimal to integer
                        Dim newCustomerId As Integer = returnedValue.ToInt32()
                        lblCustomerId.Text = newCustomerId.ToString()
                    Else
                        lblCustomerId.Text = "N/A"
                    End If

                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error inserting data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Dim customerID As Integer
        If Integer.TryParse(lblCustomerId.Text, customerID) Then
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text
            Dim email As String = txtEmail.Text
            Dim phone As String = txtPhone.Text
            Dim address As String = txtAddress.Text

            ' Update the customer in the database
            UpdateCustomer(customerID, firstName, lastName, email, phone, address)
        Else
            MessageBox.Show("Invalid customer ID.")
        End If
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Dim customerID As Integer
        If Integer.TryParse(lblCustomerId.Text, customerID) Then
            ' Delete the customer from the database
            DeleteCustomer(customerID)
        Else
            MessageBox.Show("Invalid customer ID.")
        End If
    End Sub

    Private Sub UpdateCustomer(customerID As Integer, firstName As String, lastName As String, email As String, phone As String, address As String)
        Dim query As String = "UPDATE Customers SET FirstName = :firstName, LastName = :lastName, Email = :email, Phone = :phone, Address = :address WHERE CustomerID = :customerID"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = firstName
                cmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = lastName
                cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email
                cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone
                cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
                cmd.Parameters.Add(":customerID", OracleDbType.Int32).Value = customerID

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) updated successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error updating data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteCustomer(customerID As Integer)
        Dim query As String = "DELETE FROM Customers WHERE CustomerID = :customerID"

        Using conn As New OracleConnection(connString)
            Using cmd As New OracleCommand(query, conn)
                cmd.Parameters.Add(":customerID", OracleDbType.Int32).Value = customerID

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show($"Error deleting data: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Function FetchCustomerDetails(customerId As String) As DataTable
        Dim customerDetails As New DataTable()

        Try
            Using conn As New OracleConnection(connString)
                conn.Open()

                Dim query As String = "SELECT * FROM Customers WHERE CustomerID = :customerId"

                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = Convert.ToInt32(customerId)

                    Using adapter As New OracleDataAdapter(cmd)
                        adapter.Fill(customerDetails)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching customer details: {ex.Message}")
        End Try

        Return customerDetails
    End Function


End Class