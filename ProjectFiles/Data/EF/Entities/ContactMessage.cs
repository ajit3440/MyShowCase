namespace MyShowCase.Data.EF.Entities
{
	public class ContactMessage
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string? Subject { get; set; }
		public string Message { get; set; } = string.Empty;
		public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
	}
}
