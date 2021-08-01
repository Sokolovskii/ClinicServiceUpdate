using System;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.ScheduleRepository
{
	/// <summary>
	/// Репозиторий расписания
	/// </summary>
	interface IScheduleRepository
	{
		/// <summary>
		/// Добавление нового расписания для работника
		/// </summary>
		/// <param name="userId">Идентификатор работника</param>
		/// <param name="actualisationTime">Дата актуализации расписания</param>
		/// <param name="workDays">Совокупность времен начала и конца рабочего дня</param>
		void AddNewSchedule(int userId, DateTime actualisationTime, WorkDay[] workDays);

		/// <summary>
		/// Возврат актуального расписания для пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <returns>Экземпляр расписания</returns>
		Schedule GetActualScheduleByUserId(int userId);
	}
}
