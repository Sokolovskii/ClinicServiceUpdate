using ClinicServiceUpdate.DAL.Models.UserModels;

namespace ClinicServiceUpdate.BLL.InternalServices.AuthorizationService
{
	/// <summary>
	/// Сервис проверки прав доступа
	/// </summary>
	interface IAuthorizationInternalService
	{
		/// <summary>
		/// Проверка на наличие прав доступа к опреации.
		/// </summary>
		/// <param name="user">Экземпляр пользователя для проверки прав доступа</param>
		/// <param name="politics">Политики для проверки соответствия</param>
		/// <returns>
		/// True - Разрешения имеются, пользователь может продолжать работу.
		/// False - Разрешений не имеется, пользователь не имеет прав к данной службе.
		/// </returns>
		bool HasPermission(User user, params Politics[] politics);
	}
}
