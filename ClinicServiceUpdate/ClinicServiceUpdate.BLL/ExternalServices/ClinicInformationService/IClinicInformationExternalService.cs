using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Models.UserModels;

namespace ClinicServiceUpdate.BLL.ExternalServices.ClinicInformationService
{
	/// <summary>
	/// Интерфейс внешней службы предоставления информации о больнице
	/// </summary>
	interface IClinicInformationExternalService
	{
		/// <summary>
		/// Возврат всех отделений в больнице
		/// </summary>
		/// <returns>Список отделений</returns>
		IEnumerable<Department> GetAllDepartments();

		/// <summary>
		/// Возврат отделения по Id
		/// </summary>
		/// <param name="departmentId">Идентификатор отделения</param>
		/// <returns>Отделение</returns>
		Department GetDepartmentById(int departmentId);

		/// <summary>
		/// Возврат всех врачей в указанном отделении
		/// </summary>
		/// <param name="departmentId">Идентификатор отделения</param>
		/// <returns>Список врачей</returns>
		IEnumerable<UserWithAvatar> GetDoctorsByDepartmentId(int departmentId);

		/// <summary>
		/// Возврат всех врачей с указанной должностью
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		/// <returns>Список врачей</returns>
		IEnumerable<UserWithAvatar> GetDoctorsByPositionId(int positionId);
	}
}
