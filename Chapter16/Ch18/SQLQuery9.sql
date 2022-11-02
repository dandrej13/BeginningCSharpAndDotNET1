USE [FirstDatabase]
GO

CREATE TABLE Classes(
	ClassID int IDENTITY(10,10) NOT NULL,
	ClassName VARCHAR(255) NOT NULL,
	EstimatedTime DEC NULL,	
	DateCreated DATETIME NOT NULL,
	PRIMARY KEY (ClassID)
)