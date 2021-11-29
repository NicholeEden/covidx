CREATE TABLE [dbo].[MedicalAidPlan]
(
	[MedicalAidPlanID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Description] NVARCHAR(50) NOT NULL, 
    [MedicalAidSchemeID] INT NOT NULL, 
    CONSTRAINT [FK_MedicalAidPlan_MedicalAidScheme] FOREIGN KEY ([MedicalAidSchemeID]) REFERENCES [MedicalAidScheme](MedicalAidSchemeID)
)
