namespace ClinicServiceUpdate.DAL.Handlers
{
	/// <summary>
	/// Класс, описывающий пару ключ-значение для параметров процедур sql
	/// </summary>
	public class DbParam
	{
		public string Key { get; }

		public object Value { get; }

		public DbParam(string key, object value)
		{
			Key = key;
			Value = value;
		}
	}
}
