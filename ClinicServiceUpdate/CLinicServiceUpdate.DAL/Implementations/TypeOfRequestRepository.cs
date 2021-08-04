using System;
using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	public class TypeOfRequestRepository : ITypeOfRequestRepository
	{
		private readonly Db _db;

		public TypeOfRequestRepository(Db db)
		{
			_db = db;
		}
		public void AddTypeOfRequest(string name)
		{
			_db.ExecuteNonQuery("AddNewTypeOfRequest",
				new DbParam("@Name", name));
		}

		public void DeleteTypeOfRequest(int typeId)
		{
			_db.ExecuteNonQuery("DeleteTypeOfRequestById",
				new DbParam("@Id", typeId));
		}

		public TypeOfRequest GetTypeOfRequestById(int typeId)
		{
			return _db.GetItem("GetTypeOfRequestById", TypeFromReader,
				new DbParam("@Id", typeId));
		}

		public IEnumerable<TypeOfRequest> GetTypeOfRequests()
		{
			return _db.GetList("GetAllTypesOfRequest", TypeFromReader);
		}

		private TypeOfRequest TypeFromReader(IDataReader reader)
		{
			return new TypeOfRequest
			{
				Id = reader.GetIntOrZero("Id"),
				Name = reader.GetString("Name")
			};
		}
	}
}
