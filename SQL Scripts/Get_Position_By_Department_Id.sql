USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает все должности по Id отдела
--===================

CREATE PROCEDURE GetPositionsByDepartmentId
	@Id INT
AS
SELECT 
	p.Id,
	p.Name,
	d.Name
FROM dbo.Position p
JOIN dbo.Departments d on p.DepartmentId = d.Id
WHERE d.Id = @Id