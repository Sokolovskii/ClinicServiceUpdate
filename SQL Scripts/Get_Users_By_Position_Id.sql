USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Выводит всех юзеров с указанной должностью
--===================

CREATE PROCEDURE GetUsersByPositionId
	@Id INT
AS

SELECT 
	u.Id,
	u.Name,
	a.Photo,
	d.Name
FROM dbo.Users u 
LEFT JOIN dbo.Avatars a on a.Id = u.Avatar_Id
JOIN dbo.Position p on u.Position_Id = p.Id
JOIN dbo.Departments d on d.Id = p.Department_Id
WHERE p.Id = @Id
