CREATE Or REPLACE FUNCTION CalculateTotalPremium RETURN NUMBER AS
    totalPremium NUMBER := 0;
BEGIN
    -- Use a cursor to fetch the premiums of all policies
    For policyRec IN (SELECT Premium FROM Policies) LOOP
        -- Add each premium to the total
        totalPremium := totalPremium + policyRec.Premium;
    End Loop;

    -- Return the total premium
    Return totalPremium;
End;
/