using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RoleRepository
{
	interface IRoleRepository
	{
		Role GetRoleById(int roleId);

		List<Role> GetAllRoles();

		void AddNewRole(Role role);

	}
}
