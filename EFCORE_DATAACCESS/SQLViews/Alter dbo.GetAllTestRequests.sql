USE [CovidXSQLDB]
GO

/****** Object: View [dbo].[GetAllTestRequests] Script Date: 2021/10/19 12:22:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- create a view to get test request details
CREATE OR ALTER   VIEW GetAllTestRequests

AS
	SELECT TR.TestRequestId
	,TR.PatientId AS RequesterID
	,CASE 
		-- if the dependent ID is null, use the patient ID
		WHEN TR.DependentId IS NULL THEN TR.PatientId
		-- or else just use dependant ID as the test subject
		ELSE TR.DependentId END AS TestSubjectID
		-- var testsubject = TestRequest.DependentId ?? TestRequest.PatientId
	,
	CASE
		--IF TestSubjectID is PatientID
		WHEN TR.DependentId IS NULL THEN P.FirstName + ' ' +  P.LastName 
		--else if TestSubjectID is DependentID
			ELSE D.FirstName + ' ' + D.LastName 
		END AS FullName

		

	,TR.RequestDate
	,TR.RequestStatus,
	S.SuburbName,
	P.AddressLine1 AS TestAddress1,
	P.AddressLine2 AS TestAddress2,
	N.FirstName + ' ' + N.LastName AS NurseName,
	TR.DateAssigned,
	TR.StartTime,
	TR.EndTime
	
	
FROM TestRequests TR

--Join Suburb
	JOIN Suburbs S ON TR.SuburbId = S.SuburbId  
	JOIN Patients P ON TR.PatientId = P.PatientId
	LEFT JOIN Dependent D on TR.DependentId = D.DependentId
	LEFT JOIN Nurses N on TR.NurseId = N.NurseId
	
--


