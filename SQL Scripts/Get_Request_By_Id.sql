USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 30.07.21
--Description: Возвращает заявку по Id
--===================

CREATE PROCEDURE [dbo].[GetRequestById]
	@Id INT
AS
SELECT
	r.Id,
	r.Sender_Id,
	r.Reciever_Id,
	r.Type_Id,
	r.Content,
	r.Date_Of_Create,
	r.Date_Of_Complete,
	r.Status
FROM dbo.Requests r
WHERE r.Id = @Id