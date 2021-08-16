using ClinicServiceUpdate.DAL.Models.UserModels;

namespace ClinicServiceUpdate.BLL.ExternalServices.AuthorizationService
{
	/// <summary>
	/// Интерфейс внешней службы авторизации
	/// </summary>
	public interface IAuthorizationExternalService
	{
		/// <summary>
		/// Авторизация существующего пользователя
		/// </summary>
		/// <param name="login">логин</param>
		/// <param name="password">пароль</param>
		/// <returns>Юзер из базы</returns>
		UserWithAvatar LogIn(string login, string password);

		/// <summary>
		/// Регистрация пользователя в системе
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="name">Имя пользователя</param>
		/// <param name="password">Пароль</param>
		/// <returns>Юзер из базы</returns>
		UserWithAvatar Register(string login, string name, string password);
	}
}
