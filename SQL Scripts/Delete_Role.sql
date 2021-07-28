USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Удаляет роль
--===================

CREATE PROCEDURE [dbo].[DeleteRole]
	@Id INT
AS
DELETE FROM dbo.Roles
WHERE Id = @Id