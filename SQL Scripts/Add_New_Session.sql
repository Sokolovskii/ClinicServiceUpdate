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
	@DateTimeOfEnding DATETIME2
AS

INSERT INTO dbo.Sessions(Client_Id, Doctor_Id, DateTimeOfBegin, DateTimeOfEnding) 
	VALUES(@ClientId, @DoctorId, @DateTimeOfBegin, @DateTimeOfEnding)