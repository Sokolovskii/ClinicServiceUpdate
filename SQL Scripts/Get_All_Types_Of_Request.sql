USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ���������� ��� ��������� ������
--================

CREATE PROCEDURE GetAllTypesOfRequest
AS
	SELECT
		[Id],
		[Name]
	FROM dbo.TypesOfRequests