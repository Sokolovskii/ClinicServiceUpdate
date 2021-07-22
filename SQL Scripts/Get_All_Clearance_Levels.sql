USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ���������� ��� ������������ ���������� ���� �������������
--===================

CREATE PROCEDURE GetAllClearanceLevels

AS
SELECT 
	Id,
	[Name]
FROM dbo.ClearanceLevel
WHERE IsActive = 1