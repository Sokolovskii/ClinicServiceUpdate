USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Добавляет новое отделение в систему
--===================

CREATE PROCEDURE AddNewDepartment
	@Name NVARCHAR(150),
	@Description NVARCHAR(MAX),
	@Id_Depends INT
AS

INSERT INTO dbo.Departments(Name, Description, Id_Depends, IsActive) 
	VALUES(@Name, @Description, @Id_Depends, 1)