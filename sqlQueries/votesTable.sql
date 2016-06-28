CREATE TABLE votes
(
	ID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	threadID int FOREIGN KEY REFERENCES thread(ID),
	postID int FOREIGN KEY REFERENCES comments(ID),
	upVote int check (upVote>=0),
	downVote int check (downVote>=0)
)