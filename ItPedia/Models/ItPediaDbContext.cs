using System.Data.Entity;
using ItPedia.Models;

namespace ItPedia.Models
{
    public class ItPediaDbContext : DbContext
    {
        public DbSet<SolutionCategory> SolutionCategories { get; set; }
//        public DbSet<CustomerCriteria> CustomerCriterias { get; set; }
//        public DbSet<EmployeeCriteria> EmployeeCriterias { get; set; }
//        public DbSet<IndustryCriteria> IndustryCriterias { get; set; }
//        public DbSet<MetaData> MetaData { get; set; }
//        public DbSet<Proposal> Proposals { get; set; }
//        public DbSet<Solution> Solutions { get; set; }
//        public DbSet<Term> Terms { get; set; }
//        public DbSet<TransactionPmCriteria> TransactionPmCriterias { get; set; }
    }
}