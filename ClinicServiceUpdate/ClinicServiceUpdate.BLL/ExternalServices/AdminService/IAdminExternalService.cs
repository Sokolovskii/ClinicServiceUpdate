using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.BLL.ExternalServices.AdminService
{
	/// <summary>
	/// Интерфейс внешней службы администратора
	/// </summary>
	interface IAdminExternalService
	{
		/// <summary>
		/// Добавление новой должности
		/// </summary>
		/// <param name="name">Название</param>
		/// <param name="departmentId">Принадлежность к отделению</param>
		void AddNewPosition(string name, int departmentId);

		/// <summary>
		/// Добавление нового отделения
		/// </summary>
		/// <param name="name">Название</param>
		/// <param name="description">Описание</param>
		/// <param name="subordinatedOn">Отделение, которому будет подчиняться это отделение</param>
		void AddNewDepartment(string name, string description, int subordinatedOn);

		/// <summary>
		/// Добавляет новую роль
		/// </summary>
		/// <param name="name">Название</param>
		/// <param name="politics">Список политик</param>
		void AddNewRole(string name, PoliticElem[] politics);

		/// <summary>
		/// Меняет должность пользователя
		/// </summary>
		/// <param name="userId">Идентфиикатор пользователя</param>
		/// <param name="positionId">Идентификатор должности</param>
		void ChangeUserPosition(int userId, int positionId);

		/// <summary>
		/// Меняет роль пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="roleId">Идентификатор роли</param>
		void ChangeUserRole(int userId, int roleId);
	}
}
