namespace MyShowCase.Data.EF.Entities
{
	public class ContentItem
	{
		public int Id { get; set; }
		public string Key { get; set; } = string.Empty; // e.g., "AboutSection"
		public string Json { get; set; } = string.Empty;
		public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
	}
}
