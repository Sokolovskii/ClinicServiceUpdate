using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicServiceUpdate.DAL.Models.UserModels
{
	public class UserWithAvatar : User
	{
		public byte[] Avatar;

		public UserWithAvatar(int id, string name, string login, string email, int roleId, int positionId, byte[] avatar)
		{
			this.Id = id;
			this.Name = name;
			this.Login = login;
			this.Email = email;
			this.RoleId = roleId;
			this.PositionId = positionId;
			this.Avatar = avatar;
		}
	}
}
