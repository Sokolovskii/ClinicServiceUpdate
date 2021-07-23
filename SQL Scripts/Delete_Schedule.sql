USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Удаляет расписание
--===================

CREATE PROCEDURE DeleteSchedule
	@Id INT
AS

DELETE FROM dbo.Schedules
WHERE Id = @Id