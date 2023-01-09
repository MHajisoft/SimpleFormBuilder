using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Database
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Note).IsUnicode().HasMaxLength(500);

            Property(x => x.Version).IsRequired().IsRowVersion().IsConcurrencyToken();
        }
    }
}