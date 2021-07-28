USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Добавляет новую роль
--===================

CREATE PROCEDURE AddNewRole
	@Name NVARCHAR(150)
AS
	INSERT INTO dbo.Role([Name]) VALUES (@Name)