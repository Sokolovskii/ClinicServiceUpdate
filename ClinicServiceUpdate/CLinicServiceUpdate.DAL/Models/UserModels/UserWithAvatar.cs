namespace ClinicServiceUpdate.DAL.Models.UserModels
{
	/// <summary>
	/// Модель пользователя с аватаром
	/// </summary>
	public class UserWithAvatar
	{
		public User User { get; set; }
		public byte[] Avatar { get; set; }
	}
}
