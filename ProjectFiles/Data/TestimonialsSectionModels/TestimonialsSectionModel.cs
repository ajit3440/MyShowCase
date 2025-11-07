namespace MyShowCase.Data.TestimonialsSectionModels
{
    // --- Models ---
    public class TestimonialsSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public List<CriticReview> Critics { get; set; } = new();
        public List<TestimonialItem> Testimonials { get; set; } = new();
        public OverallRating Summary { get; set; } = new();
    }

    public class CriticReview
    {
        public string Source { get; set; } = string.Empty;
        public string Quote { get; set; } = string.Empty;
        public double Rating { get; set; } = 5.0;
    }

    public class TestimonialItem
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Review { get; set; } = string.Empty;
        public double Rating { get; set; } = 5.0;
    }

    public class OverallRating
    {
        public double AverageRating { get; set; }
        public int ReviewCount { get; set; }
        public List<string> Platforms { get; set; } = new();
    }
}
