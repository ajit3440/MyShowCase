namespace MyShowCase.Data.SkillsSectionModels
{
    // --- Models ---
    public class SkillsSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SummaryTitle { get; set; } = string.Empty;
        public string SummaryDescription { get; set; } = string.Empty;
        public List<SkillCategory> Categories { get; set; } = new();
        public List<SummaryStat> Stats { get; set; } = new();
        public List<SkillBadge> Certifications { get; set; } = new();
    }

    public class SkillCategory
    {
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public List<SkillItem> Skills { get; set; } = new();
    }

    public class SkillItem
    {
        public string Name { get; set; } = string.Empty;
        public int Percentage { get; set; }
    }

    public class SummaryStat
    {
        public string Icon { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
    }

    public class SkillBadge
    {
        public string Name { get; set; } = string.Empty;
    }
}
