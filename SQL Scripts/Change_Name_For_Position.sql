USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Меняет название для должности
--===================

CREATE PROCEDURE ChangeNameForPosition
	@Id INT,
	@Name INT
AS
	UPDATE dbo.Position
	SET [Name] = @Name
	WHERE Id = @Id