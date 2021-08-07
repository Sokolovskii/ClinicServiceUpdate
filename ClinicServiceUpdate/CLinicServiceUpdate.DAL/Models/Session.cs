using System;

namespace ClinicServiceUpdate.DAL.Models
{
	public class Session
	{
		public int Id { get; set; }
		public int ClientId { get; set; }
		public int DoctorId { get; set; }
		public DateTime DateTimeBegin { get; set; }
		public DateTime DateTimeEnd { get; set; }
	}
}
