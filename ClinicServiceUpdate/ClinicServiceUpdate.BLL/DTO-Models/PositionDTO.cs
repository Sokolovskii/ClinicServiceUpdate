using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class PositionDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DepartmentDTO Department { get; set; }
	}
}
