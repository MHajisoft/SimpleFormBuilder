namespace SimpleFormBuilder.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public byte[] Version { get; set; } = null;

        public string Note { get; set; }
    }    
}
