using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class EmployeeCriteriaSeeder
    {
        public EmployeeCriteriaSeeder(ItPediaDbContext context)
        {
            var homeBusiness = context.IndustryCriterias.First(i => i.Name == "Home Business");

            var employeeCriteriaUpTo10 = new EmployeeCriteria
            {
                Size = "Up to 10",
                IndustryCriterias = new List<IndustryCriteria> { homeBusiness, retail, automobile }
            };
            var employeeCriteria11To50 = new EmployeeCriteria
            {
                Size = "11 - 50",
                IndustryCriterias =
                    new List<IndustryCriteria>
                    {
                        exportBusiness,
                        retail,
                        automobile,
                        advertising,
                        pharmaceutical,
                        waterSupply
                    }
            };
            var employeeCriteria51To200 = new EmployeeCriteria
            {
                Size = "51 - 200",
                IndustryCriterias =
                    new List<IndustryCriteria>
                    {
                        telecommunication,
                        banking,
                        automobile,
                        insurance,
                        oil,
                        pharmaceutical,
                        waterSupply,
                        tvBroadcasting
                    }
            };
            var employeeCriteriaNotNecessary = new EmployeeCriteria
            {
                Size = "Not necessary",
                IndustryCriterias = new List<IndustryCriteria> { police, stockExchange, energy, transportation }
            };
            var employeeCriterias = new List<EmployeeCriteria>
            {
                employeeCriteriaUpTo10,
                employeeCriteria11To50,
                employeeCriteria51To200,
                employeeCriteriaNotNecessary
            };

            context.EmployeeCriterias.AddOrUpdate(p => p.Size, employeeCriterias.ToArray());
            context.SaveChanges();
        }
    }
}