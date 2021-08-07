USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 05.07.21
--Description: �������� ���� ������������
--===================

CREATE PROCEDURE [dbo].[UpdateUserRole]
	@Id INT,
	@RoleId INT
AS
UPDATE dbo.Users
SET RoleId = @RoleId
WHERE Id = @Id