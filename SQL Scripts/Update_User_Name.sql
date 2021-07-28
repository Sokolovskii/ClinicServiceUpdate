USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Изменяет имя пользователя
--===================

CREATE PROCEDURE UpdateUserName
	@Id INT,
	@Name NVARCHAR(100)
AS
UPDATE dbo.Users
SET Name = @Name
WHERE Id = @Id