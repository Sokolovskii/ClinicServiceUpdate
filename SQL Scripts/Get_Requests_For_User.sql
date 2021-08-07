USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 30.07.21
--Description: Возвращает все заявки для пользователя
--===================

ALTER PROCEDURE [dbo].[GetRequestsForUser]
	@UserId INT
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
WHERE r.Reciever_Id = @UserId 
	OR r.Sender_Id = @UserId