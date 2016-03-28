using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class TransactionCriteriaSeeder
    {
        public TransactionCriteriaSeeder(ItPediaDbContext context)
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

            var employeeCriteriaUpTo10 = context.EmployeeCriteria.First(i => i.Size == "Up to 10");
            var employeeCriteria11To50 = context.EmployeeCriteria.First(i => i.Size == "11 - 50");
            var employeeCriteria51To200 = context.EmployeeCriteria.First(i => i.Size == "51 - 200");
            var employeeCriteriaNotNecessary = context.EmployeeCriteria.First(i => i.Size == "Not necessary");

            var customerCriteriaUpTo500 = context.CustomerCriterias.First(i => i.Size == "Up to 500");
            var customerCriteriaMore500 = context.CustomerCriterias.First(i => i.Size == "More than 500");

            var transactionCriteriaUpTo100 = new TransactionCriterion
            {
                PerMonth = "Up to 100",
                IndustryCriteria = new List<IndustryCriterion>
                {
                    homeBusiness,
                    exportBusiness,
                    telecommunication,
                    banking,
                    retail,
                    automobile,
                    advertising,
                    insurance,
                    oil,
                    pharmaceutical,
                    waterSupply,
                    police,
                    tvBroadcasting,
                    stockExchange,
                    energy,
                    transportation
                },
                EmployeeCriteria = new List<EmployeeCriterion>
                {
                    employeeCriteriaUpTo10,
                    employeeCriteria11To50,
                    employeeCriteria51To200,
                    employeeCriteriaNotNecessary
                },
                CustomerCriteria = new List<CustomerCriterion> {customerCriteriaUpTo500, customerCriteriaMore500}
            };
            var transactionCriteriaMoreThan100 = new TransactionCriterion
            {
                PerMonth = "More than 100",
                IndustryCriteria = new List<IndustryCriterion>
                {
                    homeBusiness,
                    exportBusiness,
                    telecommunication,
                    banking,
                    retail,
                    automobile,
                    advertising,
                    insurance,
                    oil,
                    pharmaceutical,
                    waterSupply,
                    police,
                    tvBroadcasting,
                    stockExchange,
                    energy,
                    transportation
                },
                EmployeeCriteria = new List<EmployeeCriterion>
                {
                    employeeCriteriaUpTo10,
                    employeeCriteria11To50,
                    employeeCriteria51To200,
                    employeeCriteriaNotNecessary
                },
                CustomerCriteria = new List<CustomerCriterion> {customerCriteriaUpTo500, customerCriteriaMore500}
            };

            var transactionCriterias = new List<TransactionCriterion>
            {
                transactionCriteriaUpTo100,
                transactionCriteriaMoreThan100
            };

            context.TransactionCriteria.AddOrUpdate(p => p.PerMonth, transactionCriterias.ToArray());

            context.SaveChanges();
        }
    }
}