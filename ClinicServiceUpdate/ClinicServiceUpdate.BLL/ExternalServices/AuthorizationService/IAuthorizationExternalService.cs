using ClinicServiceUpdate.DAL.Models.UserModels;

namespace ClinicServiceUpdate.BLL.ExternalServices.AuthorizationService
{
	/// <summary>
	/// Интерфейс внешней службы авторизации
	/// </summary>
	interface IAuthorizationExternalService
	{
		/// <summary>
		/// Авторизация существующего пользователя
		/// </summary>
		/// <param name="login">логин</param>
		/// <param name="password">пароль</param>
		/// <returns>Юзер из базы</returns>
		User LogIn(string login, string password);

		/// <summary>
		/// Регистрация пользователя в системе
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="name">Имя пользователя</param>
		/// <param name="password">Пароль</param>
		/// <returns>Юзер из базы</returns>
		User Register(string login, string name, string password);

		/// <summary>
		/// Выводит юзера из системы
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		void LogOut(int userId);
	}
}
