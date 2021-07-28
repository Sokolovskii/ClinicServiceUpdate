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
	WHERE UserId = @UserId