using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL.Models
{
	class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public PoliticElem[] PoliticElems { get; set; }

	}

	class PoliticElem
	{
		public Rule Rule { get; set; }
		public bool IsActive { get; set; }
	}
}
