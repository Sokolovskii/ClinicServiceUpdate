using System;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	public class ScheduleRepository : IScheduleRepository
	{
		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		/// <param name="db"></param>
		public ScheduleRepository(Db db)
		{
			_db = db;
		}

		public void AddNewSchedule(int userId, DateTime actualisationTime, WorkDay[] workDays)
		{
			_db.ExecuteNonQuery("AddNewSchedule",
				new DbParam("@UserId", userId),
				new DbParam("@ActualisationTime", actualisationTime),
				new DbParam("@MondayBegining", workDays[0].DayBegin),
				new DbParam("@MondayEnding", workDays[0].DayEnd),
				new DbParam("@TuesdayBegining", workDays[1].DayBegin),
				new DbParam("@TuesdayEnding", workDays[1].DayEnd),
				new DbParam("@WednesdayBegining", workDays[2].DayBegin),
				new DbParam("@WednesdayEnding", workDays[2].DayEnd),
				new DbParam("@ThursdayBegining", workDays[3].DayBegin),
				new DbParam("@ThursdayEnding", workDays[3].DayEnd),
				new DbParam("@FrydayBegining", workDays[4].DayBegin),
				new DbParam("@FrydayEnding", workDays[4].DayEnd),
				new DbParam("@SaturdayBegining", workDays[5].DayBegin),
				new DbParam("@SaturdayEnding", workDays[5].DayEnd),
				new DbParam("@SundayBegining", workDays[6].DayBegin),
				new DbParam("@SundayEnding", workDays[6].DayEnd));
		}

		public Schedule GetActualScheduleByUserId(int userId, DateTime actualDate)
		{
			return _db.GetItem("GetScheduleByUserId", ScheduleFromReader,
				new DbParam("@UserId", userId),
				new DbParam("@ActualDate", actualDate.Date));
		}

		private Schedule ScheduleFromReader(IDataReader reader)
		{
			return new Schedule
			{
				UserId = reader.GetIntOrZero("UserId"),
				ActualisationDate = reader.GetDate("Actualisation_Date"),
				Monday = new WorkDay
				{
					DayBegin = reader.GetTime("Monday_Beginning"),
					DayEnd = reader.GetTime("Monday_Ending")
				},
				Tuesday = new WorkDay
				{
					DayBegin = reader.GetTime("Tuesday_Beginning"),
					DayEnd = reader.GetTime("Tuesday_Ending")
				},
				Wednesday = new WorkDay
				{
					DayBegin = reader.GetTime("Wednesday_Beginning"),
					DayEnd = reader.GetTime("Wednesday_Ending")
				},
				Thursday = new WorkDay
				{
					DayBegin = reader.GetTime("Thursday_Beginning"),
					DayEnd = reader.GetTime("Thursday_Ending")
				},
				Fryday = new WorkDay
				{
					DayBegin = reader.GetTime("Fryday_Beginning"),
					DayEnd = reader.GetTime("Fryday_Ending")
				},
				Saturday = new WorkDay
				{
					DayBegin = reader.GetTime("Saturday_Beginning"),
					DayEnd = reader.GetTime("Saturday_Ending")
				},
				Sunday = new WorkDay
				{
					DayBegin = reader.GetTime("Sunday_Beginning"),
					DayEnd = reader.GetTime("Sunday_Ending")
				}
			};
		}
	}
}
