using System.Collections.Generic;
using System.Data;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;

namespace ClinicServiceUpdate.DAL.Implementations
{
	public class DepartmentRepository : IDepartmentRepository
	{

		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		/// <param name="db"></param>
		public DepartmentRepository(Db db)
		{
			_db = db;
		}

		public void AddDepartment(string name, string description, int subordinateId)
		{
			_db.ExecuteNonQuery("AddNewDepartment",
				new DbParam("@Name", name),
				new DbParam("@Description", description),
				new DbParam("SubordinateId", subordinateId));
		}

		public void DeleteDepartment(int departmentId)
		{
			_db.ExecuteNonQuery("DeleteDepartment");
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			return _db.GetList("GetAllDepartments", DepartmentFromReader);
		}

		public Department GetDepartmentById(int departmentId)
		{
			return _db.GetItem("GetDepartmentById", DepartmentFromReader,
				new DbParam("@Id", departmentId));
		}

		private static Department DepartmentFromReader(IDataReader reader)
		{
			return new Department
			{
				Id = reader.GetIntOrZero("Id"),
				Name = reader.GetString("Name"),
				Description = reader.GetString("Description"),
				SubordinateId = reader.GetIntOrZero("SubordinateId")
			};
		}
	}
}
