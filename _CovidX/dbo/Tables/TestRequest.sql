CREATE TABLE [dbo].[TestRequest]
(
	[TestRequestID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [PatientID] INT NULL, 
    [DependentID] INT NOT NULL, 
    [RequestDate] DATETIME NOT NULL, 
    [RequestStatus] NVARCHAR(50) NOT NULL, 
    [TestAddress1] NVARCHAR(50) NOT NULL, 
    [TestAddress2] NVARCHAR(50) NULL, 
    [SuburbID] INT NOT NULL, 
    [NurseID] INT NULL, 
    [DateAssigned] DATE NULL, 
    [TimeSlotAssigned] DATETIME NULL, 
   
    CONSTRAINT [FK_TestRequest_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_TestRequest_Nurse] FOREIGN KEY ([NurseID]) REFERENCES [Nurse]([NurseID]), 
    CONSTRAINT [FK_TestRequest_Dependent] FOREIGN KEY ([DependentID]) REFERENCES [Dependent]([DependentID]), 
    CONSTRAINT [FK_TestRequest_Patient] FOREIGN KEY ([PatientID]) REFERENCES [Patient]([PatientID]),
  
)
