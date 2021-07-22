USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Добавляет должность
--===================

CREATE PROCEDURE AddNewPosition
	@Name NVARCHAR(100),
	@Department_Id INT,
	@Clearance_Level_Id INT
AS
	INSERT INTO dbo.Position(Name, Department_Id, Clearance_Level_Id) 
	VALUES(@Name, @Department_Id, @Clearance_Level_Id)