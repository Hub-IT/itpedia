using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TechConfigApp.Models
{
    public class Industry
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Industry> GetAll()
        {
            return new List<Industry>
            {
                new Industry
                {
                    Code = "HB",
                    Name = "Home Business"
                },
                new Industry
                {
                    Code = "EB",
                    Name = "Export Business"
                },
                new Industry
                {
                    Code = "TE",
                    Name = "Telecom"
                },
                new Industry
                {
                    Code = "BA",
                    Name = "Banking"
                },
                new Industry
                {
                    Code = "RE",
                    Name = "Retail"
                },
                new Industry
                {
                    Code = "AU",
                    Name = "Automobile"
                },
                new Industry
                {
                    Code = "AD",
                    Name = "Advertising"
                },
                new Industry
                {
                    Code = "IN",
                    Name = "Insurance"
                },
                new Industry
                {
                    Code = "OI",
                    Name = "Oil"
                },
                new Industry
                {
                    Code = "PH",
                    Name = "Pharmaceutical"
                },
                new Industry
                {
                    Code = "WA",
                    Name = "Water Supply"
                },
                new Industry
                {
                    Code = "PO",
                    Name = "Police"
                },
                new Industry
                {
                    Code = "TV",
                    Name = "TV Broadcasting"
                },
                new Industry
                {
                    Code = "ST",
                    Name = "Stock Exchange"
                },
                new Industry
                {
                    Code = "EN",
                    Name = "Energy"
                },
                new Industry
                {
                    Code = "TR",
                    Name = "Transportation"
                }

                // ,new Country{    // verify check for ' works
                //    Code = "CD'",
                //    Size = "Côte D'ivoire"
                //}
            }.AsQueryable();
        }

        public static SelectList GetIndustrySelectList()
        {
            var industries = GetAll();

            return new SelectList(industries.ToArray(), "Code", "Name");
        }
    }
}