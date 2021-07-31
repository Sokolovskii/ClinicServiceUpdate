using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.DepartmentRepository
{
	/// <summary>
	/// Репозиторий сущности отделения клиники
	/// </summary>
	interface IDepartmentRepository
	{
		/// <summary>
		/// Возвращает отделение по его Id
		/// </summary>
		/// <param name="DepartmentId">Идентификатор отделения</param>
		/// <returns>Экземпляр отделения</returns>
		Department GetDepartmentById(int departmentId);

		/// <summary>
		/// Возвращает все отделения из базы
		/// </summary>
		/// <returns>Коллекция экземпляров отделений</returns>
		List<Department> GetAllDepartments();

		/// <summary>
		/// Добавляет отделение в базу
		/// </summary>
		/// <param name="department">Экземпляр отделения для добавления</param>
		void AddDepartment(Department department);

		/// <summary>
		/// Удаляет отделение из базы
		/// </summary>
		/// <param name="DepartmentId">Идентификатор отделения</param>
		void DeleteDepartment(int departmentId);
	}
}
