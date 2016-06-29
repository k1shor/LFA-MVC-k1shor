create procedure blockUser
	@username varchar(45)
AS
	UPDATE _user 
	SET userStatusID=3
	WHERE Username=@username
GO

EXEC blockUser 'kishor'

select * from _user