using System;
using System.Collections.Generic;
using System.Text;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;

namespace ClinicServiceUpdate.BLL.ExternalServices.RequestService
{
	public class RequestExternalService : IRequestExternalService
	{
		private readonly IRequestRepository _requestRepository;

		public RequestExternalService(IRequestRepository requestRepository)
		{
			_requestRepository = requestRepository;
		} 


		public void AccessRequest(int requestId)
		{
			_requestRepository.AccessRequest(requestId);
		}

		public void AddRequest(int senderId, int recieverId, int typeId, string content)
		{
			_requestRepository.AddNewRequest(senderId, recieverId, typeId, content);
		}

		public void DenyRequest(int requestId)
		{
			_requestRepository.DenyRequest(requestId);
		}

		public IEnumerable<Request> GetRequestsForUser(int userId)
		{
			return _requestRepository.GetRequestsByUserId(userId);
		}
	}
}
