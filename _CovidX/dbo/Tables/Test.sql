CREATE TABLE [dbo].[Test]
(
	[TestID] INT NOT NULL PRIMARY KEY, 
    [TestRequestID] INT NOT NULL, 
    [BarCode] NVARCHAR(50) NOT NULL, 
    [Temperature] NVARCHAR(10) NOT NULL, 
    [BloodPressure] NVARCHAR(10) NOT NULL, 
    [OxygenLevel] NVARCHAR(10) NOT NULL, 
    [TestDate] DATETIME NOT NULL, 
    [TestTime] DATETIME NOT NULL, 
    [TestResult] NVARCHAR(50) NULL, 
    [ResultDate] DATETIME NULL, 
    [LabUserID] INT NULL, 
    CONSTRAINT [FK_Test_LabUser] FOREIGN KEY ([LabUserID]) REFERENCES [LabUser]([LabUserID]), 
    CONSTRAINT [FK_Test_TestRequest] FOREIGN KEY ([TestRequestID]) REFERENCES [TestRequest]([TestRequestID])
)
