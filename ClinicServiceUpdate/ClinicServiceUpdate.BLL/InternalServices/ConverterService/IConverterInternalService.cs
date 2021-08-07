namespace ClinicServiceUpdate.BLL.InternalServices.ConverterService
{
	/// <summary>
	/// Служба конвертации обектов доменнной модели в DTO-объекты и обратно
	/// </summary>
	public interface IConverterInternalService
	{
		/// <summary>
		/// Конвертация объекта доменной модели в DTO
		/// </summary>
		/// <typeparam name="T">DTO</typeparam>
		/// <typeparam name="U">Объект доменной модели</typeparam>
		/// <param name="domainObject">Экземпляр модели для конвертации</param>
		/// <returns>DTO</returns>
		T DomainToDTO<T, U>(U domainObject);

		/// <summary>
		/// Конвертация DTO в объект доменной модели
		/// </summary>
		/// <typeparam name="T">Объект доменной модели</typeparam>
		/// <typeparam name="U">DTO для конвертации</typeparam>
		/// <param name="dto">Экземпляр DTO</param>
		/// <returns>Экземпляр доменной модели</returns>
		T DTOToDonain<T, U>(U dto);
	}
}
