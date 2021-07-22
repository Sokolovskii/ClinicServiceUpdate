USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Возвращает должность по Id
--===================

CREATE PROCEDURE GetPositionById
	@Id INT
AS
SELECT 
	p.Name,
	d.Id,
	d.Name,
	cl.Id,
	cl.Name
FROM dbo.Position p
JOIN dbo.Departments d on p.Department_Id = d.Id
JOIN dbo.ClearanceLevel cl on p.Clearance_Level_Id = cl.Id
WHERE p.Id = @Id