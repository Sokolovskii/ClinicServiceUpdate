USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Удаляет запись к врачу
--===================

CREATE PROCEDURE DeleteSession
	@Id INT
AS

DELETE FROM dbo.Sessions
	WHERE Id = @Id