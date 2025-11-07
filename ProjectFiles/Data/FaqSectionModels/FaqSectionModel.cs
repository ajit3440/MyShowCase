namespace MyShowCase.Data.FaqSectionModels
{
    public class FaqSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public List<FaqItem> Faqs { get; set; } = new();
    }

    public class FaqItem
    {
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
    }
}
