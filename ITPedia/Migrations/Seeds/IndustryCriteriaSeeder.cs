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
            
            var homeBusiness = new IndustryCriteria {Name = "Home Business"};
            var exportBusiness = new IndustryCriteria {Name = "Export Business"};
            var telecommunication = new IndustryCriteria {Name = "Telecommunications"};
            var banking = new IndustryCriteria {Name = "Banking"};
            var retail = new IndustryCriteria {Name = "Retail"};
            var automobile = new IndustryCriteria {Name = "Automobile"};
            var advertising = new IndustryCriteria {Name = "Advertising"};
            var insurance = new IndustryCriteria {Name = "Insurance"};
            var oil = new IndustryCriteria {Name = "Oil"};
            var pharmaceutical = new IndustryCriteria {Name = "Pharmaceutical"};
            var waterSupply = new IndustryCriteria {Name = "Water Supply"};
            var police = new IndustryCriteria {Name = "Police"};
            var tvBroadcasting = new IndustryCriteria {Name = "TV Broadcasting"};
            var stockExchange = new IndustryCriteria {Name = "Stock Exchange"};
            var energy = new IndustryCriteria {Name = "Energy"};
            var transportation = new IndustryCriteria {Name = "Transportation"};

            var industryCriterias = new List<IndustryCriteria>
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


            context.IndustryCriterias.AddOrUpdate(p => p.Name, industryCriterias.ToArray());

            context.SaveChanges();
        }
    }
}