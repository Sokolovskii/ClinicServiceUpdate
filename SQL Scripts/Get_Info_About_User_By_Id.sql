USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Меняет название для должности
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
	cl.Name
FROM dbo.Users u
LEFT JOIN dbo.Position p ON p.Id = u.Position_Id
JOIN dbo.Departments d ON d.Id = p.Department_Id
JOIN dbo.ClearanceLevel cl ON cl.Id = p.Clearance_Level_Id
WHERE u.Id = @UserId