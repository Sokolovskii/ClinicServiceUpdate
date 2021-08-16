using ClinicServiceUpdate.DAL.Models;
using System.Collections.Generic;

namespace ClinicServiceUpdate.BLL.ExternalServices.AccountService
{
	/// <summary>
	/// Интерфейс внешней службы личного кабинета
	/// </summary>
	public interface IAccountExternalService
	{
		/// <summary>
		/// Обновляет имя пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="name">Новое имя пользователя</param>
		void UpdateName(int userId, string name);

		/// <summary>
		/// Обновляет адрес электронной почты пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользовтаеля</param>
		/// <param name="Email">Новый адрес электронной почты</param>
		void UpdateEmail(int userId, string Email);

		/// <summary>
		/// Обновлялет пароль пользователя
		/// </summary>
		/// <param name="userId">Индентификатор пользователя</param>
		/// <param name="passHash">Хэш пароля</param>
		void UpdatePassword(int userId, string passHash);

		/// <summary>
		/// Обновляет аватар пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="photo">Аватар</param>
		void UpdateAvatar(int userId, byte[] photo);
	}
}
