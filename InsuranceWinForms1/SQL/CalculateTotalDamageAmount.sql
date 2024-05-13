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