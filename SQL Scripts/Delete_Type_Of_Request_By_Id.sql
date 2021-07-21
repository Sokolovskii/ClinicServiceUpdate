--===================
--Author: Sokolovskiy Alexander
--Date: 21.07.21
--Description: Убирает тип заявки из видимости для формирования новых заявок 
--===================

CREATE PROCEDURE DeleteTypeOfRequestById
	@Id INT
AS
	UPDATE dbo.TypesOfRequests
	SET IsActive = 0
	WHERE Id = @Id