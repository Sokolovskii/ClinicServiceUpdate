namespace CLinicServiceUpdate.DAL.Models
{
	class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string PassHash { get; set; }
		public string Email { get; set; }
		public int RoleId { get; set; }
		public int PositionId {get;set;}
		
	}
}
