CREATE TABLE comments
(
	ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	content VARCHAR(99) NOT NULL, 
	topicID int FOREIGN KEY REFERENCES thread(ID),
	userID int FOREIGN KEY REFERENCES _user(ID),
	createdDate datetime,
	status int FOREIGN KEY REFERENCES postStatus(ID)
)