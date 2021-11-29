
--CREATE DATABASE QRCode 


--CREATE TABLE Users(
--	idUser INT NOT NULL PRIMARY KEY IDENTITY(1,1)
--	,token UNIQUEIDENTIFIER NOT NULL
--	,name VARCHAR(30) NOT NULL
--	,lastName VARCHAR(30) NOT NULL
--	,date DATETIME NOT NULL
--	,status BIT NOT NULL
--)

--GO
--INSERT INTO Users(token, name, lastName, date, status)
--VALUES(NEWID(), 'John', 'Doe', GETDATE(), 1), (NEWID(), 'Developer', 'Web', GETDATE(), 1)

GO 
--- USPUsersList
IF OBJECT_ID('USPUsersList') IS NOT NULL
	BEGIN 
		DROP PROC USPUsersList
	END
GO 
CREATE PROC USPUsersList
AS 
BEGIN 
SET NOCOUNT ON;
SET LANGUAGE SPANISH;

	SELECT '1','', ''
	,u.idUser
	,u.token
	,u.name
	,u.lastName	
	FROM dbo.Users u
END