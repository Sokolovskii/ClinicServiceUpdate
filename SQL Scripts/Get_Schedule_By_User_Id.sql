USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Возвращает актуальное расписание пользователя
--===================

CREATE PROCEDURE GetScheduleByUserId
	@UserId INT
AS

SELECT
	s.Monday_Begining,
	s.Monday_Ending,
	s.Tuesday_Begining,
	s.Tuesday_Ending,
	s.Wednesday_Begining,
	s.Wednesday_Ending,
	s.Thursday_Begining,
	s.Thursday_Ending,
	s.Friday_Begining,
	s.Friday_Ending,
	s.Saturday_Begining,
	s.Saturday_Ending,
	s.Sunday_Begining,
	s.Sunday_Ending,
	s.Actualisation_Date
FROM dbo.Schedules s
WHERE UserId = @UserId AND s.Actualisation_Date = (SELECT 
														MAX(s1.Actualisation_Date) 
													FROM dbo.Schedules s1
													WHERE UserId = @UserId)