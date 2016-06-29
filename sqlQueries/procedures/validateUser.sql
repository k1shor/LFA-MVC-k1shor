create procedure validateUser
	@username varchar(45)
AS
	UPDATE _user 
	SET userStatusID=2
	WHERE Username=@username
GO

EXEC validateUser 'kishor'