using System;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class ScheduleDTO
	{
		public UserDTO UserId { get; set; }
		public DateTime ActualisationDate { get; set; }
		public WorkDayDTO Monday { get; set; }
		public WorkDayDTO Tuesday { get; set; }
		public WorkDayDTO Wednesday { get; set; }
		public WorkDayDTO Thursday { get; set; }
		public WorkDayDTO Fryday { get; set; }
		public WorkDayDTO Saturday { get; set; }
		public WorkDayDTO Sunday { get; set; }
	}

	public class WorkDayDTO
	{
		public TimeSpan DayBegin { get; set; }
		public TimeSpan DayEnd { get; set; }
	}
}
