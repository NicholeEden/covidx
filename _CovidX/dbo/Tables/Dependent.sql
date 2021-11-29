CREATE TABLE [dbo].[Dependent]
(
	[DependentID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [AddressLine1] NVARCHAR(50) NOT NULL, 
    [AddressLine2] NVARCHAR(50) NULL, 
    [SuburbID] INT NOT NULL, 
    [DOB] DATETIME NOT NULL, 
    [MedicalAidPlanID] INT NULL, 
    [MedicalAidStatus] BIT NOT NULL, 
    [MobileNumber] NVARCHAR(10) NOT NULL, 
    [DependentTypeID] INT NOT NULL, 
    [DependencyCode] NVARCHAR(10) NOT NULL, 
    [MainMemberID] INT NOT NULL, 
    CONSTRAINT [FK_Dependent_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Dependent_MedicalAidPlan] FOREIGN KEY ([MedicalAidPlanID]) REFERENCES [MedicalAidPlan]([MedicalAidPlanID]), 
    CONSTRAINT [FK_Dependent_DependentType] FOREIGN KEY ([DependentTypeID]) REFERENCES [DependentType]([DependentTypeID]), 
    CONSTRAINT [FK_Dependent_Patient] FOREIGN KEY ([MainMemberID]) REFERENCES [Patient]([PatientID])
)
