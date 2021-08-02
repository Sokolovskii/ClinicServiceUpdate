using System;
using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.SessionRepository
{
	class SessionRepository : ISessionRepository
	{
		public void AddNewSession(int clientId, int doctorId, DateTime DateTimeOfBegin, DateTime DateTimeOfEnd)
		{
			throw new NotImplementedException();
		}

		public void DeleteSession(int sessionId)
		{
			throw new NotImplementedException();
		}

		public List<Session> GetActualSessionsForClient(int clientId, DateTime actualDateTime)
		{
			throw new NotImplementedException();
		}

		public List<Session> GetActualSessionsForDoctor(int doctorId, DateTime actualDateTime)
		{
			throw new NotImplementedException();
		}

		public List<Session> GetNonActualSessionsForClient(int clientId, DateTime actualDateTime)
		{
			throw new NotImplementedException();
		}

		public List<Session> GetNonActualSessionsForDoctor(int doctorId, DateTime actualDateTime)
		{
			throw new NotImplementedException();
		}

		public Session GetSessionById(int sessionId)
		{
			throw new NotImplementedException();
		}
	}
}
