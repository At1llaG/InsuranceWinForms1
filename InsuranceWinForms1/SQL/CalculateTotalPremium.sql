CREATE Or REPLACE FUNCTION CalculateTotalPremium RETURN NUMBER AS
    totalPremium NUMBER := 0;
BEGIN
    For policyRec IN (SELECT Premium FROM Policies) LOOP
        totalPremium := totalPremium + policyRec.Premium;
    End Loop;

    Return totalPremium;
End;
/