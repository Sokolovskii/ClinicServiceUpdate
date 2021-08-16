using System;
using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;

namespace ClinicServiceUpdate.BLL.ExternalServices.SessionService
{
	public class SessionExternalService : ISessionExternalService
	{
		private readonly ISessionRepository _sessionRepository;

		public SessionExternalService(ISessionRepository sessionRepository)
		{
			_sessionRepository = sessionRepository;
		}
		public void CreateSession(int clientId, int doctorId, DateTime DateTimeOfBegin, DateTime DateTimeOfEnd)
		{
			_sessionRepository.AddNewSession(clientId, doctorId, DateTimeOfBegin, DateTimeOfEnd);
		}

		public void DeleteSession(int sessionId)
		{
			_sessionRepository.DeleteSession(sessionId);
		}

		public IEnumerable<Session> GetActualSessionsForClient(int clientId)
		{
			return _sessionRepository.GetActualSessionsForClient(clientId, DateTime.Now);
		}

		public IEnumerable<Session> GetActualSessionsForDoctor(int doctorId)
		{
			return _sessionRepository.GetActualSessionsForDoctor(doctorId, DateTime.Now);
		}

		public IEnumerable<Session> GetNonActualSessionsForClient(int clientId)
		{
			return _sessionRepository.GetNonActualSessionsForClient(clientId, DateTime.Now);
		}

		public IEnumerable<Session> GetNonActualSessionsForDoctor(int doctorId)
		{
			return _sessionRepository.GetNonActualSessionsForDoctor(doctorId, DateTime.Now);
		}

		public Session GetSession(int sessionId)
		{
			return _sessionRepository.GetSessionById(sessionId);
		}

		public IEnumerable<Session> GetSessionsOnDay(DateTime date, int doctorId)
		{
			return _sessionRepository.GetActualSessionsOnDay(doctorId, date);
		}
	}
}
