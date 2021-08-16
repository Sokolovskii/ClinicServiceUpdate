using ClinicServiceUpdate.DAL.Abstractions;

namespace ClinicServiceUpdate.BLL.ExternalServices.AccountService
{
	public class AccountExternalService : IAccountExternalService
	{
		private readonly IUserRepository _userRepository;

		public AccountExternalService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public void UpdateAvatar(int userId, byte[] photo)
		{
			_userRepository.DeleteAvatar(userId);
			_userRepository.AddNewAvatar(userId, photo);
		}

		public void UpdateEmail(int userId, string Email)
		{
			_userRepository.UpdateUserEmail(userId, Email);
		}

		public void UpdateName(int userId, string name)
		{
			_userRepository.UpdateUserName(userId, name);
		}

		public void UpdatePassword(int userId, string passHash)
		{
			_userRepository.UpdateUserPassHash(userId, passHash);
		}
	}
}
