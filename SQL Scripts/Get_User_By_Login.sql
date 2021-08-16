USE [ClinicService]
GO

--======================
--Date: 16.08.21
--Author: Sokolovskiy Alexander
--Description: Возвращает пользователя по логину
--======================

CREATE PROCEDURE GetUserByLogin
	@Login NVARCHAR(100)
AS

SELECT
	u.Id,
	u.Login,
	u.Name,
	u.EMail,
	u.Position_Id,
	u.RoleId,
	a.Photo
FROM dbo.Users u
LEFT JOIN dbo.Avatars a on a.UserId = u.Id 
WHERE u.Login = @Login