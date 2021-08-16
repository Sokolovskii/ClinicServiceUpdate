using System;
using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	public class SessionRepository : ISessionRepository
	{
		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		public SessionRepository(Db db)
		{
			_db = db;
		}
		public void AddNewSession(int clientId, int doctorId, DateTime dateTimeOfBegin, DateTime dateTimeOfEnd)
		{
			_db.ExecuteNonQuery("AddNewSession",
				new DbParam("@ClientId", clientId),
				new DbParam("@DoctorId", doctorId),
				new DbParam("@DateTimeOfBegin", dateTimeOfBegin),
				new DbParam("@DateTimeOfEnd", dateTimeOfEnd));	
		}

		public void DeleteSession(int sessionId)
		{
			_db.ExecuteNonQuery("DeleteSession", 
				new DbParam("@Id", sessionId));
		}

		public IEnumerable<Session> GetActualSessionsForClient(int clientId, DateTime actualDateTime)
		{
			return _db.GetList("GetActualSessionsForClient", SessionFromReader,
				new DbParam("@ClientId", clientId),
				new DbParam("@ActualDateTime", actualDateTime));
		}

		public IEnumerable<Session> GetActualSessionsForDoctor(int doctorId, DateTime actualDateTime)
		{
			return _db.GetList("GetActualSessionsForDoctor", SessionFromReader,
				new DbParam("@DoctorId", doctorId),
				new DbParam("@ActualDateTime", actualDateTime));
		}

		public IEnumerable<Session> GetActualSessionsOnDay(int doctorId, DateTime actualDate)
		{
			return _db.GetList("GetActualSessionsOnDay", SessionFromReader,
				new DbParam("@DoctorId", doctorId),
				new DbParam("@Date", actualDate.Date));
		}

		public IEnumerable<Session> GetNonActualSessionsForClient(int clientId, DateTime actualDateTime)
		{
			return _db.GetList("GetNonActualSessionsForClient", SessionFromReader,
				new DbParam("@ClientId", clientId),
				new DbParam("@ActualDateTime", actualDateTime));
		}

		public IEnumerable<Session> GetNonActualSessionsForDoctor(int doctorId, DateTime actualDateTime)
		{
			return _db.GetList("GetNonActualSessionsForDoctor", SessionFromReader,
				new DbParam("@DoctorId", doctorId),
				new DbParam("@ActualDateTime", actualDateTime));
		}

		public Session GetSessionById(int sessionId)
		{
			return _db.GetItem("GetSessionById", SessionFromReader,
				new DbParam("@Id", sessionId));
		}

		private Session SessionFromReader(IDataReader reader)
		{
			return new Session
			{
				Id = reader.GetIntOrZero("Id"),
				ClientId = reader.GetIntOrZero("ClientId"),
				DoctorId = reader.GetIntOrZero("DoctorId"),
				DateTimeBegin = reader.GetDateTime("DateTimeBegin"),
				DateTimeEnd = reader.GetDateTime("DateTimeEnd")
			};
		}
	}
}
