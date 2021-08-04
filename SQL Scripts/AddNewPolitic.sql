USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 04.08.21
--Description: Вносит политику в базу
--===================

CREATE PROCEDURE AddNewPolitic
	@RoleId INT,
	@RightId INT,
	@RightIsActive BIT
AS

INSERT INTO dbo.Politics(RoleId, RightId, RightIsActive)
	VALUES(@RightId, @RightId, @RightIsActive)