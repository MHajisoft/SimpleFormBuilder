using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Database
{
    public class CustomPropertyConfiguration : BaseEntityConfiguration<CustomProperty>
    {
        public CustomPropertyConfiguration()
        {
            Property(x => x.EntityName).IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.PropertyName).IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Title).IsRequired().IsUnicode(true).HasMaxLength(100);

            //ToDo موارد غیر فعال شده در ادامه باید پیاده سازی شوند
            Ignore(x => x.Category);
            Ignore(x => x.PropertyDescriptor);
            Ignore(x => x.Mask);
            Ignore(x => x.Tooltip);
            Ignore(x => x.PlaceHolder);
            Ignore(x => x.Permission);
            Ignore(x => x.IsRequired);
            Ignore(x => x.IsSelectable);
            Ignore(x => x.IsMultiSelect);

            Property(x => x.IsActive).IsRequired();
            Property(x => x.OrderIndex).IsRequired();
        }
    }
}