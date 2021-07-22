USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Возвращает должность по Id юзера
--===================

CREATE PROCEDURE GetPositionByUserId
	@Id INT
AS
SELECT 
	p.Id,
	p.Name,
	d.Id,
	d.Name,
	cl.Id,
	cl.Name
FROM dbo.Position p
JOIN dbo.Departments d ON p.Department_Id = d.Id
JOIN dbo.ClearanceLevel cl ON p.Clearance_Level_Id = cl.Id
JOIN dbo.Users u ON u.Position_Id = p.Id
WHERE u.Id = @Id