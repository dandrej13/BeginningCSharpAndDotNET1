USE FirstDatabase

CREATE TABLE Persons(
	PersonID int identity(1,1),
	LastName varchar(255),
	FirstName varchar(255),
	Address varchar(255),
	City varchar(255)
	)