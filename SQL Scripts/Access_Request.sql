﻿USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 30.07.21
--Description: Закрывает заявку
--===================

CREATE PROCEDURE AccessRequest
	@Id INT
AS

UPDATE dbo.Requests SET 
	Date_Of_Complete = GETDATE(),
	Status = 1
WHERE Id = @Id