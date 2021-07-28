USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Выводит всех юзеров с указанной должностью
--===================

CREATE PROCEDURE GetUsersByPositionId
	@Id INT
AS

SELECT 
	u.Id,
	u.Name UserName,
	a.Photo,
	p.Name PositionName,
	d.Name DepartmentName
FROM dbo.Users u 
LEFT JOIN dbo.Avatars a on a.UserId = u.Id
JOIN dbo.Position p on u.Position_Id = p.Id
JOIN dbo.Departments d on d.Id = p.DepartmentId
WHERE p.Id = @Id
