USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Добавляет запись к врачу
--===================

CREATE PROCEDURE AddNewSession
	@ClientId INT,
	@DoctorId INT,
	@DateTimeOfBegin DATETIME2,
	@SessionTime TIME
AS

INSERT INTO dbo.Sessions(Client_Id, Doctor_Id, DateTimeOfBegin, SessionTime) 
	VALUES(@ClientId, @DoctorId, @DateTimeOfBegin, @SessionTime)