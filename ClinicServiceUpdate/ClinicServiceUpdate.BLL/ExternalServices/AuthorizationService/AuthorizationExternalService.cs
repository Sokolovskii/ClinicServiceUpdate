using ClinicServiceUpdate.DAL.Models.UserModels;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.BLL.Exceptions;
using ClinicServiceUpdate.BLL.InternalServices;

namespace ClinicServiceUpdate.BLL.ExternalServices.AuthorizationService
{
	public class AuthorizationExternalService : IAuthorizationExternalService
	{
		private readonly IUserRepository _userRepository;

		public AuthorizationExternalService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public UserWithAvatar LogIn(string login, string password)
		{
			var dbPassHash = _userRepository.GetPassHashByLogin(login);

			if(dbPassHash != password.GetPassHash())
			{
				throw new WarningException(ExceptionMessages.WrongLoginOrPassword);
			}
			return _userRepository.GetUserByLogin(login);
		}

		public UserWithAvatar Register(string login, string name, string password)
		{
			_userRepository.AddNewUser(name, login, password.GetPassHash());
			return _userRepository.GetUserByLogin(login);
		}
	}
}
