using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class IndustryCriteriaSeeder
    {
        public IndustryCriteriaSeeder(ItPediaDbContext context)
        {
            var homeBusiness = new IndustryCriterion {Name = "Home Business"};
            var exportBusiness = new IndustryCriterion {Name = "Export Business"};
            var telecommunication = new IndustryCriterion {Name = "Telecommunications"};
            var banking = new IndustryCriterion {Name = "Banking"};
            var retail = new IndustryCriterion {Name = "Retail"};
            var automobile = new IndustryCriterion {Name = "Automobile"};
            var advertising = new IndustryCriterion {Name = "Advertising"};
            var insurance = new IndustryCriterion {Name = "Insurance"};
            var oil = new IndustryCriterion {Name = "Oil"};
            var pharmaceutical = new IndustryCriterion {Name = "Pharmaceutical"};
            var waterSupply = new IndustryCriterion {Name = "Water Supply"};
            var police = new IndustryCriterion {Name = "Police"};
            var tvBroadcasting = new IndustryCriterion {Name = "TV Broadcasting"};
            var stockExchange = new IndustryCriterion {Name = "Stock Exchange"};
            var energy = new IndustryCriterion {Name = "Energy"};
            var transportation = new IndustryCriterion {Name = "Transportation"};

            var industryCriterias = new List<IndustryCriterion>
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
            };


            context.IndustryCriteria.AddOrUpdate(p => p.Name, industryCriterias.ToArray());

            context.SaveChanges();
        }
    }
}