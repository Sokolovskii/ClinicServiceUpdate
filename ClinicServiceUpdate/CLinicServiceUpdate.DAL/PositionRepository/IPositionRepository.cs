using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.PositionRepository
{
	/// <summary>
	/// Репозтиторий должностей
	/// </summary>
	interface IPositionRepository
	{
		/// <summary>
		/// Возврат должности по её идентификатору
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		/// <returns>Экземпляр должности</returns>
		Position GetPositionById(int positionId);

		/// <summary>
		/// Возврат всех должностей в базе
		/// </summary>
		/// <returns>Коллекция экземпляров должностей</returns>
		List<Position> GetAllPositions();

		/// <summary>
		/// Добавление новой должности в базу
		/// </summary>
		/// <param name="position">Экземпляр должности</param>
		void AddPosition(Position position);

		/// <summary>
		/// Удаление должности из базы
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		void DeletePosition(int positionId);
	}
}
