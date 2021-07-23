USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Редактирует описание отделения
--===================

CREATE PROCEDURE UpdateDepartmentDecription
	@Id INT,
	@Description NVARCHAR(MAX)
AS

UPDATE dbo.Departments
SET Description = @Description
WHERE Id = @Id
