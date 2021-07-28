USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Возвращает категорию по Id
--===================

CREATE PROCEDURE GetTypeOfRequestById
	@Id INT
AS
	SELECT
		[Id],
		[Name]
	FROM dbo.TypesOfRequests
	WHERE Id = @Id