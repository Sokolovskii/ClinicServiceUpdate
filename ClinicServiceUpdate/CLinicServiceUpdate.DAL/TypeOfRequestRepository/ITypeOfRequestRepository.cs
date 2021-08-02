using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.TypeOfRequestRepository
{
	interface ITypeOfRequestRepository
	{
		/// <summary>
		/// Врзврат типа запроса по его Id
		/// </summary>
		/// <param name="typeId">Идентификатор типа запроса</param>
		/// <returns>Экземпляр типа запроса</returns>
		TypeOfRequest GetTypeOfRequestById(int typeId);

		/// <summary>
		/// Возвращает все типы запросов
		/// </summary>
		/// <returns>Коллекция типов запросов</returns>
		IEnumerable<TypeOfRequest> GetTypeOfRequests();

		/// <summary>
		/// Добавление нового типа заявок
		/// </summary>
		/// <param name="name">Имя типа заявок</param>
		void AddTypeOfRequest(string name);

		/// <summary>
		/// Удаление типа заявок
		/// </summary>
		/// <param name="typeId">Идентификатор типа заявок</param>
		void DeleteTypeOfRequest(int typeId);
	}
}
