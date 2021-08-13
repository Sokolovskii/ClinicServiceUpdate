using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class RequestDTO
	{
		public int Id { get; set; }
		public UserDTO Sender { get; set; }
		public UserDTO Reciever { get; set; }
		public TypeOfRequestDTO Type { get; set; }
		public string Content { get; set; }
		public DateTime DateOfCreate { get; set; }
		public DateTime DateOfComplete { get; set; }
		public bool Status { get; set; }
	}
}
