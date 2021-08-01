using System;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.ScheduleRepository
{
	class ScheduleRepository : IScheduleRepository
	{
		public void AddNewSchedule(int userId, DateTime actualisationTime, WorkDay[] workDays)
		{
			throw new NotImplementedException();
		}

		public Schedule GetActualScheduleByUserId(int userId)
		{
			throw new NotImplementedException();
		}
	}
}
