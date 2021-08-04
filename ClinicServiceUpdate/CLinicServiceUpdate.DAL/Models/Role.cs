namespace ClinicServiceUpdate.DAL.Models
{
	public class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public PoliticElem[] PoliticElems { get; set; }

	}

	public class PoliticElem
	{
		public int RuleId { get; set; }
		public bool IsActive { get; set; }
	}
}
