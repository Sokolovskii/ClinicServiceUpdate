using System;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозиторий расписания
	/// </summary>
	public interface IScheduleRepository
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
		Schedule GetActualScheduleByUserId(int userId, DateTime actualDateTime);
	}
}
