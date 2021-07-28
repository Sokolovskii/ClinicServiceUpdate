USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает всю информацию по пользователю
--===================

CREATE PROCEDURE GetInfoAboutUserById
	@UserId INT
AS

SELECT 
	u.Name,
	u.Login,
	u.EMail,
	p.Id,
	p.Name,
	d.Id,
	d.Name,
	r.Name
FROM dbo.Users u
JOIN dbo.Roles r ON r.Id = u.RoleId
LEFT JOIN dbo.Position p ON p.Id = u.Position_Id
LEFT JOIN dbo.Departments d ON d.Id = p.DepartmentId
WHERE u.Id = @UserId