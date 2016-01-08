using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Solution
    {
        public string CompanyCode { get; set; }
        public int EmployeeCode { get; set; }
        public string C_Code { get; set; }
        public string TransactionCode { get; set; }
        public int SolutionCode { get; set; }

        public static IQueryable<Solution> GetSolutions()
        {
            return new List<Solution>
            {

                        //Home Business up to 10
                        new Solution {
                            CompanyCode = "HB",
                            EmployeeCode = 1,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 1
                        },
                        new Solution {
                            CompanyCode = "HB",
                            EmployeeCode = 1,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "HB",
                            EmployeeCode = 1,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "HB",
                            EmployeeCode = 1,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 3
                        },

                        //Export Business 11-50
                        new Solution {
                            CompanyCode = "EB",
                            EmployeeCode = 2,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "EB",
                            EmployeeCode = 2,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "EB",
                            EmployeeCode = 2,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "EB",
                            EmployeeCode = 2,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },

                        //Telecom 51-200
                        new Solution {
                            CompanyCode = "TE",
                            EmployeeCode = 3,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "TE",
                            EmployeeCode = 3,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "TE",
                            EmployeeCode = 3,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "TE",
                            EmployeeCode = 3,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 9
                        },

                        //Banking 51-200
                        new Solution {
                            CompanyCode = "BA",
                            EmployeeCode = 4,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "BA",
                            EmployeeCode = 4,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "BA",
                            EmployeeCode = 4,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "BA",
                            EmployeeCode = 4,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 9
                        },

                        //Retail up to 10
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 5,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 1
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 5,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 5,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 5,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 3
                        },


                        //Retail 11-50
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 6,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 6,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 6,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "RE",
                            EmployeeCode = 6,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },

                        //Automobile up to 10
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 7,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 1
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 7,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 7,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 2
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 7,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 3
                        },


                        //Automobile 11-50
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 8,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 8,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 8,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 8,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },

                        //Automobile 51-200
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 9,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 9,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 9,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "AU",
                            EmployeeCode = 9,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 9
                        },

                        //Advertising 11-50

                        new Solution {
                            CompanyCode = "AD",
                            EmployeeCode = 10,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "AD",
                            EmployeeCode = 10,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "AD",
                            EmployeeCode = 10,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "AD",
                            EmployeeCode = 10,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },

                        //Insurance 51-200
                        new Solution {
                            CompanyCode = "IN",
                            EmployeeCode = 11,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "IN",
                            EmployeeCode = 11,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "IN",
                            EmployeeCode = 11,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "IN",
                            EmployeeCode = 11,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 6
                        },

                        //Oil 51-200
                        new Solution {
                            CompanyCode = "OI",
                            EmployeeCode = 12,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "OI",
                            EmployeeCode = 12,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "OI",
                            EmployeeCode = 12,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 9
                        },
                        new Solution {
                            CompanyCode = "OI",
                            EmployeeCode = 12,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 10
                        },

                        //Pharmaceutical 11-50
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 13,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 13,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 13,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 13,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 8
                        },

                        //Pharmeceutical 51-200
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 14,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 14,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 9
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 14,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 9
                        },
                        new Solution {
                            CompanyCode = "PH",
                            EmployeeCode = 14,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 10
                        },


                        //Water Supply 11-50
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 15,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 15,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 15,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 15,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },

                        //Water Supply 51-200
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 16,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 16,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 16,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "WA",
                            EmployeeCode = 16,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 9
                        },

                        //Police Not Necessary
                        new Solution {
                            CompanyCode = "PO",
                            EmployeeCode = 17,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 10
                        },
                        new Solution {
                            CompanyCode = "PO",
                            EmployeeCode = 17,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 10
                        },
                        new Solution {
                            CompanyCode = "PO",
                            EmployeeCode = 17,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 10
                        },
                        new Solution {
                            CompanyCode = "PO",
                            EmployeeCode = 17,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 10
                        },


                        //TV Broadcasting 51-200
                        new Solution {
                            CompanyCode = "TV",
                            EmployeeCode = 18,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "TV",
                            EmployeeCode = 18,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "TV",
                            EmployeeCode = 18,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "TV",
                            EmployeeCode = 18,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },

                        //Stock Exchange Not Necessary
                        new Solution {
                            CompanyCode = "ST",
                            EmployeeCode = 19,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 4
                        },
                        new Solution {
                            CompanyCode = "ST",
                            EmployeeCode = 19,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 5
                        },
                        new Solution {
                            CompanyCode = "ST",
                            EmployeeCode = 19,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "ST",
                            EmployeeCode = 19,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },

                        //Energy Not necessary
                        new Solution {
                            CompanyCode = "EN",
                            EmployeeCode = 20,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "EN",
                            EmployeeCode = 20,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "EN",
                            EmployeeCode = 20,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "EN",
                            EmployeeCode = 20,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 8
                        },

                        //Transportation Not Necessary
                        new Solution {
                            CompanyCode = "TR",
                            EmployeeCode = 21,
                            C_Code = "500",
                            TransactionCode = "100",
                            SolutionCode = 6
                        },
                        new Solution {
                            CompanyCode = "TR",
                            EmployeeCode = 21,
                            C_Code = "500",
                            TransactionCode = "100more",
                            SolutionCode = 7
                        },
                        new Solution {
                            CompanyCode = "TR",
                            EmployeeCode = 21,
                            C_Code = "500more",
                            TransactionCode = "100",
                            SolutionCode = 8
                        },
                        new Solution {
                            CompanyCode = "TR",
                            EmployeeCode = 21,
                            C_Code = "500more",
                            TransactionCode = "100more",
                            SolutionCode = 8
                        },
                
                
            }.AsQueryable();
        }
    }
}