USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: ���������� ��� ��������� ������
--================

CREATE PROCEDURE GetAllTypesOfRequest
AS
	SELECT
		[Id],
		[Name]
	FROM dbo.TypesOfRequests
	WHERE IsActive = 1