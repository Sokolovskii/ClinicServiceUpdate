USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает должность по Id юзера
--===================

CREATE PROCEDURE GetPositionByUserId
	@Id INT
AS
SELECT 
	p.Id,
	p.Name,
	d.Id,
	d.Name
FROM dbo.Position p
JOIN dbo.Departments d ON p.DepartmentId = d.Id
JOIN dbo.Users u ON u.Position_Id = p.Id
WHERE u.Id = @Id