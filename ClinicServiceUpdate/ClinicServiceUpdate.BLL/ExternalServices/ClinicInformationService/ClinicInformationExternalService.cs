using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models;
using ClinicServiceUpdate.DAL.Models.UserModels;
using ClinicServiceUpdate.DAL.Abstractions;

namespace ClinicServiceUpdate.BLL.ExternalServices.ClinicInformationService
{
	/// <summary>
	/// Реализация интерфейса сервиса предоставления информации о больнице
	/// </summary>
	class ClinicInformationExternalService : IClinicInformationExternalService
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly IUserRepository _userRepository;

		public ClinicInformationExternalService(
			IDepartmentRepository departmentRepository,
			IUserRepository userRepository)
		{
			_departmentRepository = departmentRepository;
			_userRepository = userRepository;
		}
		public IEnumerable<Department> GetAllDepartments()
		{
			return _departmentRepository.GetAllDepartments();
		}

		public Department GetDepartmentById(int departmentId)
		{
			return _departmentRepository.GetDepartmentById(departmentId);
		}

		public IEnumerable<UserWithAvatar> GetDoctorsByDepartmentId(int departmentId)
		{
			var users = _userRepository.GetUsersByDepartment(departmentId);
			foreach(var user in users)
			{
				yield return new UserWithAvatar
				{
					User = user,
					Avatar = _userRepository.GetAvatarByUserId(user.Id).Photo
				};
			}
		}

		public IEnumerable<UserWithAvatar> GetDoctorsByPositionId(int positionId)
		{
			var users = _userRepository.GetUsersByPosition(positionId);
			foreach(var user in users)
			{
				yield return new UserWithAvatar
				{
					User = user,
					Avatar = _userRepository.GetAvatarByUserId(user.Id).Photo
				};
			}
		}
	}
}
