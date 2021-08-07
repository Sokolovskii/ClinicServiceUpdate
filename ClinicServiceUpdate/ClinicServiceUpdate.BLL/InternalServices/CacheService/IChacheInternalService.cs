using System;

namespace ClinicServiceUpdate.BLL.InternalServices.CacheService
{
	/// <summary>
	/// Служба кэширования объектов
	/// </summary>
	interface IChacheInternalService
	{
		/// <summary>
		/// Извлекает объект из кэша или запрашивает его из БД, пишет в кэш и отдает
		/// </summary>
		/// <typeparam name="T">Возвращаемый DTO-объект из кэша</typeparam>
		/// <param name="key">DTO-объект для поиска</param>
		/// <param name="createItem">Делегат запроса объекта из БД и его конвертации в DTO</param>
		/// <returns>Экземпляр DTO-объекта</returns>
		T GetOrCreate<T>(object key, Func<T> createItem);
	}
}
