USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ��������� ����� ��� ������
--===================

CREATE PROCEDURE AddNewTypeOfRequest
	@TypeName NVARCHAR(150)
AS
	INSERT INTO dbo.TypesOfRequests(Name)
	VALUES(@TypeName)