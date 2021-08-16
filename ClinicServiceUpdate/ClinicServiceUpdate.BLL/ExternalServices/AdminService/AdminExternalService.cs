using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Abstractions;

namespace ClinicServiceUpdate.BLL.ExternalServices.AdminService
{
	public class AdminExternalService : IAdminExternalService
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly IPositionRepository _positionRepository;
		private readonly IRoleRepository _roleRepository;
		private readonly IUserRepository _userRepository;

		public AdminExternalService(IDepartmentRepository departmentRepository,
			IPositionRepository positionRepository,
			IRoleRepository roleRepository,
			IUserRepository userRepository)
		{
			_departmentRepository = departmentRepository;
			_positionRepository = positionRepository;
			_roleRepository = roleRepository;
			_userRepository = userRepository;
		}
		public void AddNewDepartment(string name, string description, int subordinatedOn)
		{
			_departmentRepository.AddDepartment(name, description, subordinatedOn);
		}

		public void AddNewPosition(string name, int departmentId)
		{
			_positionRepository.AddPosition(name, departmentId);
		}

		public void AddNewRole(string name, PoliticElem[] politics)
		{
			_roleRepository.AddNewRole(name, politics);
		}

		public void ChangeUserPosition(int userId, int positionId)
		{
			_userRepository.UpdateUserPosition(userId, positionId);
		}

		public void ChangeUserRole(int userId, int roleId)
		{
			_userRepository.UpdateUserRole(userId, roleId);
		}
	}
}
