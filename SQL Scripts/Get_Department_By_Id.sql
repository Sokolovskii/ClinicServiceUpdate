USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает отделение
--===================

CREATE PROCEDURE GetDepartmentById
	@Id INT
AS

SELECT 
	[Name],
	[Description],
	(SELECT d.[Name] FROM dbo.Departments d 
		WHERE d.Id = SubordinateId)
FROM dbo.Departments
WHERE Id = @Id