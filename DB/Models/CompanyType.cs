using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class CompanyType
    {
        public string CT_Code { get; set; }
        public string CT_Name { get; set; }

        public static IQueryable<CompanyType> GetCompanyTypes()
        {
            return new List<CompanyType>
            {
                new CompanyType {
                    CT_Code = "HB",
                    CT_Name = "Home Business"
                },
                new CompanyType {
                    CT_Code = "EB",
                    CT_Name = "Export Business"
                },
                new CompanyType {
                    CT_Code = "TE",
                    CT_Name = "Telecom"
                },
                 new CompanyType {
                    CT_Code = "BA",
                    CT_Name = "Banking"
                },
                new CompanyType {
                    CT_Code = "RE",
                    CT_Name = "Retail"
                },
                new CompanyType {
                    CT_Code = "AU",
                    CT_Name = "Automobile"                
                },
                new CompanyType {
                    CT_Code = "AD",
                    CT_Name = "Advertising"                
                },
                new CompanyType {
                    CT_Code = "IN",
                    CT_Name = "Insurance"                
                },
                new CompanyType {
                    CT_Code = "OI",
                    CT_Name = "Oil"                
                },
                new CompanyType {
                    CT_Code = "PH",
                    CT_Name = "Pharmaceutical"                
                },
                new CompanyType {
                    CT_Code = "WA",
                    CT_Name = "Water Supply"                
                },
                new CompanyType {
                    CT_Code = "PO",
                    CT_Name = "Police"                
                },
                new CompanyType {
                    CT_Code = "TV",
                    CT_Name = "TV Broadcasting"                
                },
                new CompanyType {
                    CT_Code = "ST",
                    CT_Name = "Stock Exchange"                
                },
                new CompanyType {
                    CT_Code = "EN",
                    CT_Name = "Energy"                
                },
                new CompanyType {
                    CT_Code = "TR",
                    CT_Name = "Transportation"                
                }

                // ,new Country{    // verify check for ' works
                //    Code = "CD'",
                //    Name = "Côte D'ivoire"
                //}
            }.AsQueryable();
        }

    }
}