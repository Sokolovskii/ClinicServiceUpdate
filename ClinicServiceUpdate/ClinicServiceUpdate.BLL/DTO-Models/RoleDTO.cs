using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class RoleDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public PoliticElemDTO[] PoliticElems { get; set; }
	}

	public class PoliticElemDTO
	{
		public RuleDTO Rule { get; set; }
		public bool IsActive { get; set; }
	}
}
