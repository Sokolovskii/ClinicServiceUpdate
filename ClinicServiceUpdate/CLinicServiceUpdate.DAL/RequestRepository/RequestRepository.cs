using System;
using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RequestRepository
{
	/// <summary>
	/// Реализация интерфейса репозитория
	/// </summary>
	/// <inheritdoc cref= "IRequestRepository"/>
	class RequestRepository : IRequestRepository
	{
		public void AccessRequest(int requestId)
		{
			throw new NotImplementedException();
		}

		public void AddNewRequest(int senderId, int recieverId, int typeId, string content, DateTime dateTimeOfCreate)
		{
			throw new NotImplementedException();
		}

		public void DenyId(int requestId)
		{
			throw new NotImplementedException();
		}

		public void DenyRequest(int requestId)
		{
			throw new NotImplementedException();
		}

		public Request GetRequestById(int requestId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Request> GetRequestsByUserId(int userId)
		{
			throw new NotImplementedException();
		}
	}
}
