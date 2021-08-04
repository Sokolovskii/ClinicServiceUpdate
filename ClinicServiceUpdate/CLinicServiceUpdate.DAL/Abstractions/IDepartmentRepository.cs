using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозиторий сущности отделения клиники
	/// </summary>
	public interface IDepartmentRepository
	{
		/// <summary>
		/// Возвращает отделение по его Id
		/// </summary>
		/// <param name="departmentId">Идентификатор отделения</param>
		/// <returns>Экземпляр отделения</returns>
		Department GetDepartmentById(int departmentId);

		/// <summary>
		/// Возвращает все отделения из базы
		/// </summary>
		/// <returns>Коллекция экземпляров отделений</returns>
		IEnumerable<Department> GetAllDepartments();

		/// <summary>
		/// Добавляет отделение в базу
		/// </summary>
		/// <param name="name">Название отделения</param>
		/// <param name="description">Описание отделения</param>
		/// <param name="subordinateId">Идентификатор </param>
		void AddDepartment(string name, string description, int subordinateId);

		/// <summary>
		/// Удаляет отделение из базы
		/// </summary>
		/// <param name="departmentId">Идентификатор отделения</param>
		void DeleteDepartment(int departmentId);
	}
}
