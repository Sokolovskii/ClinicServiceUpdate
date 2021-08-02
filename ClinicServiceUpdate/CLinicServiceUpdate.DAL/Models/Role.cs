namespace CLinicServiceUpdate.DAL.Models
{
	class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public PoliticElem[] PoliticElems { get; set; }

	}

	class PoliticElem
	{
		public int RuleId { get; set; }
		public bool IsActive { get; set; }
	}
}
