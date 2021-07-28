USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает всех докторов по Id отделения
--===================

CREATE PROCEDURE GetUsersByDepartmentId
	@DepartmentId INT

AS
	SELECT 
		u.Name UserName,
		a.Photo,
		p.Id,
		p.Name PositionName,
		d.Name DepartmentName
	FROM dbo.Users u
	LEFT JOIN dbo.Avatars a ON a.UserId = u.Id
	JOIN dbo.Position p ON p.Id = u.Position_Id
	JOIN dbo.Departments d ON d.Id = p.DepartmentId
	WHERE d.Id = @DepartmentId