USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 30.07.21
--Description: Отклоняет заявку
--===================

CREATE PROCEDURE DenyRequest
	@Id INT
AS

UPDATE dbo.Requests SET 
	Date_Of_Complete = GETDATE(),
	Status = 0
WHERE Id = @Id