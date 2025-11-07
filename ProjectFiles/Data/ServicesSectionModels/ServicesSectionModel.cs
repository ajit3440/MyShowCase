namespace MyShowCase.Data.ServicesSectionModels
{
    // --- Models ---
    public class ServicesSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public List<ServiceCard> Services { get; set; } = new();
    }

    public class ServiceCard
    {
        public string Icon { get; set; } = string.Empty;     // e.g., "bi bi-stack"
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LinkText { get; set; } = "Learn More";
        public string LinkUrl { get; set; } = "#";
        public int AOSDelay { get; set; } = 100;             // for data-aos-delay
    }
}
