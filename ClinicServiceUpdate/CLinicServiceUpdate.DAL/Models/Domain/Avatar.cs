using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models.Domain
{
	class Avatar
	{
		public int UserId { get; set; }
		public byte[] Photo { get; set; }
	}
}
