USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Добавляет должность
--===================

CREATE PROCEDURE AddNewPosition
	@Name NVARCHAR(100),
	@DepartmentId INT
AS
	INSERT INTO dbo.Position(Name, DepartmentId) 
	VALUES(@Name, @DepartmentId)