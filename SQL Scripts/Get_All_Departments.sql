USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает все действительные отделы
--===================

CREATE PROCEDURE GetAllDepartments
AS

SELECT
	d.Id,
	d.Name,
	d.Description,
	(SELECT d1.Name FROM dbo.Departments d1
		WHERE d1.Id = d.SubordinateId) Depend_On 
FROM dbo.Departments d