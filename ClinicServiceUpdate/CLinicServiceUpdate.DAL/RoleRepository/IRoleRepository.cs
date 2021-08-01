using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RoleRepository
{
	/// <summary>
	/// Репозиторий ролей
	/// </summary>
	interface IRoleRepository
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
		void AddNewRole(string name, params PoliticElem[] politicElems);

	}
}
