CREATE TABLE [dbo].[Nurse]
(
	[NurseID] INT NOT NULL PRIMARY KEY, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [MobileNumber] NVARCHAR(10) NOT NULL, 
    [YearQualified] DATETIME NOT NULL, 
    [Rank] NVARCHAR(50) NOT NULL, 
    [Qualification] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Nurse_CovidXUser] FOREIGN KEY ([NurseID]) REFERENCES [CovidXUser]([UserID])

)
