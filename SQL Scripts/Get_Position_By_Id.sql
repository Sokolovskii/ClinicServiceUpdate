USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает должность по Id
--===================

CREATE PROCEDURE GetPositionById
	@Id INT
AS
SELECT 
	p.Name,
	d.Id,
	d.Name
FROM dbo.Position p
JOIN dbo.Departments d on p.DepartmentId = d.Id
WHERE p.Id = @Id