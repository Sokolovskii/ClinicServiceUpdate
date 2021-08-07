using System;

namespace ClinicServiceUpdate.DAL.Models
{
	public class Request
	{
		public int Id { get; set; }
		public int SenderId { get; set; }
		public int RecieverId { get; set; }
		public int TypeId { get; set; }
		public string Content { get; set; }
		public DateTime DateOfCreate { get; set; }
		public DateTime DateOfComplete { get; set; }
		public bool Status { get; set; }
	}
}
