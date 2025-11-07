namespace MyShowCase.Data.ContactSectionModels
{
    // --- Models ---
    public class ContactSectionModel
    {
        public string SectionTitle { get; set; } = string.Empty;
        public string SectionSubtitle { get; set; } = string.Empty;
        public ContactInfo Info { get; set; } = new();
        public ContactForm Form { get; set; } = new();
    }

    public class ContactInfo
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<ContactInfoItem> Items { get; set; } = new();
    }

    public class ContactInfoItem
    {
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public List<string> Lines { get; set; } = new();
    }

    public class ContactForm
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string Method { get; set; } = "post";
        public List<FormField> Fields { get; set; } = new();
        public string SubmitButtonText { get; set; } = "Send Message";
    }

    public class FormField
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = "text";
        public string Placeholder { get; set; } = string.Empty;
        public bool IsRequired { get; set; } = true;
        public int Rows { get; set; } = 3;
    }
}
