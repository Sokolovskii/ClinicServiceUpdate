USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Возвращает Аватар по Id пользователя
--===================

CREATE PROCEDURE GetAvatarByUserId
	@UserId INT
AS

SELECT
	Photo
FROM dbo.Avatars a
JOIN dbo.Users u on u.Avatar_Id = a.Id
WHERE u.Id = @UserId