using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Employee
    {
        public string CT_Code { get; set; }
        public int EM_Code { get; set; }
        public string EM_Name { get; set; }

        public static IQueryable<Employee> GetEmployees()
        {

            return new List<Employee> {

                //Home Business
                new Employee {
                            CT_Code = "HB",
                            EM_Code = 1,
                            EM_Name = "up to 10"
                        },

                //Export Business
                new Employee {
                            CT_Code = "EB",
                            EM_Code = 2,
                            EM_Name = "11-50"
                        },

                //Telecommunications
                new Employee {
                            CT_Code = "TE",
                            EM_Code = 3,
                            EM_Name = "51-200"
                        },
                
                //Banking        
                new Employee {
                            CT_Code = "BA",
                            EM_Code = 4,
                            EM_Name = "51-200"
                        },

                //Retail
                new Employee {
                            CT_Code = "RE",
                            EM_Code = 5,
                            EM_Name = "up to 10"
                        },
                new Employee {
                            CT_Code = "RE",
                            EM_Code = 6,
                            EM_Name = "11-50"
                        },


                //Automobile
                new Employee {
                            CT_Code = "AU",
                            EM_Code = 7,
                            EM_Name = "up to 10"
                        },
                new Employee {
                            CT_Code = "AU",
                            EM_Code = 8,
                            EM_Name = "11-50"
                        },
                 new Employee {
                            CT_Code = "AU",
                            EM_Code = 9,
                            EM_Name = "51-200"
                        },

                //Advertising
                new Employee {
                            CT_Code = "AD",
                            EM_Code = 10,
                            EM_Name = "11-50"
                        },

                //Insurance
                new Employee {
                            CT_Code = "IN",
                            EM_Code = 11,
                            EM_Name = "51-200"
                        },

                //Oil
                new Employee {
                            CT_Code = "OI",
                            EM_Code = 12,
                            EM_Name = "51-200"
                },

                //Pharmaceutical
                new Employee {
                            CT_Code = "PH",
                            EM_Code = 13,
                            EM_Name = "11-50"
                        },
                new Employee {
                     CT_Code = "PH",
                     EM_Code = 14,
                     EM_Name = "51-200"
                        },

                //Water Supply
                new Employee {
                     CT_Code ="WA",
                     EM_Code = 15,
                     EM_Name = "11-50"
                },

                new Employee {
                    CT_Code = "WA",
                    EM_Code = 16,
                    EM_Name = "51-200"
                },


                //Police
                new Employee {
                    CT_Code = "PO",
                    EM_Code = 17,
                    EM_Name = "Not necessary"
                },


                //TV Broadcasting
                new Employee {
                    CT_Code = "TV",
                    EM_Code = 18,
                    EM_Name = "51-200"
                },


                //Stock Exchange
                new Employee {
                    CT_Code = "ST",
                    EM_Code = 19,
                    EM_Name = "Not necessary"
                },


                //Energy
                new Employee {
                    CT_Code = "EN",
                    EM_Code = 20,
                    EM_Name = "Not necessary"
                },

                //Transportation
                new Employee {
                    CT_Code = "TR",
                    EM_Code = 21,
                    EM_Name = "Not necessary"
                },





             }.AsQueryable();
        }
    }
}