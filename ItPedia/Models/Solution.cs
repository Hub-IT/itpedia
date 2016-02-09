using System.Collections.Generic;
using System.Linq;

namespace ItPedia.Models
{
    public class Solution
    {
        public virtual string SolutionId { get; set; }

        public virtual string IndustryId { get; set; }
        public virtual IndustryCriteria IndustryCriteria { get; set; }

        public virtual string EmployeeId { get; set; }
        public virtual EmployeeCriteria EmployeeCriteria { get; set; }

        public virtual string TransactionId { get; set; }
        public virtual TransactionCriteria TransactionCriteria { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual SolutionCategory SolutionCategory { get; set; }


//        public static IQueryable<Solution> GetSolutions()
//        {
//            return new List<Solution>
//            {
//                //Home Business up to 10
//                new Solution
//                {
//                    IndustryId = "HB",
//                    EmployeeCriteriaId ="1",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "1" 
//                },
//                new Solution
//                {
//                    IndustryId = "HB",
//                    EmployeeCriteriaId = "1",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId ="2" 
//                },
//                new Solution
//                {
//                    IndustryId = "HB",
//                    EmployeeCriteriaId ="1",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId ="2" 
//                },
//                new Solution
//                {
//                    IndustryId = "HB",
//                    EmployeeCriteriaId ="1",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId ="3" 
//                },
//
//                //Export Business 11-50
//                new Solution
//                {
//                    IndustryId = "EB",
//                    EmployeeCriteriaId = "2",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId ="4" 
//                },
//                new Solution
//                {
//                    IndustryId = "EB",
//                    EmployeeCriteriaId = "2",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "EB",
//                    EmployeeCriteriaId = "2",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "EB",
//                    EmployeeCriteriaId = "2",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//
//                //Telecom 51-200
//                new Solution
//                {
//                    IndustryId = "TE",
//                    EmployeeCriteriaId = "3",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "TE",
//                    EmployeeCriteriaId = "3",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "TE",
//                    EmployeeCriteriaId = "3",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "TE",
//                    EmployeeCriteriaId = "3",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "9"
//                },
//
//                //Banking 51-200
//                new Solution
//                {
//                    IndustryId = "BA",
//                    EmployeeCriteriaId = "4",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "BA",
//                    EmployeeCriteriaId = "4",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "BA",
//                    EmployeeCriteriaId = "4",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "BA",
//                    EmployeeCriteriaId = "4",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "9"
//                },
//
//                //Retail up to 10
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "5",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "1"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "5",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "2"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "5",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "2"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "5",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "3"
//                },
//
//
//                //Retail 11-50
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "6",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "6",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "6",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "RE",
//                    EmployeeCriteriaId = "6",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//
//                //Automobile up to 10
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "7",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "1"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "7",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "2"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "7",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "2"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "7",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "3"
//                },
//
//
//                //Automobile 11-50
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "8",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "8",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "8",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "8",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//
//                //Automobile 51-200
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "9",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "9",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "9",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "AU",
//                    EmployeeCriteriaId = "9",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "9"
//                },
//
//                //Advertising 11-50
//
//                new Solution
//                {
//                    IndustryId = "AD",
//                    EmployeeCriteriaId = "10",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "AD",
//                    EmployeeCriteriaId = "10",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "AD",
//                    EmployeeCriteriaId = "10",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "AD",
//                    EmployeeCriteriaId = "10",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//
//                //Insurance 51-200
//                new Solution
//                {
//                    IndustryId = "IN",
//                    EmployeeCriteriaId = "11",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "IN",
//                    EmployeeCriteriaId = "11",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "IN",
//                    EmployeeCriteriaId = "11",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "IN",
//                    EmployeeCriteriaId = "11",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "6"
//                },
//
//                //Oil 51-200
//                new Solution
//                {
//                    IndustryId = "OI",
//                    EmployeeCriteriaId = "12",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "OI",
//                    EmployeeCriteriaId = "12",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "OI",
//                    EmployeeCriteriaId = "12",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "9"
//                },
//                new Solution
//                {
//                    IndustryId = "OI",
//                    EmployeeCriteriaId = "12",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "10"
//                },
//
//                //Pharmaceutical 11-50
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "13",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "13",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "13",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "13",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "8"
//                },
//
//                //Pharmeceutical 51-200
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "9"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "9"
//                },
//                new Solution
//                {
//                    IndustryId = "PH",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "10"
//                },
//
//
//                //Water Supply 11-50
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "15",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//
//                //Water Supply 51-200
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "16",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "16",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "16",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "WA",
//                    EmployeeCriteriaId = "16",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "9"
//                },
//
//                //Police Not Necessary
//                new Solution
//                {
//                    IndustryId = "PO",
//                    EmployeeCriteriaId = "17",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "10"
//                },
//                new Solution
//                {
//                    IndustryId = "PO",
//                    EmployeeCriteriaId = "17",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "10"
//                },
//                new Solution
//                {
//                    IndustryId = "PO",
//                    EmployeeCriteriaId = "17",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "10"
//                },
//                new Solution
//                {
//                    IndustryId = "PO",
//                    EmployeeCriteriaId = "17",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "10"
//                },
//
//
//                //TV Broadcasting 51-200
//                new Solution
//                {
//                    IndustryId = "TV",
//                    EmployeeCriteriaId = "18",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "TV",
//                    EmployeeCriteriaId = "18",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "TV",
//                    EmployeeCriteriaId = "18",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "TV",
//                    EmployeeCriteriaId = "18",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//
//                //Stock Exchange Not Necessary
//                new Solution
//                {
//                    IndustryId = "ST",
//                    EmployeeCriteriaId = "19",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "4"
//                },
//                new Solution
//                {
//                    IndustryId = "ST",
//                    EmployeeCriteriaId = "19",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "5"
//                },
//                new Solution
//                {
//                    IndustryId = "ST",
//                    EmployeeCriteriaId = "19",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "ST",
//                    EmployeeCriteriaId = "19",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//
//                //Energy Not necessary
//                new Solution
//                {
//                    IndustryId = "EN",
//                    EmployeeCriteriaId = "20",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "EN",
//                    EmployeeCriteriaId = "20",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "EN",
//                    EmployeeCriteriaId = "20",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "EN",
//                    EmployeeCriteriaId = "20",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "8"
//                },
//
//                //Transportation Not Necessary
//                new Solution
//                {
//                    IndustryId = "TR",
//                    EmployeeCriteriaId = "21",
//                    PerMonth = "500",
//                    TransactionId = "100",
//                    SolutionId = "6"
//                },
//                new Solution
//                {
//                    IndustryId = "TR",
//                    EmployeeCriteriaId = "21",
//                    PerMonth = "500",
//                    TransactionId = "100more",
//                    SolutionId = "7"
//                },
//                new Solution
//                {
//                    IndustryId = "TR",
//                    EmployeeCriteriaId = "21",
//                    PerMonth = "500more",
//                    TransactionId = "100",
//                    SolutionId = "8"
//                },
//                new Solution
//                {
//                    IndustryId = "TR",
//                    EmployeeCriteriaId = "21",
//                    PerMonth = "500more",
//                    TransactionId = "100more",
//                    SolutionId = "8"
//                }
//            }.AsQueryable();
//        }
//
//        public static string GetSolutionCode(string employeeCode, string industryCode, string transactionCode)
//        {
//            return GetSolutions().First(
//                solution =>
//                    employeeCode == solution.EmployeeCriteriaId &&
//                    industryCode == solution.IndustryId &&
//                    transactionCode == solution.TransactionId
//                ).SolutionId;
//        }
    }
}