using System;
using System.Collections.Generic;
using System.Text;
using CLinicServiceUpdate.DAL.Models;

namespace CLinicServiceUpdate.DAL.RoleRepository
{
	/// <summary>
	/// Реализация интерфейса
	/// </summary>
	/// <inheritdoc cref="IRoleRepository"/>
	class RoleRepository : IRoleRepository
	{
		public void AddNewRole(string name, params PoliticElem[] politicElems)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Role> GetAllRoles()
		{
			throw new NotImplementedException();
		}

		public Role GetRoleById(int roleId)
		{
			throw new NotImplementedException();
		}
	}
}
