namespace MyShowCase.Data.ResumeSectionModels
{
    // -------------------- Models --------------------
    public class ResumeSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public ExperienceSection Experience { get; set; } = new();
        public EducationSection Education { get; set; } = new();
    }

    public class ExperienceSection
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public List<ExperienceItem> Items { get; set; } = new();
    }

    public class ExperienceItem
    {
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Achievements { get; set; } = new();
    }

    public class EducationSection
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public List<EducationItem> Items { get; set; } = new();
    }

    public class EducationItem
    {
        public string Degree { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
