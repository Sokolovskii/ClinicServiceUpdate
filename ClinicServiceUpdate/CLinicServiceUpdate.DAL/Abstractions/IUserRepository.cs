using System.Collections.Generic;
using ClinicServiceUpdate.DAL.Models.UserModels;
using ClinicServiceUpdate.DAL.Models;

namespace ClinicServiceUpdate.DAL.Abstractions
{
	/// <summary>
	/// Репозиторий пользовательских данных
	/// </summary>
	public interface IUserRepository
	{
		/// <summary>
		/// Возврат пользователя по его идентификатору
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <returns>Экземпляр пользователя</returns>
		UserWithAvatar GetUserById(int userId);
		
		/// <summary>
		/// Возврат пользователя по логину
		/// </summary>
		/// <param name="login">Логин пользователя</param>
		/// <returns>Экземпляр пользователя</returns>
		UserWithAvatar GetUserByLogin(string login);

		/// <summary>
		/// Возврат хеша пароля по логину
		/// </summary>
		/// <param name="login">Логин</param>
		/// <returns>хэш пароля</returns>
		string GetPassHashByLogin(string login);

		/// <summary>
		/// Возврат всех пользователей, занимающих указанную должность
		/// </summary>
		/// <param name="positionId">Идентификатор должности</param>
		/// <returns>Коллекция пользователей</returns>
		IEnumerable<User> GetUsersByPosition(int positionId);

		/// <summary>
		/// Возврат всех пользователей, работающих в указанном отделении
		/// </summary>
		/// <param name="departmentId">Идентификатор отделения</param>
		/// <returns>Коллекция пользователей</returns>
		IEnumerable<User> GetUsersByDepartment(int departmentId);
	
		/// <summary>
		/// Добавление нового пользователя
		/// </summary>
		/// <param name="userName">Имя пользователя</param>
		/// <param name="login">Логин</param>
		/// <param name="passHash">Пароль</param>
		void AddNewUser(string userName, string login, string passHash);

		/// <summary>
		/// Возвращает аватар пользователя по его Id
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <returns>Аватар пользователя</returns>
		Avatar GetAvatarByUserId(int userId);

		/// <summary>
		/// Добавление аватара
		/// </summary>
		/// <param name="userId">Идентификатор пользователя, к которому будет прикреплен аватар</param>
		/// <param name="photo">Фотография</param>
		void AddNewAvatar(int userId, byte[] photo);

		/// <summary>
		/// Удаление аватара пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя, у которого будет удален аватар</param>
		void DeleteAvatar(int userId);

		/// <summary>
		/// Обновление/добавление адреса электронной почты для пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="newEmail">Email-адрес</param>
		void UpdateUserEmail(int userId, string newEmail);

		/// <summary>
		/// Изменяет имя пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="newUserName">Новое имя пользователя</param>
		void UpdateUserName(int userId, string newUserName);

		/// <summary>
		/// Обновляет должность пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="newPositionId">Идентификатор должности</param>
		void UpdateUserPosition(int userId, int newPositionId);

		/// <summary>
		/// Обновляет роль пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="roleId">Идентификатор роли</param>
		void UpdateUserRole(int userId, int roleId);

		/// <summary>
		/// Обновляет хэшпароля пользователя
		/// </summary>
		/// <param name="userId">Идентификатор пользователя</param>
		/// <param name="newPassHash">Новый хэш пароля</param>
		void UpdateUserPassHash(int userId, string newPassHash);
	}
}
