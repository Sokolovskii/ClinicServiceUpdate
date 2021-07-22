USE ClinicService
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ��������� ����� ���������� ���� ������������
--===================

CREATE PROCEDURE AddNewClearanceLevel
	@Name NVARCHAR(150)
AS
	INSERT INTO dbo.ClearanceLevel([Name], IsActive) VALUES (@Name, 1)