using System.Collections.Generic;
using System.Linq;

namespace ItPedia.Models
{
    public class EmployeeCriteria
    {
        public virtual int EmployeeCriteriaId { get; set; }
        public virtual string Size { get; set; }
       
        public virtual IndustryCriteria IndustryCriteria { get; set; }
        public virtual int IndustryCriteriaId { get; set; }

//        public static IQueryable<EmployeeCriteria> GetEmployees()
//        {
//            return new List<EmployeeCriteria>
//            {
//                //Home Business
//                new EmployeeCriteria
//                {
//                    IndustryId = "HB",
//                    EmployeeCriteriaId = 1,
//                    Size = "up to 10"
//                },
//
//                //Export Business
//                new EmployeeCriteria
//                {
//                    IndustryId = "EB",
//                    EmployeeCriteriaId = 2,
//                    Size = "11-50"
//                },
//
//                //Telecommunications
//                new EmployeeCriteria
//                {
//                    IndustryId = "TE",
//                    EmployeeCriteriaId = 3,
//                    Size = "51-200"
//                },
//
//                //Banking        
//                new EmployeeCriteria
//                {
//                    IndustryId = "BA",
//                    EmployeeCriteriaId = 4,
//                    Size = "51-200"
//                },
//
//                //Retail
//                new EmployeeCriteria
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = 5,
//                    Size = "up to 10"
//                },
//                new EmployeeCriteria
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = 6,
//                    Size = "11-50"
//                },
//
//
//                //Automobile
//                new EmployeeCriteria
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = 7,
//                    Size = "up to 10"
//                },
//                new EmployeeCriteria
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = 8,
//                    Size = "11-50"
//                },
//                new EmployeeCriteria
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = 9,
//                    Size = "51-200"
//                },
//
//                //Advertising
//                new EmployeeCriteria
//                {
//                    IndustryId = "AD",
//                    EmployeeCriteriaId = 10,
//                    Size = "11-50"
//                },
//
//                //Insurance
//                new EmployeeCriteria
//                {
//                    IndustryId = "IN",
//                    EmployeeCriteriaId = 11,
//                    Size = "51-200"
//                },
//
//                //Oil
//                new EmployeeCriteria
//                {
//                    IndustryId = "OI",
//                    EmployeeCriteriaId = 12,
//                    Size = "51-200"
//                },
//
//                //Pharmaceutical
//                new EmployeeCriteria
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = 13,
//                    Size = "11-50"
//                },
//                new EmployeeCriteria
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = 14,
//                    Size = "51-200"
//                },
//
//                //Water Supply
//                new EmployeeCriteria
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = 15,
//                    Size = "11-50"
//                },
//                new EmployeeCriteria
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = 16,
//                    Size = "51-200"
//                },
//
//
//                //Police
//                new EmployeeCriteria
//                {
//                    IndustryId = "PO",
//                    EmployeeCriteriaId = 17,
//                    Size = "Not necessary"
//                },
//
//
//                //TV Broadcasting
//                new EmployeeCriteria
//                {
//                    IndustryId = "TV",
//                    EmployeeCriteriaId = 18,
//                    Size = "51-200"
//                },
//
//
//                //Stock Exchange
//                new EmployeeCriteria
//                {
//                    IndustryId = "ST",
//                    EmployeeCriteriaId = 19,
//                    Size = "Not necessary"
//                },
//
//
//                //Energy
//                new EmployeeCriteria
//                {
//                    IndustryId = "EN",
//                    EmployeeCriteriaId = 20,
//                    Size = "Not necessary"
//                },
//
//                //Transportation
//                new EmployeeCriteria
//                {
//                    IndustryId = "TR",
//                    EmployeeCriteriaId = 21,
//                    Size = "Not necessary"
//                }
//            }.AsQueryable();
//        }
//
//        public static IQueryable<EmployeeCriteria> GetByIndustryCode(string industryCode)
//        {
//            return GetEmployees().Where(employee => industryCode == employee.IndustryId);
//        }
    }
}