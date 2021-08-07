namespace ClinicServiceUpdate.BLL.InternalServices.ValidatorService
{
	/// <summary>
	/// Служба валидации
	/// </summary>
	interface IValidatorInternalService
	{
		/// <summary>
		/// Проверка на наличие объекта и значений в нем
		/// </summary>
		/// <typeparam name="T">Тип проверямого объекта</typeparam>
		/// <param name="obj">Объект для проверки</param>
		/// <returns>
		/// True - ссылка указывает на null или в объекте все значения нулевые, 
		/// False - ссылка указывает на действительный объект, имеющий ненулевые значения 
		/// </returns>
		bool IsNull<T>(T obj);

		/// <summary>
		/// Проверка на корректность данных в объекте
		/// </summary>
		/// <typeparam name="T">Тип проверяемого объекта</typeparam>
		/// <param name="obj">Объект для проверки</param>
		/// <returns>
		/// True - данные некорректны, объект невалиден
		/// False - данные корректны, объект валиден
		/// </returns>
		bool HasntCorrectValues<T>(T obj);
	}
}
