USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ���������� ���������� ���� ������������ �� Id
--===================

CREATE PROCEDURE GetClearanceLevelById
	@Id INT
AS
SELECT 
	[Name]
FROM dbo.ClearanceLevel
WHERE Id = @Id AND IsActive = 1
