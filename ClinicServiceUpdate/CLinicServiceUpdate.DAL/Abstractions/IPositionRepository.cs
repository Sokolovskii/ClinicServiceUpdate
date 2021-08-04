using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозтиторий должностей
	/// </summary>
	public interface IPositionRepository
	{
		/// <summary>
		/// Возврат должности по её идентификатору
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		/// <returns>Экземпляр должности</returns>
		Position GetPositionById(int positionId);

		/// <summary>
		/// Возврат всех должностей, прикрепленных к указанному отделению
		/// </summary>
		/// <param name="departmentId">Идентфиикатор отделения</param>
		/// <returns>Коллекция должностей</returns>
		IEnumerable<Position> GetPositionsByDepartmentId(int departmentId);

		/// <summary>
		/// Возврат всех должностей в базе
		/// </summary>
		/// <returns>Коллекция экземпляров должностей</returns>
		IEnumerable<Position> GetAllPositions();

		/// <summary>
		/// Добавление новой должности в базу
		/// </summary>
		/// <param name="name">Название должности</param>
		/// <param name="departmentId">Идентификатор отделения, к которому прикреплена должность</param>
		void AddPosition(string name, int departmentId);

		/// <summary>
		/// Удаление должности из базы
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		void DeletePosition(int positionId);
	}
}
