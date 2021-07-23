USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Добавляет нового пользователя  
--===================

CREATE PROCEDURE AddNewUser
	@Name NVARCHAR(100),
	@Login NVARCHAR(100),
	@PassHash NVARCHAR(100)
AS
	INSERT INTO dbo.Users(Name, Login, Pass_Hash) 
	VALUES(@Name, @Login, @PassHash)
