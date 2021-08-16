using ClinicServiceUpdate.DAL.Models;
using System.Collections.Generic;

namespace ClinicServiceUpdate.BLL.ExternalServices.RequestService
{
	/// <summary>
	/// Интерфейс внешней службы заявок
	/// </summary>
	public interface IRequestExternalService
	{
		/// <summary>
		/// Добавление заявки
		/// </summary>
		/// <param name="request">Заявка</param>
		void AddRequest(int senderId, int recieverId, int typeId, string content);

		/// <summary>
		/// Подтверждение заявки
		/// </summary>
		/// <param name="requestId">Идентификатор заявки</param>
		void AccessRequest(int requestId);

		/// <summary>
		/// Отклонение заявки
		/// </summary>
		/// <param name="requestId">Идентификатор заявки</param>
		void DenyRequest(int requestId);

		/// <summary>
		/// Выдача всех заявок на пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <returns>Коллекция заявок</returns>
		IEnumerable<Request> GetRequestsForUser(int userId);
	}
}
