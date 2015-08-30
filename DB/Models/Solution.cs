using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Solution
    {
        public string CT_Code { get; set; }
        public int EM_Code { get; set; }
        public string C_Code { get; set; }
        public string T_Code { get; set; }
        public int S_Code { get; set; }

        public static IQueryable<Solution> GetSolutions()
        {
            return new List<Solution>
            {

                        //Home Business up to 10
                        new Solution {
                            CT_Code = "HB",
                            EM_Code = 1,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 1
                        },
                        new Solution {
                            CT_Code = "HB",
                            EM_Code = 1,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "HB",
                            EM_Code = 1,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "HB",
                            EM_Code = 1,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 3
                        },

                        //Export Business 11-50
                        new Solution {
                            CT_Code = "EB",
                            EM_Code = 2,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "EB",
                            EM_Code = 2,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "EB",
                            EM_Code = 2,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "EB",
                            EM_Code = 2,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 5
                        },

                        //Telecom 51-200
                        new Solution {
                            CT_Code = "TE",
                            EM_Code = 3,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "TE",
                            EM_Code = 3,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "TE",
                            EM_Code = 3,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "TE",
                            EM_Code = 3,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 9
                        },

                        //Banking 51-200
                        new Solution {
                            CT_Code = "BA",
                            EM_Code = 4,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "BA",
                            EM_Code = 4,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "BA",
                            EM_Code = 4,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "BA",
                            EM_Code = 4,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 9
                        },

                        //Retail up to 10
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 5,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 1
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 5,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 5,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 5,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 3
                        },


                        //Retail 11-50
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 6,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 6,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 6,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "RE",
                            EM_Code = 6,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 5
                        },

                        //Automobile up to 10
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 7,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 1
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 7,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 7,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 2
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 7,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 3
                        },


                        //Automobile 11-50
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 8,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 8,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 8,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 8,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 5
                        },

                        //Automobile 51-200
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 9,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 9,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 9,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "AU",
                            EM_Code = 9,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 9
                        },

                        //Advertising 11-50

                        new Solution {
                            CT_Code = "AD",
                            EM_Code = 10,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "AD",
                            EM_Code = 10,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "AD",
                            EM_Code = 10,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "AD",
                            EM_Code = 10,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 5
                        },

                        //Insurance 51-200
                        new Solution {
                            CT_Code = "IN",
                            EM_Code = 11,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "IN",
                            EM_Code = 11,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "IN",
                            EM_Code = 11,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "IN",
                            EM_Code = 11,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 6
                        },

                        //Oil 51-200
                        new Solution {
                            CT_Code = "OI",
                            EM_Code = 12,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "OI",
                            EM_Code = 12,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "OI",
                            EM_Code = 12,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 9
                        },
                        new Solution {
                            CT_Code = "OI",
                            EM_Code = 12,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 10
                        },

                        //Pharmaceutical 11-50
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 13,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 13,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 13,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 13,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 8
                        },

                        //Pharmeceutical 51-200
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 14,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 14,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 9
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 14,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 9
                        },
                        new Solution {
                            CT_Code = "PH",
                            EM_Code = 14,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 10
                        },


                        //Water Supply 11-50
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 15,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 15,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 15,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 15,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 5
                        },

                        //Water Supply 51-200
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 16,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 16,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 16,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "WA",
                            EM_Code = 16,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 9
                        },

                        //Police Not Necessary
                        new Solution {
                            CT_Code = "PO",
                            EM_Code = 17,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 10
                        },
                        new Solution {
                            CT_Code = "PO",
                            EM_Code = 17,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 10
                        },
                        new Solution {
                            CT_Code = "PO",
                            EM_Code = 17,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 10
                        },
                        new Solution {
                            CT_Code = "PO",
                            EM_Code = 17,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 10
                        },


                        //TV Broadcasting 51-200
                        new Solution {
                            CT_Code = "TV",
                            EM_Code = 18,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "TV",
                            EM_Code = 18,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "TV",
                            EM_Code = 18,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "TV",
                            EM_Code = 18,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 7
                        },

                        //Stock Exchange Not Necessary
                        new Solution {
                            CT_Code = "ST",
                            EM_Code = 19,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 4
                        },
                        new Solution {
                            CT_Code = "ST",
                            EM_Code = 19,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 5
                        },
                        new Solution {
                            CT_Code = "ST",
                            EM_Code = 19,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "ST",
                            EM_Code = 19,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 7
                        },

                        //Energy Not necessary
                        new Solution {
                            CT_Code = "EN",
                            EM_Code = 20,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "EN",
                            EM_Code = 20,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "EN",
                            EM_Code = 20,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "EN",
                            EM_Code = 20,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 8
                        },

                        //Transportation Not Necessary
                        new Solution {
                            CT_Code = "TR",
                            EM_Code = 21,
                            C_Code = "500",
                            T_Code = "100",
                            S_Code = 6
                        },
                        new Solution {
                            CT_Code = "TR",
                            EM_Code = 21,
                            C_Code = "500",
                            T_Code = "100more",
                            S_Code = 7
                        },
                        new Solution {
                            CT_Code = "TR",
                            EM_Code = 21,
                            C_Code = "500more",
                            T_Code = "100",
                            S_Code = 8
                        },
                        new Solution {
                            CT_Code = "TR",
                            EM_Code = 21,
                            C_Code = "500more",
                            T_Code = "100more",
                            S_Code = 8
                        },
                
                
            }.AsQueryable();
        }
    }
}