using System.Data.Entity;

namespace ItPedia.Models.Contexts
{
    public class ItPediaDbContext : DbContext
    {
        //        public DbSet<Proposal> Proposals { get; set; }
        //        public DbSet<Solution> Solutions { get; set; }
        public ItPediaDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<SolutionCategory> SolutionCategories { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<IndustryCriteria> IndustryCriterias { get; set; }
        public DbSet<EmployeeCriteria> EmployeeCriterias { get; set; }
        public DbSet<CustomerCriteria> CustomerCriterias { get; set; }
        public DbSet<TransactionCriteria> TransactionCriterias { get; set; }
    }
}