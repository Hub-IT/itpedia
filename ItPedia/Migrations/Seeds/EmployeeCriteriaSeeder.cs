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
            var homeBusiness = context.IndustryCriteria.First(i => i.Name == "Home Business");
            var exportBusiness = context.IndustryCriteria.First(i => i.Name == "Export Business");
            var telecommunication = context.IndustryCriteria.First(i => i.Name == "Telecommunications");
            var banking = context.IndustryCriteria.First(i => i.Name == "Banking");
            var retail = context.IndustryCriteria.First(i => i.Name == "Retail");
            var automobile = context.IndustryCriteria.First(i => i.Name == "Automobile");
            var advertising = context.IndustryCriteria.First(i => i.Name == "Advertising");
            var insurance = context.IndustryCriteria.First(i => i.Name == "Insurance");
            var oil = context.IndustryCriteria.First(i => i.Name == "Oil");
            var pharmaceutical = context.IndustryCriteria.First(i => i.Name == "Pharmaceutical");
            var waterSupply = context.IndustryCriteria.First(i => i.Name == "Water Supply");
            var police = context.IndustryCriteria.First(i => i.Name == "Police");
            var tvBroadcasting = context.IndustryCriteria.First(i => i.Name == "TV Broadcasting");
            var stockExchange = context.IndustryCriteria.First(i => i.Name == "Stock Exchange");
            var energy = context.IndustryCriteria.First(i => i.Name == "Energy");
            var transportation = context.IndustryCriteria.First(i => i.Name == "Transportation");

            var employeeCriteriaUpTo10 = new EmployeeCriterion
            {
                Size = "Up to 10",
                IndustryCriteria = new List<IndustryCriterion> { homeBusiness, retail, automobile }
            };
            var employeeCriteria11To50 = new EmployeeCriterion
            {
                Size = "11 - 50",
                IndustryCriteria =
                    new List<IndustryCriterion>
                    {
                        exportBusiness,
                       retail,
                        automobile,
                        advertising,
                        pharmaceutical,
                        waterSupply
                    }
            };
            var employeeCriteria51To200 = new EmployeeCriterion
            {
                Size = "51 - 200",
                IndustryCriteria =
                    new List<IndustryCriterion>
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
            var employeeCriteriaNotNecessary = new EmployeeCriterion
            {
                Size = "Not necessary",
                IndustryCriteria = new List<IndustryCriterion> { police, stockExchange, energy, transportation }
            };
            var employeeCriterias = new List<EmployeeCriterion>
            {
                employeeCriteriaUpTo10,
                employeeCriteria11To50,
                employeeCriteria51To200,
                employeeCriteriaNotNecessary
            };

            context.EmployeeCriteria.AddOrUpdate(p => p.Size, employeeCriterias.ToArray());
            context.SaveChanges();
        }
    }
}