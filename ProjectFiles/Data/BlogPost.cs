namespace MyShowCase.Data
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty; // for URL path
        public string Content { get; set; } = string.Empty; // Markdown or HTML
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; } = DateTime.Now;
        public List<string> Tags { get; set; } = new();
    }
}
