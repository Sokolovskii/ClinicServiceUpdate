USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Добавляет/меняет должность сотрудника 
--===================

CREATE PROCEDURE UpdateUserPosition
	@Id INT,
	@PositionId INT
AS
UPDATE dbo.Users
SET Position_Id = @PositionId
WHERE Id = @Id