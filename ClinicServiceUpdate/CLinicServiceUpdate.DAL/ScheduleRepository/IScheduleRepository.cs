using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.ScheduleRepository
{
	interface IScheduleRepository
	{
		void AddNewSchedule(Schedule schedule);

		Schedule GetActualScheduleByUserId(int userId);
	}
}
