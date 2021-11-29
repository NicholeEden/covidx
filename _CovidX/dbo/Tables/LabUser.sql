CREATE TABLE [dbo].[LabUser]
(
	[LabUserID] INT  NOT NULL PRIMARY KEY, 
	[IDNumber] NVARCHAR(13) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [MobileNumber] NVARCHAR(10) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [Qualification] NVARCHAR(50) NOT NULL, 
    --Creates a surrogate key
    CONSTRAINT [FK_LabUser_CovidXUser] FOREIGN KEY ([LabUserID]) REFERENCES [CovidXUser](UserID)
)
