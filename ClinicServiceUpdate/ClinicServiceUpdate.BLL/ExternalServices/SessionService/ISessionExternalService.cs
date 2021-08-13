using ClinicServiceUpdate.DAL.Models;
using System;
using System.Collections.Generic;

namespace ClinicServiceUpdate.BLL.ExternalServices.SessionService
{
	/// <summary>
	/// Инетрфейс внешней службы врачебных сессий
	/// </summary>
	interface ISessionExternalService
	{
		/// <summary>
		/// Создание сессии
		/// </summary>
		/// <param name="session">Полученный экземпляр DTO сессии</param>
		void CreateSession(Session session);

		/// <summary>
		/// Удаление сессии
		/// </summary>
		/// <param name="sessionId">Идентификатор сессии</param>
		void DeleteSession(int sessionId);

		/// <summary>
		/// Выдача подробной информации по сессии
		/// </summary>
		/// <param name="sessionId">Идентификатор сессии</param>
		/// <returns>Экземпляр сессии</returns>
		Session GetSession(int sessionId);

		/// <summary>
		/// Выдача списка сессий, забронированных клиентом
		/// </summary>
		/// <param name="clientId">Идентификатор клиента</param>
		/// <returns>Коллекция сессий</returns>
		IEnumerable<Session> GetSessionsForClient(int clientId);

		/// <summary>
		/// Выдача списка сессий, забронированных на врача
		/// </summary>
		/// <param name="doctorId">Идентификатор врача</param>
		/// <returns>Коллекция сессий</returns>
		IEnumerable<Session> GetSessionsForDoctor(int doctorId);

		/// <summary>
		/// Выдача всех сессий на указанного врача и дату
		/// </summary>
		/// <param name="date">Интересуемая дата</param>
		/// <param name="doctorId">Идентификатор врача</param>
		/// <returns>Список сессий</returns>
		IEnumerable<Session> GetSessionsOnDay(DateTime date, int doctorId);
	}
}
