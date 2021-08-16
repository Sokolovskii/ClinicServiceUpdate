using System;
using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозиторий записей к врачу
	/// </summary>
	public interface ISessionRepository
	{
		/// <summary>
		/// Возвращает запись по ее идентификатору
		/// </summary>
		/// <param name="sessionId">Идентификатор записи</param>
		/// <returns>Экземпляр записи</returns>
		Session GetSessionById(int sessionId);

		/// <summary>
		/// Возврат списка актуальных записей на конкретный день
		/// </summary>
		/// <param name="doctorId">Идентификатор врача, записи к которому запрашиваются</param>
		/// <param name="actualDate">Дата, на которую запрашиваются записи</param>
		/// <returns>Коллекция записей</returns>
		IEnumerable<Session> GetActualSessionsOnDay(int doctorId, DateTime actualDate);

		/// <summary>
		/// Возврат всех действительных записей для клиента
		/// </summary>
		/// <param name="clientId">Идентификатор клиента</param>
		/// <param name="actualDateTime">Актуальное дата и время обращения</param>
		/// <returns>Колекция экземпляров записей</returns>
		IEnumerable<Session> GetActualSessionsForClient(int clientId, DateTime actualDateTime);

		/// <summary>
		/// Вовзрат всех недействиетльных или прошедших записей для клиента
		/// </summary>
		/// <param name="clientId">Идентификатор клиента</param>
		/// <param name="actualDateTime">Актуальное дата и время обращения</param>
		/// <returns>Коллекция экземпляров записей</returns>
		IEnumerable<Session> GetNonActualSessionsForClient(int clientId, DateTime actualDateTime);

		/// <summary>
		/// Возврат всех актуальных записей для доктора
		/// </summary>
		/// <param name="doctorId">Идентификатор врача</param>
		/// <param name="actualDateTime">Актуальное дата и время обращения</param>
		/// <returns>Коллекция экземпляров записей</returns>
		IEnumerable<Session> GetActualSessionsForDoctor(int doctorId, DateTime actualDateTime);

		/// <summary>
		/// Возврат всех неактуальных или прошедших записей для доктора
		/// </summary>
		/// <param name="doctorId">Идентификатор врача</param>
		/// <param name="actualDateTime">Актуальное дата и время обращения</param>
		/// <returns>Коллекция экземпляров записей</returns>
		IEnumerable<Session> GetNonActualSessionsForDoctor(int doctorId, DateTime actualDateTime);

		/// <summary>
		/// Добавление новой записи в базу
		/// </summary>
		/// <param name="clientId">Идентификатор клиента</param>
		/// <param name="doctorId">Идентификатор доктора</param>
		/// <param name="DateTimeOfBegin">Дата и время начала сеанса</param>
		/// <param name="DateTimeOfEnd">Дата и время конца сеанса</param>
		void AddNewSession(int clientId, int doctorId, DateTime DateTimeOfBegin, DateTime DateTimeOfEnd);

		/// <summary>
		/// Удаление записи
		/// </summary>
		/// <param name="sessionId">Идентификатор сессии</param>
		void DeleteSession(int sessionId);
	}
}
