namespace MyShowCase.Data.AboutSectionModels
{
    public class AboutSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = string.Empty;
        public string SignatureImageUrl { get; set; } = string.Empty;
        public string Quote { get; set; } = string.Empty;
        public string IntroTitle { get; set; } = string.Empty;
        public string IntroDescription { get; set; } = string.Empty;
        public List<AboutSkill> Skills { get; set; } = new();
        public List<JourneyTimeline> Timeline { get; set; } = new();
        public string FunFactEmoji { get; set; } = string.Empty;
        public string FunFactText { get; set; } = string.Empty;
        public string PrimaryButtonText { get; set; } = string.Empty;
        public string PrimaryButtonLink { get; set; } = string.Empty;
        public string SecondaryButtonText { get; set; } = string.Empty;
        public string SecondaryButtonLink { get; set; } = string.Empty;
    }
}
