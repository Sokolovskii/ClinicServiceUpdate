USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ������� ���������� ���� ������������
--===================

CREATE PROCEDURE DeleteClearanceLevel
	@Id INT
AS
	UPDATE dbo.ClearanceLevel
	SET IsActive = 0
	WHERE Id = @Id