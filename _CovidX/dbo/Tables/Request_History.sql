CREATE TABLE [dbo].[Request_History]
(
	[RequestHistoryID] INT NOT NULL PRIMARY KEY, 
    [TestRequestID] INT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [OldRequestStatus] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Request_History_TestRequestID] FOREIGN KEY ([TestRequestID]) REFERENCES [TestRequest]([TestRequestID])
)
