CREATE TABLE Drivers (
    DriverID NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
    Name VARCHAR2(100),
    Surname VARCHAR2(100),
    IdentityNumber VARCHAR2(20),
    DateOfBirth DATE,
    LicenseIssuanceDate DATE,
    LicenseValidUntilDate DATE,
    LicenseClass VARCHAR2(20),
    LicenseNumber VARCHAR2(20),
    LicenseIssuedBy VARCHAR2(100),
    Address VARCHAR2(255),
    PhoneNumber VARCHAR2(20),
    PRIMARY KEY (DriverID)
);
