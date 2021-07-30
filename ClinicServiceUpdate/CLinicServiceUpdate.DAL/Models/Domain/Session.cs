using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models
{
	class Session
	{
		public int Id { get; set; }
		public int ClientId { get; set; }
		public int DoctorId { get; set; }
		public DateTime dateTimeBegin { get; set; }
		public DateTime dateTimeEnd { get; set; }
	}
}
