--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: ������� ��� ������ �� ��������� ��� ������������ ����� ������ 
--===================

CREATE PROCEDURE DeleteTypeOfRequestById
	@Id INT
AS
	UPDATE dbo.TypesOfRequests
	SET IsActive = 0
	WHERE Id = @Id