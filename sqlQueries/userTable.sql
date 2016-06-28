CREATE TABLE _user
(
	ID int not null PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(45) NOT NULL UNIQUE,
	_Password VARCHAR(30) NOT NULL,
	Email VARCHAR(30) NOT NULL,
	userStatusID int FOREIGN KEY REFERENCES UserStatus(ID) 
);

SELECT * FROM _USER