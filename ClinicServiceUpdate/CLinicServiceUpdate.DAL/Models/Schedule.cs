using System;

namespace ClinicServiceUpdate.DAL.Models
{
	public class Schedule
	{
		public int UserId { get; set; }
		public DateTime ActualisationDate { get; set; }
		public WorkDay Monday { get; set; }
		public WorkDay Tuesday { get; set; }
		public WorkDay Wednesday { get; set; }
		public WorkDay Thursday { get; set; }
		public WorkDay Fryday { get; set; }
		public WorkDay Saturday { get; set; }
		public WorkDay Sunday { get; set; }
	}
	
	public class WorkDay
	{
		public TimeSpan DayBegin { get; set; }
		public TimeSpan DayEnd { get; set; }
	}
}
