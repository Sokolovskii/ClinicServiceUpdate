USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает все актуальные записи к конкретному врачу
--===================

CREATE PROCEDURE GetActualSessionsForDoctor
	@DoctorId INT,
	@ActualDateTime DATETIME2
AS

SELECT
	s.Id,
	s.DateTimeOfBegin,
	s.DateTimeOfEnding,
	(SELECT 
		[Name] 
	FROM dbo.Users 
	WHERE Id = s.Client_Id) AS Client_Name
FROM dbo.Sessions s
WHERE s.Doctor_Id = @DoctorId AND @ActualDateTime < DateTimeOfBegin
