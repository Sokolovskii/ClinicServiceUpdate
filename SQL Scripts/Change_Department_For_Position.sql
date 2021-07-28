USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Меняет департамент для должности
--===================

CREATE PROCEDURE ChangeDepartmentForPosition
	@Id INT,
	@Department_Id INT
AS
	UPDATE dbo.Position
	SET Department_Id = @Department_Id
	WHERE Id = @Id