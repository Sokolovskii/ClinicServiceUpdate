using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RequestRepository
{
	class RequestRepository : IRequestRepository
	{
		public void AccessRequest(int requestId)
		{
			throw new NotImplementedException();
		}

		public void AddNewRequest(Request request)
		{
			throw new NotImplementedException();
		}

		public void DenyId(int requestId)
		{
			throw new NotImplementedException();
		}

		public Request GetRequestById(int requestId)
		{
			throw new NotImplementedException();
		}

		public List<Request> GetRequestsByUserId(int userId)
		{
			throw new NotImplementedException();
		}
	}
}
