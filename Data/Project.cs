namespace MyShowCase.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string GitHubLink { get; set; } = string.Empty;
        public string LiveDemoLink { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
