using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models
{
	class Schedule
	{
		public int UserId { get; set; }
		public DateTime ActualisationTime { get; set; }
		public WorkDay[] TimesOfWeek { get; set; }
	}
	
	class WorkDay
	{
		public TimeSpan DayBegin { get; set; }
		public TimeSpan DayEnd { get; set; }
	}
}
