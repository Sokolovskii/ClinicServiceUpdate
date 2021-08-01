using System;
using System.Collections.Generic;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.UserRepository
{
	/// <summary>
	/// Реализация интерфейса репозитория пользователя
	/// </summary>
	/// <inheritdoc cref="IUserRepository"/>
	class UserRepository : IUserRepository
	{
		public void AddNewAvatar(int userId, byte[] photo)
		{
			throw new NotImplementedException();
		}

		public void AddNewUser(string userName, string login, string passHash)
		{
			throw new NotImplementedException();
		}

		public void DeleteAvatar(int userId)
		{
			throw new NotImplementedException();
		}

		public Avatar GetAvatarByUserId(int userId)
		{
			throw new NotImplementedException();
		}

		public User GetUserById(int userId)
		{
			throw new NotImplementedException();
		}

		public User GetUserByLogin(string login)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsersByDepartment(int departmentId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsersByPosition(int positionId)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserEmail(int userId, string newEmail)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserName(int userId, string newUserName)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserPassHash(int userId, int newPassHash)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserPosition(int userId, int newPositionId)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserRole(int userId, int roleId)
		{
			throw new NotImplementedException();
		}
	}
}
