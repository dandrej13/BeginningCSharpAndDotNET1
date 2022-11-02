USE FirstDatabase
GO	

INSERT INTO Classes
VALUES('The Complete SQL Bootcamp 2022: Go from Zero to Hero',
		8.51,	
		5/2021
)

SELECT * FROM Classes	

UPDATE Classes
SET DateCreated = '1.5.2021'
WHERE ClassID = 10;