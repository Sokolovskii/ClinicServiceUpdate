USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Удаляет аватар юзера и ссылку на него
--===================

CREATE PROCEDURE DeleteAvatar
	@UserId INT
AS
DELETE FROM dbo.Avatars
	WHERE Id = (SELECT Avatar_Id
		FROM dbo.Users
		WHERE Id = @UserId)
UPDATE dbo.Users
	SET Avatar_Id = 0
	WHERE Id = @UserId