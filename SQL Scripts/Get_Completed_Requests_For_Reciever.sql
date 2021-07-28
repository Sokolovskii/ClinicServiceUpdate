USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Возвращает все закрытые заявки на имя пользователя
--===================

CREATE PROCEDURE GetCompletedRequestsForReciever
	@UserId INT
AS
SELECT
	r.Id,
	r.Date_Of_Create,
	r.Content,
	u.Name,
	tor.Name
FROM dbo.Requests r
JOIN dbo.Users u ON u.Id = r.Sender_Id
JOIN dbo.TypesOfRequests tor ON tor.Id = r.Type_Id
WHERE r.Reciever_Id = @UserId AND Date_Of_Complete IS NOT NULL