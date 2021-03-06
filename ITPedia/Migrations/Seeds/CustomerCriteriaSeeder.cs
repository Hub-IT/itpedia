﻿using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class CustomerCriteriaSeeder
    {
        public CustomerCriteriaSeeder(ItPediaDbContext context)
        {
            var homeBusiness = context.IndustryCriterias.First(i => i.Name == "Home Business");
            var exportBusiness = context.IndustryCriterias.First(i => i.Name == "Export Business");
            var telecommunication = context.IndustryCriterias.First(i => i.Name == "Telecommunications");
            var banking = context.IndustryCriterias.First(i => i.Name == "Banking");
            var retail = context.IndustryCriterias.First(i => i.Name == "Retail");
            var automobile = context.IndustryCriterias.First(i => i.Name == "Automobile");
            var advertising = context.IndustryCriterias.First(i => i.Name == "Advertising");
            var insurance = context.IndustryCriterias.First(i => i.Name == "Insurance");
            var oil = context.IndustryCriterias.First(i => i.Name == "Oil");
            var pharmaceutical = context.IndustryCriterias.First(i => i.Name == "Pharmaceutical");
            var waterSupply = context.IndustryCriterias.First(i => i.Name == "Water Supply");
            var police = context.IndustryCriterias.First(i => i.Name == "Police");
            var tvBroadcasting = context.IndustryCriterias.First(i => i.Name == "TV Broadcasting");
            var stockExchange = context.IndustryCriterias.First(i => i.Name == "Stock Exchange");
            var energy = context.IndustryCriterias.First(i => i.Name == "Energy");
            var transportation = context.IndustryCriterias.First(i => i.Name == "Transportation");

            var employeeCriteriaUpTo10 =context.EmployeeCriterias.First(i => i.Size == "Up to 10");
            var employeeCriteria11To50  =context.EmployeeCriterias.First(i => i.Size == "11 - 50");
            var employeeCriteria51To200  =context.EmployeeCriterias.First(i => i.Size == "51 - 200");
            var employeeCriteriaNotNecessary  =context.EmployeeCriterias.First(i => i.Size == "Not necessary");


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