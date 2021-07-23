USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Формирование заявки
--===================

CREATE PROCEDURE AddNewRequest
	@SenderId INT,
	@RecieverId INT,
	@TypeId INT,
	@Content NVARCHAR(MAX)
AS
INSERT INTO dbo.Requests(Sender_Id, Reciever_Id, [Type_Id], Content, Date_Of_Create)
	VALUES (@SenderId, @RecieverId, @TypeId, @Content, GETDATE())