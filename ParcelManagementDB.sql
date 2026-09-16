/* =========================================================
   Parcel Receiving and Collection Management System
   Fresh Database Setup Script
   ========================================================= */

USE master;
GO

/* ---------------------------------------------------------
   1. Create database if it does not already exist
   --------------------------------------------------------- */

IF DB_ID('ParcelManagementDB') IS NULL
BEGIN
    CREATE DATABASE ParcelManagementDB;
END
GO

USE ParcelManagementDB;
GO


/* =========================================================
   2. USER TABLE
   ========================================================= */

CREATE TABLE dbo.[USER]
(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL,
    Phone VARCHAR(20) NULL,
    DateOfBirth DATE NULL,
    Gender VARCHAR(20) NULL,
    Address VARCHAR(255) NULL
);
GO


/* =========================================================
   3. ADMIN TABLE
   ========================================================= */

CREATE TABLE dbo.ADMIN
(
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
    Name VARCHAR(100) NULL
);
GO


/* ---------------------------------------------------------
   Default Admin Account
   Username: admin
   Password: 1234
   --------------------------------------------------------- */

INSERT INTO dbo.ADMIN
(
    Username,
    Password,
    Name
)
VALUES
(
    'admin',
    '1234',
    'System Administrator'
);
GO


/* =========================================================
   4. PARCEL TABLE
   ========================================================= */

CREATE TABLE dbo.PARCEL
(
    ParcelID INT IDENTITY(1,1) PRIMARY KEY,

    TrackingNumber VARCHAR(100) NOT NULL UNIQUE,

    CourierName VARCHAR(100) NOT NULL,

    SenderName VARCHAR(100) NULL,

    ReceivedDate DATE NOT NULL,

    ExpectedCollectionDate DATE NULL,

    Status VARCHAR(30) NOT NULL,

    UserID INT NOT NULL,

    LocationID INT NULL,

    CollectionRequestDate DATE NULL,

    CollectionStatus VARCHAR(30) NULL,

    VerificationStatus VARCHAR(30) NULL,

    VerifiedBy INT NULL,

    VerificationDate DATE NULL,

    CollectionDate DATE NULL,

    Remarks VARCHAR(255) NULL,

    /* Recipient/User relationship */
    FOREIGN KEY (UserID)
        REFERENCES dbo.[USER](UserID),

    /* Admin verification relationship */
    FOREIGN KEY (VerifiedBy)
        REFERENCES dbo.ADMIN(AdminID)
);
GO


/* =========================================================
   5. OPTIONAL DEMO USER
   ========================================================= */

INSERT INTO dbo.[USER]
(
    Name,
    Email,
    Password,
    Role,
    Phone,
    DateOfBirth,
    Gender,
    Address
)
VALUES
(
    'Demo User',
    'demo@gmail.com',
    '1234',
    'User',
    NULL,
    '2000-01-01',
    'Female',
    'Dhaka'
);
GO


/* =========================================================
   6. OPTIONAL DEMO PARCEL
   ========================================================= */

INSERT INTO dbo.PARCEL
(
    TrackingNumber,
    CourierName,
    SenderName,
    ReceivedDate,
    ExpectedCollectionDate,
    Status,
    UserID,
    LocationID,
    CollectionRequestDate,
    CollectionStatus,
    VerificationStatus,
    VerifiedBy,
    VerificationDate,
    CollectionDate,
    Remarks
)
VALUES
(
    'TRK10001',
    'Sundarban Courier',
    'ABC Online Shop',
    CAST(GETDATE() AS DATE),
    DATEADD(DAY, 3, CAST(GETDATE() AS DATE)),
    'Pending',
    1,
    101,
    NULL,
    NULL,
    NULL,
    NULL,
    NULL,
    NULL,
    'Demo parcel'
);
GO


/* =========================================================
   7. CHECK DATABASE
   ========================================================= */

SELECT * FROM dbo.[USER];

SELECT * FROM dbo.ADMIN;

SELECT * FROM dbo.PARCEL;
GO