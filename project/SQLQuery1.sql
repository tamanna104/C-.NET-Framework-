ALTER PROC UserAdd
@Name varchar(50),
@Email varchar(50),
@Address varchar(50),
@Password varchar(50)
AS 
	INSERT INTO Customer(Name,Email,Address,Password)
	VALUES (@Name,@Email,@Address,@Password)

