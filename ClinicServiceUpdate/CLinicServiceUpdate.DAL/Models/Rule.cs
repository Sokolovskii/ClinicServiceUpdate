namespace ClinicServiceUpdate.DAL.Models
{
	public class Rule
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DependOn { get; set; }
	}
}
