USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Выводит все должности, имеющиеся в базе
--===================
CREATE PROCEDURE GetAllPositions

AS
SELECT 
	p.Id PositionId,
	p.Name PositionName,
	d.Id DepartmentId,
	d.Name DepartmentName
FROM dbo.Position p
JOIN dbo.Departments d on d.Id = p.DepartmentId