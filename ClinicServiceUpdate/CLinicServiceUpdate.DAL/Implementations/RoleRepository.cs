using System;
using System.Collections.Generic;
using System.Text;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Handlers;
using System.Data;

namespace ClinicServiceUpdate.DAL.Implementations
{
	/// <summary>
	/// Реализация интерфейса
	/// </summary>
	/// <inheritdoc cref="IRoleRepository"/>
	public class RoleRepository : IRoleRepository
	{
		private readonly Db _db;

		/// <summary>
		/// .ctor
		/// </summary>
		/// <param name="db"></param>
		public RoleRepository(Db db)
		{
			_db = db;
		}
		public void AddNewRole(string name, PoliticElem[] politicElems)
		{
			var roleId = _db.AddItemReturnId("AddNewRole",
				new DbParam("@Name", name));
			AddNewPoliticsElem(roleId, politicElems);
		}

		public IEnumerable<Role> GetAllRoles()
		{
			var roles = _db.GetList("GetAllRoles", RoleFromReader);
			foreach(Role role in roles)
			{
				role.PoliticElems = GetPoliticElemsByRoleId(role.Id);
			}
			return roles;
		}

		public Role GetRoleById(int roleId)
		{
			var role = _db.GetItem("GetRoleById", RoleFromReader,
				new DbParam("@Id", roleId));
			role.PoliticElems = GetPoliticElemsByRoleId(roleId);
			return role;
		}

		private PoliticElem[] GetPoliticElemsByRoleId(int roleId)
		{
			return _db.GetList("GetAllPoliticsByRoleId", PoliticElemFromReader,
				new DbParam("@Id", roleId)).ToArray();
		}

		private void AddNewPoliticsElem(int roleId, PoliticElem[] politicElems)
		{
			foreach(PoliticElem elem in politicElems)
			{
				_db.ExecuteNonQuery("AddNewPolitic",
					new DbParam("@RoleId", roleId),
					new DbParam("@RightId", elem.RuleId),
					new DbParam("@RightIsActive", elem.IsActive));
			}
		}

		private Role RoleFromReader(IDataReader reader)
		{
			return new Role
			{
				 Id = reader.GetIntOrZero("Id"),
				 Name = reader.GetString("Name")
			};
		}

		private PoliticElem PoliticElemFromReader(IDataReader reader)
		{
			return new PoliticElem
			{
				RuleId = reader.GetIntOrZero("RightId"),
				IsActive = reader.GetBoolean("RightIsActive")
			};
		}
	}
}
