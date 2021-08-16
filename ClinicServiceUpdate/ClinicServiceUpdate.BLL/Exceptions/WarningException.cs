using System;

namespace ClinicServiceUpdate.BLL.Exceptions
{
	/// <summary>
	/// Исключение для предусмотренных приложением ситуаций
	/// </summary>
	public class WarningException : Exception
	{
		public WarningException(string message) : base(message){}
	}
}
