using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозиторий ролей
	/// </summary>
	public interface IRoleRepository
	{
		/// <summary>
		/// Возврат роли по её идентификатору
		/// </summary>
		/// <param name="roleId">идентификатор роли</param>
		/// <returns>Экземпляр роли</returns>
		Role GetRoleById(int roleId);

		/// <summary>
		/// Возврат всех ролей
		/// </summary>
		/// <returns>Коллекция ролей</returns>
		IEnumerable<Role> GetAllRoles();

		/// <summary>
		/// Добавление новой роли
		/// </summary>
		/// <param name="name">Название роли</param>
		/// <param name="politicElems">Комбинация политик</param>
		void AddNewRole(string name, PoliticElem[] politicElems);

	}
}
