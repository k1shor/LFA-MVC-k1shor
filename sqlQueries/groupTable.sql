CREATE TABLE _Group
(
	ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	NAME VARCHAR(15) NOT NULL, 
	categoryID int FOREIGN KEY REFERENCES category(ID) not null,
	userID int FOREIGN KEY REFERENCES _user(ID) 
)


