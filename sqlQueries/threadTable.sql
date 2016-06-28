CREATE TABLE thread
(
	ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	title VARCHAR(30) NOT NULL, 
	userID int FOREIGN KEY REFERENCES _user(ID),
	createdDate datetime,
	status int FOREIGN KEY REFERENCES postStatus(ID)
)