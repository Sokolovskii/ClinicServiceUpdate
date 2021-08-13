using System;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class SessionDTO
	{
		public int Id { get; set; }
		public UserDTO Client { get; set; }
		public UserDTO Doctor { get; set; }
		public DateTime DateTimeBegin { get; set; }
		public DateTime DateTimeEnd { get; set; }
	}
}
