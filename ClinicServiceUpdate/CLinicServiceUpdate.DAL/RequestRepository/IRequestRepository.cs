using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RequestRepository
{
	interface IRequestRepository
	{
		void AddNewRequest(Request request);

		void AccessRequest(int requestId);

		void DenyId(int requestId);

		Request GetRequestById(int requestId);

		List<Request> GetRequestsByUserId(int userId);
	}
}
