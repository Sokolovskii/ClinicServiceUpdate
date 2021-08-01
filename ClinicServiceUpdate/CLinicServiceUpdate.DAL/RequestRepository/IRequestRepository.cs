using System;
using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RequestRepository
{
	/// <summary>
	/// Репозиторий заявок
	/// </summary>
	interface IRequestRepository
	{
		/// <summary>
		/// Формирование заявки
		/// </summary>
		/// <param name="senderId">Идентификатор отправителя</param>
		/// <param name="recieverId">Идентификатор получателя</param>
		/// <param name="typeId">Идентификатор типа заявки</param>
		/// <param name="content">Текст заявки</param>
		/// <param name="dateTimeOfCreate">Дата и время формирования</param>
		void AddNewRequest(int senderId, int recieverId, int typeId, string content, DateTime dateTimeOfCreate);

		/// <summary>
		/// Закрытие и одобрение заявки
		/// </summary>
		/// <param name="requestId">Идентификатор заявки</param>
		void AccessRequest(int requestId);

		/// <summary>
		/// Отклонение заявки
		/// </summary>
		/// <param name="requestId">Идентификатор заявки</param>
		void DenyRequest(int requestId);

		/// <summary>
		/// Возврат заявки
		/// </summary>
		/// <param name="requestId">Идентификатор заявки</param>
		/// <returns></returns>
		Request GetRequestById(int requestId);

		/// <summary>
		/// Возврат всех заявок, в которых задействован пользователь
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <returns>Коллекция заявок</returns>
		IEnumerable<Request> GetRequestsByUserId(int userId);
	}
}
