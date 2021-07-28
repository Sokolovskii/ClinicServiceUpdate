USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает роль по Id
--===================

CREATE PROCEDURE GetRoleById
	@Id INT
AS
SELECT 
	[Name]
FROM dbo.Roles
