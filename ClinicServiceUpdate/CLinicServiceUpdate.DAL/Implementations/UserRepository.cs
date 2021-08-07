using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models.UserModels;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	/// <summary>
	/// Реализация интерфейса репозитория пользователя
	/// </summary>
	/// <inheritdoc cref="IUserRepository"/>
	public class UserRepository : IUserRepository
	{

		private readonly Db _db;

		public UserRepository(Db db)
		{
			_db = db;
		}
		public void AddNewAvatar(int userId, byte[] photo)
		{
			_db.ExecuteNonQuery("AddNewAvatar",
				new DbParam("@UserId", userId),
				new DbParam("@Photo", photo));
		}

		public void AddNewUser(string userName, string login, string passHash)
		{
			_db.ExecuteNonQuery("AddNewUser",
				new DbParam("@Name", userName),
				new DbParam("@Login", login),
				new DbParam("@PassHash", passHash));
		}

		public void DeleteAvatar(int userId)
		{
			_db.ExecuteNonQuery("DeleteAvatar",
				new DbParam("@UserId", userId));
		}

		public Avatar GetAvatarByUserId(int userId)
		{
			return _db.GetItem("GetAvatarByUserId", AvatarFromReader,
				new DbParam("@UserId", userId));
		}

		public UserWithAvatar GetUserById(int userId)
		{
			return _db.GetItem("GetUserById", UserWithAvatarFromReader,
				new DbParam("@Id", userId));
		}

		public string GetPassHashByLogin(string login)
		{
			return _db.GetItem("GetPassHashByUserLogin", PassHashFromReader,
				new DbParam("@Login", login));
		}

		public IEnumerable<User> GetUsersByDepartment(int departmentId)
		{
			return _db.GetList("GetUsersByDepartmentId", UserFromReader,
				new DbParam("@DepartmentId", departmentId));
		}

		public IEnumerable<User> GetUsersByPosition(int positionId)
		{
			return _db.GetList("GetUsersByPositionId", UserFromReader,
				new DbParam("@PositionId", positionId));
		}

		public void UpdateUserEmail(int userId, string newEmail)
		{
			_db.ExecuteNonQuery("UpdateUserEmail",
				new DbParam("@Id", userId),
				new DbParam("@EMail", newEmail));
		}

		public void UpdateUserName(int userId, string newUserName)
		{
			_db.ExecuteNonQuery("UpdateUserName",
				new DbParam("@Id", userId),
				new DbParam("@Name", newUserName));
		}

		public void UpdateUserPassHash(int userId, int newPassHash)
		{
			_db.ExecuteNonQuery("UpdatePassHash",
				new DbParam("@Id", userId),
				new DbParam("@Name", newPassHash));
		}

		public void UpdateUserPosition(int userId, int newPositionId)
		{
			_db.ExecuteNonQuery("UpdateUserPosition",
				new DbParam("@Id", userId),
				new DbParam("@Name", newPositionId));
		}

		public void UpdateUserRole(int userId, int roleId)
		{
			_db.ExecuteNonQuery("UpdateUserName",
				new DbParam("@Id", userId),
				new DbParam("@Name", roleId));
		}

		private User UserFromReader(IDataReader reader)
		{
			return new User
			{
				Id = reader.GetIntOrZero("Id"),
				Name = reader.GetString("Name"),
				Login = reader.GetString("Login"),
				Email = reader.GetString("EMail"),
				RoleId = reader.GetIntOrZero("RoleId"),
				PositionId = reader.GetIntOrZero("PositionId")
			};
		}

		private string PassHashFromReader(IDataReader reader)
		{
			return reader.GetString("PassHash");
		}

		private UserWithAvatar UserWithAvatarFromReader(IDataReader reader)
		{
			return new UserWithAvatar
			{
				Id = reader.GetIntOrZero("Id"),
				Name = reader.GetString("Name"),
				Login = reader.GetString("Login"),
				Email = reader.GetString("EMail"),
				RoleId = reader.GetIntOrZero("RoleId"),
				PositionId = reader.GetIntOrZero("PositionId"),
				Avatar = reader.GetBytes("Photo")
			};
		}

		private Avatar AvatarFromReader(IDataReader reader)
		{
			return new Avatar
			{
				UserId = reader.GetIntOrZero("UserId"),
				Photo = reader.GetBytes("Photo")
			};
		}
	}
}
