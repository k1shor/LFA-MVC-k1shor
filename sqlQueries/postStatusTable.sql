CREATE TABLE postStatus
(
	ID int not null PRIMARY KEY IDENTITY(1,1),
	name varchar(8) NOT NULL, 
	CONSTRAINT checkPostStatus CHECK (name IN ('Pending', 'Approved', 'Rejected', 'Blocked')	AND (ID BETWEEN 1 AND 4))
)

