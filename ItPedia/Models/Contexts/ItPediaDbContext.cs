using System.Data.Entity;
using ItPedia.Migrations;

namespace ItPedia.Models.Contexts
{
    public class ItPediaDbContext : DbContext
    {
        public ItPediaDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Term> Terms { get; set; }
        public DbSet<IndustryCriteria> IndustryCriterias { get; set; }
        public DbSet<EmployeeCriteria> EmployeeCriterias { get; set; }
        public DbSet<CustomerCriteria> CustomerCriterias { get; set; }
        public DbSet<TransactionCriteria> TransactionCriterias { get; set; }
        public DbSet<Solution> Solutions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItPediaDbContext, Configuration>());
        }
    }
}