USE [ClinicService]
GO

--===========================
--Date: 16.08.21
--Author: Sokolovskiy Alexander
--Description: возврат всех актуальных сессий на указанный день
--===========================

CREATE PROCEDURE GetActualSessionOnDay
	@Date DATE,
	@DoctorId INT
AS

SELECT 
	Id,
	Client_Id,
	Doctor_Id,
	DateTimeOfBegin,
	DateTimeOfEnding
FROM dbo.Sessions
WHERE CAST(DateTimeOfBegin AS DATE) = @Date AND
	Doctor_Id = @DoctorId