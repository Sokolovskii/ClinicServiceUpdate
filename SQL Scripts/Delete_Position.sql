USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Удаляет должность
--===================

CREATE PROCEDURE DeletePosition
	@Id INT
AS
	DELETE FROM dbo.Position
	WHERE Id = @Id
