namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Email { get; set; }
		public RoleDTO Role { get; set; }
		public PositionDTO Position { get; set; }
	}
}
