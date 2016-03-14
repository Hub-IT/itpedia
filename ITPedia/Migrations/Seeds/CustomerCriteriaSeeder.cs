using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class CustomerCriteriaSeeder
    {
        public CustomerCriteriaSeeder(ItPediaDbContext context)
        {

            var customerCriteriaUpTo500 = new CustomerCriteria
            {
                Size = "Up to 500",
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
                }
            };
            var customerCriteriaMore500 = new CustomerCriteria
            {
                Size = "More than 500",
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
                }
            };
            var customerCriterias = new List<CustomerCriteria> { customerCriteriaMore500, customerCriteriaUpTo500 };

            context.CustomerCriterias.AddOrUpdate(p => p.Size, customerCriterias.ToArray());
            context.SaveChanges();
        }
    }
}