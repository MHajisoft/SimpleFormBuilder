using System.ComponentModel.DataAnnotations;

namespace SimpleFormBuilder.Entity
{
    public class CustomProperty : BaseEntity
    {
        [Required] public string EntityName { get; set; }

        [Required] public string PropertyName { get; set; }

        [Required] public string Title { get; set; }

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

        [Range(1, 100)] [Required] public int OrderIndex { get; set; } = 1;
    }
}