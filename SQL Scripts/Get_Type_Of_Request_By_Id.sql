USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ���������� ��������� �� Id
--===================

CREATE PROCEDURE GetTypeOfRequestById
	@Id INT
AS
	SELECT
		[Id],
		[Name]
	FROM dbo.TypesOfRequests
	WHERE Id = @Id