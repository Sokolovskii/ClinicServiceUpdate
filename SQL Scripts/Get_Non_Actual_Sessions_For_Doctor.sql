USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает все прошедшие записи к клиенту
--===================

CREATE PROCEDURE GetNonActualSessionsForDoctor
	@DoctorId INT,
	@ActualDateTime DATETIME2
AS

SELECT
	s.Id,
	s.DateTimeOfBegin,
	s.SessionTime,
	(SELECT 
		[Name] 
	FROM dbo.Users 
	WHERE Id = s.Client_Id) AS Client_Name
FROM dbo.Sessions s
WHERE s.Doctor_Id = @DoctorId AND DATEDIFF(MINUTE, DateTimeOfBegin, @ActualDateTime) > DATEPART(MINUTE, SessionTime)