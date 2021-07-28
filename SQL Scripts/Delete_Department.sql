USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Убирает отдел из видимости
--===================

CREATE PROCEDURE DeleteDepartment
	@Id INT
AS
DELETE FROM dbo.Departments
WHERE Id = @Id