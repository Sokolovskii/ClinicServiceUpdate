using System;
using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.DepartmentRepository
{
	class DepartmentRepository : IDepartmentRepository
	{
		public void AddDepartment(string name, string description, int subordinateId)
		{
			throw new NotImplementedException();
		}

		public void DeleteDepartment(int departmentId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			throw new NotImplementedException();
		}

		public Department GetDepartmentById(int departmentId)
		{
			throw new NotImplementedException();
		}
	}
}
