using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models
{
	class Request
	{
		public int Id { get; set; }
		public int SenderId { get; set; }
		public int RecieverId { get; set; }
		public int TypeId { get; set; }
		public string Content { get; set; }
		public DateTime DateOfCreate { get; set; }
		public DateTime DateOfCOmplete { get; set; }
	}
}
