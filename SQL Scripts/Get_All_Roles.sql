USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 28.07.21
--Description: ���������� ��� ����
--===================

CREATE PROCEDURE GetAllRoles

AS
SELECT 
	Id,
	[Name]
FROM dbo.Roles
