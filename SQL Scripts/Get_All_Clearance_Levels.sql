USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Возвращает все наименования комбинаций прав пользователей
--===================

CREATE PROCEDURE GetAllClearanceLevels

AS
SELECT 
	Id,
	[Name]
FROM dbo.ClearanceLevel
WHERE IsActive = 1