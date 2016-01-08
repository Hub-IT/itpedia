using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class CompanyType
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<CompanyType> GetCompanyTypes()
        {
            return new List<CompanyType>
            {
                new CompanyType {
                    Code = "HB",
                    Name = "Home Business"
                },
                new CompanyType {
                    Code = "EB",
                    Name = "Export Business"
                },
                new CompanyType {
                    Code = "TE",
                    Name = "Telecom"
                },
                 new CompanyType {
                    Code = "BA",
                    Name = "Banking"
                },
                new CompanyType {
                    Code = "RE",
                    Name = "Retail"
                },
                new CompanyType {
                    Code = "AU",
                    Name = "Automobile"                
                },
                new CompanyType {
                    Code = "AD",
                    Name = "Advertising"                
                },
                new CompanyType {
                    Code = "IN",
                    Name = "Insurance"                
                },
                new CompanyType {
                    Code = "OI",
                    Name = "Oil"                
                },
                new CompanyType {
                    Code = "PH",
                    Name = "Pharmaceutical"                
                },
                new CompanyType {
                    Code = "WA",
                    Name = "Water Supply"                
                },
                new CompanyType {
                    Code = "PO",
                    Name = "Police"                
                },
                new CompanyType {
                    Code = "TV",
                    Name = "TV Broadcasting"                
                },
                new CompanyType {
                    Code = "ST",
                    Name = "Stock Exchange"                
                },
                new CompanyType {
                    Code = "EN",
                    Name = "Energy"                
                },
                new CompanyType {
                    Code = "TR",
                    Name = "Transportation"                
                }

                // ,new Country{    // verify check for ' works
                //    Code = "CD'",
                //    Name = "Côte D'ivoire"
                //}
            }.AsQueryable();
        }

    }
}