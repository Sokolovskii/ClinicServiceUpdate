using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class DepartmentDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DepartmentDTO Subordinate { get; set; }
	}
}
