using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace YourNamespace.Models
{
    public class YourDbContext : DbContext
    {

        public YourDbContext()
            : base("name=GrowthAndDevelopmentContext")
        {
        }

        public DbSet<ExampleModel> ExampleModels { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Example>().HasKey(e => e.Example2ID).Property(a => a.ExampleID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Example2>().HasRequired(e => e.ExampleID).WithMany(c => c.Example).WillCascadeOnDelete(false);
        }
    }
}
