create procedure removeUser
	@ID int
AS
	DELETE FROM _user 
	WHERE ID=@ID
GO

EXEC removeUser 1


