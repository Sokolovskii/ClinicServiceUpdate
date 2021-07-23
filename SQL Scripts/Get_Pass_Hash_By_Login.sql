USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Возвращает учётные данные для подтверждения входа
--===================

CREATE PROCEDURE GetPassHashByLogin
	@Login NVARCHAR(100)
AS
SELECT Pass_Hash
FROM dbo.Users
WHERE Login = @Login