USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 04.08.21
--Description: Возвращает все политики для указанной роли
--===================

CREATE PROCEDURE GetAllPoliticsByRoleId
	@Id INT
AS

SELECT 
	RightId,
	RightIsActive
FROM dbo.Politics
WHERE RoleId = @Id