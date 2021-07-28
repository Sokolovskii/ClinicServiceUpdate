USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Добавляет аватар к профилю юзера и оставляет ссылку на аватар в строке юзера
--===================

CREATE PROCEDURE AddNewAvatar
	@UserId INT,
	@Photo IMAGE
AS
INSERT INTO dbo.Avatars(Photo) VALUES(@Photo)
UPDATE dbo.Users 
	SET Avatar_Id = @@IDENTITY
	WHERE Id = @UserId