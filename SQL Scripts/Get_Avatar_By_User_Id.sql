USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: ���������� ������ �� Id ������������
--===================

CREATE PROCEDURE GetAvatarByUserId
	@UserId INT
AS

SELECT
	Photo
FROM dbo.Avatars
WHERE UserId = @UserId