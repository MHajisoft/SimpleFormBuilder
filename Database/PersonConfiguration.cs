using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Database
{
    public class PersonConfiguration : BaseEntityConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(x => x.FirstName).IsOptional().IsUnicode(true).HasMaxLength(50);
            Property(x => x.LastName).IsOptional().IsUnicode(true).HasMaxLength(100);
            Property(x => x.ChildCount).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.Picture).IsOptional().IsMaxLength();
            Property(x => x.TagsList).IsOptional();
            Ignore(x => x.Tags);
            
            Ignore(x => x.PictureString);
        }
    }
}