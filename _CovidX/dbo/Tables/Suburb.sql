CREATE TABLE [dbo].[Suburb]
(
	[SuburbID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [SuburbName] NVARCHAR(50) NOT NULL, 
    [PostalCode] NVARCHAR(10) NOT NULL, 
    [CityID] INT NOT NULL, 
    CONSTRAINT [FK_Suburb_City] FOREIGN KEY ([CityID]) REFERENCES [City]([CityID])
)
