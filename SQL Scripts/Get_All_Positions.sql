USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Выводит все должности, имеющиеся в базе
--===================

CREATE PROCEDURE GetAllPositions

AS
SELECT 
	p.Id PositionId,
	p.Name PositionName,
	d.Id DepartmentId,
	d.Name DepartmentName,
	cl.Id ClearanceLevelId,
	cl.Name ClearanceLevelName
FROM dbo.Position p
JOIN dbo.Departments d on d.Id = p.Department_Id
JOIN dbo.ClearanceLevel cl on cl.Id = p.Clearance_Level_Id