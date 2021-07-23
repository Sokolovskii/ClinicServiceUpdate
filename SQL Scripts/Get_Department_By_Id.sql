USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Возвращает отделение
--===================

CREATE PROCEDURE GetDepartmentById
	@Id INT
AS

SELECT 
	[Name],
	[Description],
	(SELECT d.[Name] FROM dbo.Departments d 
		WHERE d.Id = Id_Depends)
FROM dbo.Departments
WHERE Id = @Id AND IsActive = 1