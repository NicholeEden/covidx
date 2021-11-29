CREATE TABLE [dbo].[CovidXUser]
(
	[UserID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [PasswordHash] NVARCHAR(1024) NOT NULL, 
    [Avatar] NVARCHAR(100) NULL, 
    [Active] BIT NOT NULL, 
    --discriminator field
    [UserType] NCHAR(10) NULL
)
