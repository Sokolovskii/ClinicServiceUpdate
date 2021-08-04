using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	/// <summary>
	/// Реализация интерфейса репозитория
	/// </summary>
	/// <inheritdoc cref= "IRequestRepository"/>
	public class RequestRepository : IRequestRepository
	{
		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		public RequestRepository(Db db)
		{
			_db = db;
		} 

		public void AccessRequest(int requestId)
		{
			_db.ExecuteNonQuery("AccessRequest",
				new DbParam("@Id", requestId));
		}

		public void AddNewRequest(int senderId, int recieverId, int typeId, string content)
		{
			_db.ExecuteNonQuery("AddNewRequest",
				new DbParam("@SenderId", senderId),
				new DbParam("@RecieverId", recieverId),
				new DbParam("@TypeId", typeId),
				new DbParam("@Content", content));
		}

		public void DenyRequest(int requestId)
		{
			_db.ExecuteNonQuery("DenyRequest",
				new DbParam("@Id", requestId));
		}

		public Request GetRequestById(int requestId)
		{
			return _db.GetItem("GetRequestById", RequestFromReader,
				new DbParam("@Id", requestId));
		}

		public IEnumerable<Request> GetRequestsByUserId(int userId)
		{
			return _db.GetList("GetRequestsForUser", RequestFromReader,
				new DbParam("@UserId", userId));
		}

		private Request RequestFromReader(IDataReader reader)
		{
			return new Request
			{
				Id = reader.GetIntOrZero("Id"),
				SenderId = reader.GetIntOrZero("SenderId"),
				RecieverId = reader.GetIntOrZero("RecieverId"),
				TypeId = reader.GetIntOrZero("TypeId"),
				Content = reader.GetString("Content"),
				DateOfCreate = reader.GetDateTime("DateOfCreate"),
				DateOfComplete = reader.GetDateTime("DateOfComplete"),
				Status = reader.GetBoolean("Status")
			};
		}
	}
}
