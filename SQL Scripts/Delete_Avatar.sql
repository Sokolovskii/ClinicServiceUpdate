USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ������� ������ ����� � ������ �� ����
--===================

CREATE PROCEDURE DeleteAvatar
	@UserId INT
AS
DELETE FROM dbo.Avatars
	WHERE UserId = @UserId