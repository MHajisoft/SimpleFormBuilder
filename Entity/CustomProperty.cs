namespace SimpleFormBuilder.Entity
{
    public class CustomProperty : BaseEntity
    {
        public string EntityName { get; set; }

        public string PropertyName { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string PropertyDescriptor { get; set; }

        public string Mask { get; set; }

        public string Tooltip { get; set; }

        public string PlaceHolder { get; set; }

        public string Permission { get; set; }

        public bool IsRequired { get; set; }

        public bool IsSelectable { get; set; }

        public bool IsMultiSelect { get; set; }

        public bool IsActive { get; set; } = true;

        public int OrderIndex { get; set; } = 1;
    }
}