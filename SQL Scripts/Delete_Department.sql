USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Убирает отдел из видимости
--===================

CREATE PROCEDURE DeleteDepartment
	@Id INT
AS
UPDATE dbo.Departments
SET IsActive = 0
WHERE Id = @Id