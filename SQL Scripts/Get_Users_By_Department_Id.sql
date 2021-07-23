USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Возвращает всех докторов по Id отделения
--===================

CREATE PROCEDURE GetUsersByDepartmentId
	@DepartmentId INT

AS
	SELECT 
		u.Name,
		a.Photo,
		p.Id,
		p.Name
	FROM dbo.Users u
	LEFT JOIN dbo.Avatars a ON a.Id = u.Avatar_Id
	JOIN dbo.Position p ON p.Id = u.Position_Id
	JOIN dbo.Departments d ON d.Id = p.Department_Id
	WHERE d.Id = @DepartmentId AND d.IsActive = 1