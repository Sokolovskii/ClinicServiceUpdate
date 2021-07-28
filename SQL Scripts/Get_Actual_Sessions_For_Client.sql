﻿USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: Возвращает все актуальные записи клиента
--===================

CREATE PROCEDURE GetActualSessionsForClient
	@ClientId INT,
	@ActualDateTime DATETIME2
AS

SELECT
	s.Id,
	s.DateTimeOfBegin,
	s.SessionTime,
	u.Name DoctorName,
	p.Name PositionName
FROM dbo.Sessions s
JOIN dbo.Users u ON u.Id = s.Doctor_Id
JOIN dbo.Position p ON u.Position_Id = p.Id
WHERE s.Client_Id = @ClientId AND @ActualDateTime < DateTimeOfBegin
