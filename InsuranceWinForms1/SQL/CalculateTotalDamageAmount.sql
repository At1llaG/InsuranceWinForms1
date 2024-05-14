CREATE Or REPLACE FUNCTION CalculateTotalDamageAmount RETURN NUMBER AS
    totalDamageAmount NUMBER := 0;
BEGIN
    For resultRec IN (SELECT DamageAmount FROM CrashResults) LOOP
        totalDamageAmount := totalDamageAmount + resultRec.DamageAmount;
    End Loop;

    Return totalDamageAmount;
End;
/