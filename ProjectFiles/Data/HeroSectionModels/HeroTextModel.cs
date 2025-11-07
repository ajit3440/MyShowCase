namespace MyShowCase.Data.HeroSectionModels
{
    public class HeroTextModel
    {
        public string TitlePrefix { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string twitter { get; set; } = string.Empty;
        public string linkedin { get; set; } = string.Empty;
        public string github { get; set; } = string.Empty;
        public string instagram { get; set; } = string.Empty;
        public List<HeroStatText> Stats { get; set; } = new();
    }

    public class HeroStatText
    {
        public string Label { get; set; } = string.Empty;
        public int Value { get; set; }
    }
}
