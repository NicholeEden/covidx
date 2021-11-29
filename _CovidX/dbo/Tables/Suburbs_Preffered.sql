CREATE TABLE [dbo].[Suburbs_Preffered]
(
	[SuburbID] INT NOT NULL, 
    [NurseID] INT NOT NULL, 
    CONSTRAINT [FK_Suburbs_Preffered_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Suburbs_Preffered_Nurse] FOREIGN KEY ([NurseID]) REFERENCES [Nurse]([NurseID]),
    PRIMARY KEY(SuburbID,NurseID)

)
