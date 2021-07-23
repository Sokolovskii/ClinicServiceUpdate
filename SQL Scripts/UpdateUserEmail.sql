USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Добавляет/Изменяет EMail Пользователя 
--===================

CREATE PROCEDURE UpdateUserEmail
	@Id INT,
	@EMail NVARCHAR(100)
AS
UPDATE dbo.Users
SET EMail = @EMail
WHERE Id = @Id