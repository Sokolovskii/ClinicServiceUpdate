USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 22.07.21
--Description: Меняет правовую политику для должности
--===================

CREATE PROCEDURE ChangeClearanceLevelForPosition
	@Id INT,
	@Clearance_Level_Id INT
AS
	UPDATE dbo.Position
	SET Clearance_Level_Id = @Clearance_Level_Id
	WHERE Id = @Id