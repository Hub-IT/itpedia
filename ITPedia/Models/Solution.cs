using System.Collections.Generic;
using System.Linq;

namespace ITPedia.Models
{
    public class Solution
    {
        public string IndustryCode { get; set; }
        public string EmployeeCode { get; set; }
        public string Size { get; set; }
        public string TransactionCode { get; set; }
        public string SolutionCode { get; set; }

        public static IQueryable<Solution> GetSolutions()
        {
            return new List<Solution>
            {
                //Home Business up to 10
                new Solution
                {
                    IndustryCode = "HB",
                    EmployeeCode ="1",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "1" 
                },
                new Solution
                {
                    IndustryCode = "HB",
                    EmployeeCode = "1",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode ="2" 
                },
                new Solution
                {
                    IndustryCode = "HB",
                    EmployeeCode ="1",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode ="2" 
                },
                new Solution
                {
                    IndustryCode = "HB",
                    EmployeeCode ="1",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode ="3" 
                },

                //Export Business 11-50
                new Solution
                {
                    IndustryCode = "EB",
                    EmployeeCode = "2",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode ="4" 
                },
                new Solution
                {
                    IndustryCode = "EB",
                    EmployeeCode = "2",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "EB",
                    EmployeeCode = "2",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "EB",
                    EmployeeCode = "2",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },

                //Telecom 51-200
                new Solution
                {
                    IndustryCode = "TE",
                    EmployeeCode = "3",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "TE",
                    EmployeeCode = "3",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "TE",
                    EmployeeCode = "3",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "TE",
                    EmployeeCode = "3",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "9"
                },

                //Banking 51-200
                new Solution
                {
                    IndustryCode = "BA",
                    EmployeeCode = "4",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "BA",
                    EmployeeCode = "4",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "BA",
                    EmployeeCode = "4",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "BA",
                    EmployeeCode = "4",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "9"
                },

                //Retail up to 10
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "5",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "1"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "5",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "2"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "5",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "2"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "5",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "3"
                },


                //Retail 11-50
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "6",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "6",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "6",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "RE",
                    EmployeeCode = "6",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },

                //Automobile up to 10
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "7",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "1"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "7",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "2"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "7",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "2"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "7",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "3"
                },


                //Automobile 11-50
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "8",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "8",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "8",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "8",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },

                //Automobile 51-200
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "9",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "9",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "9",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "AU",
                    EmployeeCode = "9",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "9"
                },

                //Advertising 11-50

                new Solution
                {
                    IndustryCode = "AD",
                    EmployeeCode = "10",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "AD",
                    EmployeeCode = "10",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "AD",
                    EmployeeCode = "10",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "AD",
                    EmployeeCode = "10",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },

                //Insurance 51-200
                new Solution
                {
                    IndustryCode = "IN",
                    EmployeeCode = "11",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "IN",
                    EmployeeCode = "11",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "IN",
                    EmployeeCode = "11",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "IN",
                    EmployeeCode = "11",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "6"
                },

                //Oil 51-200
                new Solution
                {
                    IndustryCode = "OI",
                    EmployeeCode = "12",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "OI",
                    EmployeeCode = "12",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "OI",
                    EmployeeCode = "12",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "9"
                },
                new Solution
                {
                    IndustryCode = "OI",
                    EmployeeCode = "12",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "10"
                },

                //Pharmaceutical 11-50
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "13",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "13",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "13",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "13",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "8"
                },

                //Pharmeceutical 51-200
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "15",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "15",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "9"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "15",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "9"
                },
                new Solution
                {
                    IndustryCode = "PH",
                    EmployeeCode = "15",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "10"
                },


                //Water Supply 11-50
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "15",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "15",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "15",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "15",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },

                //Water Supply 51-200
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "16",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "16",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "16",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "WA",
                    EmployeeCode = "16",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "9"
                },

                //Police Not Necessary
                new Solution
                {
                    IndustryCode = "PO",
                    EmployeeCode = "17",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "10"
                },
                new Solution
                {
                    IndustryCode = "PO",
                    EmployeeCode = "17",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "10"
                },
                new Solution
                {
                    IndustryCode = "PO",
                    EmployeeCode = "17",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "10"
                },
                new Solution
                {
                    IndustryCode = "PO",
                    EmployeeCode = "17",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "10"
                },


                //TV Broadcasting 51-200
                new Solution
                {
                    IndustryCode = "TV",
                    EmployeeCode = "18",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "TV",
                    EmployeeCode = "18",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "TV",
                    EmployeeCode = "18",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "TV",
                    EmployeeCode = "18",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },

                //Stock Exchange Not Necessary
                new Solution
                {
                    IndustryCode = "ST",
                    EmployeeCode = "19",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "4"
                },
                new Solution
                {
                    IndustryCode = "ST",
                    EmployeeCode = "19",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "5"
                },
                new Solution
                {
                    IndustryCode = "ST",
                    EmployeeCode = "19",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "ST",
                    EmployeeCode = "19",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },

                //Energy Not necessary
                new Solution
                {
                    IndustryCode = "EN",
                    EmployeeCode = "20",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "EN",
                    EmployeeCode = "20",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "EN",
                    EmployeeCode = "20",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "EN",
                    EmployeeCode = "20",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "8"
                },

                //Transportation Not Necessary
                new Solution
                {
                    IndustryCode = "TR",
                    EmployeeCode = "21",
                    Size = "500",
                    TransactionCode = "100",
                    SolutionCode = "6"
                },
                new Solution
                {
                    IndustryCode = "TR",
                    EmployeeCode = "21",
                    Size = "500",
                    TransactionCode = "100more",
                    SolutionCode = "7"
                },
                new Solution
                {
                    IndustryCode = "TR",
                    EmployeeCode = "21",
                    Size = "500more",
                    TransactionCode = "100",
                    SolutionCode = "8"
                },
                new Solution
                {
                    IndustryCode = "TR",
                    EmployeeCode = "21",
                    Size = "500more",
                    TransactionCode = "100more",
                    SolutionCode = "8"
                }
            }.AsQueryable();
        }

        public static string GetSolutionCode(string employeeCode, string industryCode, string transactionCode)
        {
            return GetSolutions().First(
                solution =>
                    employeeCode == solution.EmployeeCode &&
                    industryCode == solution.IndustryCode &&
                    transactionCode == solution.TransactionCode
                ).SolutionCode;
        }
    }
}