namespace MyShowCase.Data.PortfolioSectionModels
{
    // --- Models ---
    public class PortfolioSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public List<PortfolioFilter> Filters { get; set; } = new();
        public List<PortfolioItem> Items { get; set; } = new();
    }

    public class PortfolioFilter
    {
        public string FilterClass { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string? Icon { get; set; }
        public bool IsActive { get; set; } = false;
    }

    public class PortfolioItem
    {
        public string CategoryClass { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string LightboxDescription { get; set; } = string.Empty;
        public string DetailsPageUrl { get; set; } = string.Empty;
    }
}
