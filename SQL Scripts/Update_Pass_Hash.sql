USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Меняет хэш пароля пользователя  
--===================

CREATE PROCEDURE UpdatePassHash
	@Id INT,
	@PassHash NVARCHAR(MAX)
AS
UPDATE dbo.Users
SET Pass_Hash = @PassHash
WHERE Id = @Id