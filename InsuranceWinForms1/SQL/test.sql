SELECT * FROM STUDENT11;


SELECT * FROM Customers;


SELECT * FROM Vehicles;

Select * from Policies;

SELECT * from Drivers;

SELECT * from CrashReports;

SELECT * from CrashResults;

INSERT INTO CrashReports (VehicleID1, VehicleID2, DriverID1, DriverID2, PolicyID1, PolicyID2, ReportDate, Location, Description, Testimonial1, Testimonial2)
VALUES (1, 2, 1, 2, 1, 2, TO_DATE('2024-05-01', 'YYYY-MM-DD'), 'Main St', 'Car accident on Main St', 'Driver 1 testimonial', 'Driver 2 testimonial');


BEGIN :result := CalculateTotalPremium(); END;

SELECT CalculateTotalPremium() AS Total_Premium FROM dual;

SET SERVEROUTPUT ON;
DECLARE
    totalPremium NUMBER;
BEGIN
    totalPremium := CalculateTotalPremium();
    DBMS_OUTPUT.PUT_LINE('Total Premium: ' || totalPremium);
END;

SELECT cr.*, crp.Location, v1.Plate AS Plate1, v2.Plate AS Plate2
FROM CrashResults cr
INNER JOIN CrashReports crp ON cr.ReportID = crp.ReportID
INNER JOIN Vehicles v1 ON crp.VehicleID1 = v1.VehicleID
INNER JOIN Vehicles v2 ON crp.VehicleID2 = v2.VehicleID
WHERE cr.ResultID = :resultId




CREATE Or REPLACE FUNCTION CalculateTotalDamageAmount RETURN NUMBER AS
    totalDamageAmount NUMBER := 0;
BEGIN
    -- Use a cursor to fetch the premiums of all policies
    For resultRec IN (SELECT DamageAmount FROM CrashResults) LOOP
        -- Add each premium to the total
        totalDamageAmount := totalDamageAmount + resultRec.DamageAmount;
    End Loop;

    -- Return the total premium
    Return totalDamageAmount;
End;
/

SELECT CalculateTotalDamageAmount() AS Total_Damage_Amount FROM dual;



'Dim name As String = txtName.Text
        'Dim surname As String = txtSurname.Text
        'Dim identityNumber As String = txtIdentityNumber.Text
        'Dim dob As Date = dobPicker.Value
        'Dim issuanceDate As Date = issuanceDatePicker.Value
        'Dim validUntilDate As Date = validUntilDatePicker.Value
        'Dim licenseClass As String = txtLicenseClass.Text
        'Dim licenseNumber As String = txtLicenseNumber.Text
        'Dim issuedBy As String = txtIssuedBy.Text
        'Dim address As String = txtAddress.Text
        'Dim phoneNumber As String = txtPhoneNumber.Text

        'Dim query As String = "INSERT INTO Drivers (Name, Surname, IdentityNumber, DateOfBirth, LicenseIssuanceDate, LicenseValidUntilDate, LicenseClass, LicenseNumber, LicenseIssuedBy, Address, PhoneNumber) " &
        '                      "VALUES (:name, :surname, :identityNumber, :dob, :issuanceDate, :validUntilDate, :licenseClass, :licenseNumber, :issuedBy, :address, :phoneNumber)"

        'Using cmd As OracleCommand = New OracleCommand(query, conn)
        '    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name
        '    cmd.Parameters.Add(":surname", OracleDbType.Varchar2).Value = surname
        '    cmd.Parameters.Add(":identityNumber", OracleDbType.Varchar2).Value = identityNumber
        '    cmd.Parameters.Add(":dob", OracleDbType.Date).Value = dob
        '    cmd.Parameters.Add(":issuanceDate", OracleDbType.Date).Value = issuanceDate
        '    cmd.Parameters.Add(":validUntilDate", OracleDbType.Date).Value = validUntilDate
        '    cmd.Parameters.Add(":licenseClass", OracleDbType.Varchar2).Value = licenseClass
        '    cmd.Parameters.Add(":licenseNumber", OracleDbType.Varchar2).Value = licenseNumber
        '    cmd.Parameters.Add(":issuedBy", OracleDbType.Varchar2).Value = issuedBy
        '    cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address
        '    cmd.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber

        '    Try
        '        conn.Open()
        '        cmd.ExecuteNonQuery()
        '        MessageBox.Show("Driver added successfully!")
        '    Catch ex As Exception
        '        MessageBox.Show("Failed to add driver: " & ex.Message, "Error")
        '    Finally
        '        conn.Close()
        '    End Try
        'End Using