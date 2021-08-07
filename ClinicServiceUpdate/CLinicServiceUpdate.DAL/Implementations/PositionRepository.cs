using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	public class PositionRepository : IPositionRepository
	{

		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		/// <param name="db"></param>
		public PositionRepository(Db db)
		{
			_db = db;
		}
		public void AddPosition(string name, int departmentId)
		{
			_db.ExecuteNonQuery("AddNewPosition",
				new DbParam("@Name", name),
				new DbParam("@DepartmentId", departmentId));
		}

		public void DeletePosition(int positionId)
		{
			_db.ExecuteNonQuery("DeletePosition",
				new DbParam("@Id", positionId));
		}

		public IEnumerable<Position> GetAllPositions()
		{
			return _db.GetList("GetAllPositions", PositionFromReader);
		}

		public Position GetPositionById(int positionId)
		{
			return _db.GetItem("GetPositionById", PositionFromReader);
		}

		public IEnumerable<Position> GetPositionsByDepartmentId(int departmentId)
		{
			return _db.GetList("GetPositionsByDepartmentId", PositionFromReader);
		}

		private Position PositionFromReader(IDataReader reader)
		{
			return new Position
			{
				Id = reader.GetIntOrZero("Id"),
				Name = reader.GetString("Name"),
				DepartmentId = reader.GetIntOrZero("DepartmentId")
			};
		}
	}
}
