using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ItPedia.Models
{
    public class IndustryCriteria
    {
        public virtual string IndustryCriteriaId { get; set; }
        public virtual List<MetaData> MetaData { get; set; }

//        public static IQueryable<IndustryCriteria> GetAll()
//        {
//            return new List<IndustryCriteria>
//            {
//                new IndustryCriteria
//                {
//                    IndustryId = "HB",
//                    Name = "Home Business"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "EB",
//                    Name = "Export Business"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "TE",
//                    Name = "Telecom"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "BA",
//                    Name = "Banking"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "RE",
//                    Name = "Retail"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "AU",
//                    Name = "Automobile"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "AD",
//                    Name = "Advertising"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "IN",
//                    Name = "Insurance"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "OI",
//                    Name = "Oil"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "PH",
//                    Name = "Pharmaceutical"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "WA",
//                    Name = "Water Supply"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "PO",
//                    Name = "Police"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "TV",
//                    Name = "TV Broadcasting"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "ST",
//                    Name = "Stock Exchange"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "EN",
//                    Name = "Energy"
//                },
//                new IndustryCriteria
//                {
//                    IndustryId = "TR",
//                    Name = "Transportation"
//                }
//
//                // ,new Country{    // verify check for ' works
//                //    EmployeeCriteriaId = "CD'",
//                //    Size = "Côte D'ivoire"
//                //}
//            }.AsQueryable();
//        }
//
//        public static SelectList GetIndustrySelectList()
//        {
//            var industries = GetAll();
//
//            return new SelectList(industries.ToArray(), "EmployeeCriteriaId", "Name");
//        }
    }
}