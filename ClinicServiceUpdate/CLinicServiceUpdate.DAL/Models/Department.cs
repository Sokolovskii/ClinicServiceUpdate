namespace CLinicServiceUpdate.DAL.Models
{
	class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int SubordinateId { get; set; }
	}
}
