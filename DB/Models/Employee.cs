using System.Collections.Generic;
using System.Linq;

namespace TechConfigApp.Models
{
    public class Employee
    {
        public string IndustryCode { get; set; }
        public int Code { get; set; }
        public string Size { get; set; }

        public static IQueryable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                //Home Business
                new Employee
                {
                    IndustryCode = "HB",
                    Code = 1,
                    Size = "up to 10"
                },

                //Export Business
                new Employee
                {
                    IndustryCode = "EB",
                    Code = 2,
                    Size = "11-50"
                },

                //Telecommunications
                new Employee
                {
                    IndustryCode = "TE",
                    Code = 3,
                    Size = "51-200"
                },

                //Banking        
                new Employee
                {
                    IndustryCode = "BA",
                    Code = 4,
                    Size = "51-200"
                },

                //Retail
                new Employee
                {
                    IndustryCode = "RE",
                    Code = 5,
                    Size = "up to 10"
                },
                new Employee
                {
                    IndustryCode = "RE",
                    Code = 6,
                    Size = "11-50"
                },


                //Automobile
                new Employee
                {
                    IndustryCode = "AU",
                    Code = 7,
                    Size = "up to 10"
                },
                new Employee
                {
                    IndustryCode = "AU",
                    Code = 8,
                    Size = "11-50"
                },
                new Employee
                {
                    IndustryCode = "AU",
                    Code = 9,
                    Size = "51-200"
                },

                //Advertising
                new Employee
                {
                    IndustryCode = "AD",
                    Code = 10,
                    Size = "11-50"
                },

                //Insurance
                new Employee
                {
                    IndustryCode = "IN",
                    Code = 11,
                    Size = "51-200"
                },

                //Oil
                new Employee
                {
                    IndustryCode = "OI",
                    Code = 12,
                    Size = "51-200"
                },

                //Pharmaceutical
                new Employee
                {
                    IndustryCode = "PH",
                    Code = 13,
                    Size = "11-50"
                },
                new Employee
                {
                    IndustryCode = "PH",
                    Code = 14,
                    Size = "51-200"
                },

                //Water Supply
                new Employee
                {
                    IndustryCode = "WA",
                    Code = 15,
                    Size = "11-50"
                },
                new Employee
                {
                    IndustryCode = "WA",
                    Code = 16,
                    Size = "51-200"
                },


                //Police
                new Employee
                {
                    IndustryCode = "PO",
                    Code = 17,
                    Size = "Not necessary"
                },


                //TV Broadcasting
                new Employee
                {
                    IndustryCode = "TV",
                    Code = 18,
                    Size = "51-200"
                },


                //Stock Exchange
                new Employee
                {
                    IndustryCode = "ST",
                    Code = 19,
                    Size = "Not necessary"
                },


                //Energy
                new Employee
                {
                    IndustryCode = "EN",
                    Code = 20,
                    Size = "Not necessary"
                },

                //Transportation
                new Employee
                {
                    IndustryCode = "TR",
                    Code = 21,
                    Size = "Not necessary"
                }
            }.AsQueryable();
        }

        public static IQueryable<Employee> GetByIndustryCode(string industryCode)
        {
            return GetEmployees().Where(employee => industryCode == employee.IndustryCode);
        }
    }
}