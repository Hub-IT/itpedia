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
        public DbSet<IndustryCriterion> IndustryCriteria { get; set; }
        public DbSet<EmployeeCriterion> EmployeeCriteria { get; set; }
        public DbSet<CustomerCriterion> CustomerCriterias { get; set; }
        public DbSet<TransactionCriterion> TransactionCriteria { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<ProposalTerm> ProposalTerms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItPediaDbContext, Configuration>());
        }
    }
}