namespace ClinicServiceUpdate.BLL.InternalServices.LoggerService
{
	/// <summary>
	/// Служба логирования
	/// </summary>
	interface ILoggerInternalService
	{
		/// <summary>
		/// Написание лога
		/// </summary>
		/// <param name="message">Текст лога</param>
		void AddLog(string message);
	}
}
