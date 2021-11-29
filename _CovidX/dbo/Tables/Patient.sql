CREATE TABLE [dbo].[Patient]
(
	[PatientID] INT  NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [MobileNumber] NVARCHAR(10) NOT NULL, 
    [SuburbID] INT NOT NULL, 
    [AddressLine1] NVARCHAR(50) NOT NULL, 
    [AddressLine2] NVARCHAR(50) NOT NULL, 
    [MedicalAidStatus] BIT NOT NULL, 
    [MedicalAidPlanID] INT NULL, 
    [MedicalAidNo] NVARCHAR(10) NOT NULL, 
    [DependencyCode] NVARCHAR(10) NOT NULL, 
    [DOB] DATETIME NOT NULL, 
    [UserID] INT NOT NULL, 
    CONSTRAINT [FK_Patient_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Patient_MedicalAidPlan] FOREIGN KEY ([MedicalAidPlanID]) REFERENCES [MedicalAidPlan]([MedicalAidPlanID]), 
     
    CONSTRAINT [FK_Patient_CovidXUser] FOREIGN KEY ([PatientID]) REFERENCES [CovidXUser]([UserID]), 
   

)
