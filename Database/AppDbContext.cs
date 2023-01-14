using System.Data.Entity;
using SimpleFormBuilder.Entity;
using SimpleFormBuilder.Migrations;

namespace SimpleFormBuilder.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("SimpleFormConnection")
        {
            // System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
            System.Data.Entity.Database.SetInitializer(new AppDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new CustomPropertyConfiguration());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<CustomProperty> CustomProperties { get; set; }
    }
}