using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class TransactionCriteriaSeeder
    {
        public TransactionCriteriaSeeder(ItPediaDbContext context)
        {
            var transactionCriteriaUpTo100 = new TransactionCriteria
            {
                PerMonth = "Up to 100",
                IndustryCriterias = new List<IndustryCriteria>
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
                EmployeeCriterias = new List<EmployeeCriteria>
                {
                    employeeCriteriaUpTo10,
                    employeeCriteria11To50,
                    employeeCriteria51To200,
                    employeeCriteriaNotNecessary
                },
                CustomerCriterias = new List<CustomerCriteria> { customerCriteriaUpTo500, customerCriteriaMore500 }
            };
            var transactionCriteriaMoreThan100 = new TransactionCriteria
            {
                PerMonth = "More than 100",
                IndustryCriterias = new List<IndustryCriteria>
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
                EmployeeCriterias = new List<EmployeeCriteria>
                {
                    employeeCriteriaUpTo10,
                    employeeCriteria11To50,
                    employeeCriteria51To200,
                    employeeCriteriaNotNecessary
                },
                CustomerCriterias = new List<CustomerCriteria> { customerCriteriaUpTo500, customerCriteriaMore500 }
            };
            var transactionCriterias = new List<TransactionCriteria>
            {
                transactionCriteriaUpTo100,
                transactionCriteriaMoreThan100
            };
            context.TransactionCriterias.AddOrUpdate(p => p.PerMonth, transactionCriterias.ToArray());
            context.CustomerCriterias.AddOrUpdate(p => p.Size, customerCriterias.ToArray());
            context.SaveChanges();

            
        }
    }
}