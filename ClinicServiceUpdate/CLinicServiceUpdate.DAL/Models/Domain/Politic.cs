using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models
{
	class Politic
	{
		public int RoleId { get; set; }
		public PoliticElem[] PoliticElems { get; set; }
	}

	class PoliticElem
	{
		public int RightId { get; set; }
		public bool IsActive { get; set; }
	}
}
