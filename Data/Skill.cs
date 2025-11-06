namespace MyShowCase.Data
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty; // e.g. FontAwesome icon class
        public string Category { get; set; } = string.Empty; // Frontend, Backend, Tools, etc.
        public int Proficiency { get; set; } // Percentage (0–100)
    }
}
