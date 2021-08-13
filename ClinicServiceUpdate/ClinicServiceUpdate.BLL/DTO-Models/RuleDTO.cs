namespace ClinicServiceUpdate.BLL.DTO_Models
{
	public class RuleDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public RuleDTO DependOn { get; set; }
	}
}
