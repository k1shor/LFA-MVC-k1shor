create procedure addUser
	@username varchar(45),
	@password varchar(30),
	@email varchar(30)
AS
	INSERT INTO _user values(@username, @password, @email, 1)
GO


EXECUTE addUser 'kishor', 'password', 'k1shor'