USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 30.07.21
--Description: Возвращает запись по Id
--===================

CREATE PROCEDURE GetSessionById
	@Id INT
AS

SELECT 
	Doctor_Id,
	Client_Id,
	DateTimeOfBegin,
	DateTimeOfEnding
FROM dbo.Sessions
WHERE Id = @Id