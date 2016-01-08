using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Employee
    {
        public string CT_Code { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Employee> GetEmployees()
        {

            return new List<Employee> {

                //Home Business
                new Employee {
                            CT_Code = "HB",
                            Code = 1,
                            Name = "up to 10"
                        },

                //Export Business
                new Employee {
                            CT_Code = "EB",
                            Code = 2,
                            Name = "11-50"
                        },

                //Telecommunications
                new Employee {
                            CT_Code = "TE",
                            Code = 3,
                            Name = "51-200"
                        },
                
                //Banking        
                new Employee {
                            CT_Code = "BA",
                            Code = 4,
                            Name = "51-200"
                        },

                //Retail
                new Employee {
                            CT_Code = "RE",
                            Code = 5,
                            Name = "up to 10"
                        },
                new Employee {
                            CT_Code = "RE",
                            Code = 6,
                            Name = "11-50"
                        },


                //Automobile
                new Employee {
                            CT_Code = "AU",
                            Code = 7,
                            Name = "up to 10"
                        },
                new Employee {
                            CT_Code = "AU",
                            Code = 8,
                            Name = "11-50"
                        },
                 new Employee {
                            CT_Code = "AU",
                            Code = 9,
                            Name = "51-200"
                        },

                //Advertising
                new Employee {
                            CT_Code = "AD",
                            Code = 10,
                            Name = "11-50"
                        },

                //Insurance
                new Employee {
                            CT_Code = "IN",
                            Code = 11,
                            Name = "51-200"
                        },

                //Oil
                new Employee {
                            CT_Code = "OI",
                            Code = 12,
                            Name = "51-200"
                },

                //Pharmaceutical
                new Employee {
                            CT_Code = "PH",
                            Code = 13,
                            Name = "11-50"
                        },
                new Employee {
                     CT_Code = "PH",
                     Code = 14,
                     Name = "51-200"
                        },

                //Water Supply
                new Employee {
                     CT_Code ="WA",
                     Code = 15,
                     Name = "11-50"
                },

                new Employee {
                    CT_Code = "WA",
                    Code = 16,
                    Name = "51-200"
                },


                //Police
                new Employee {
                    CT_Code = "PO",
                    Code = 17,
                    Name = "Not necessary"
                },


                //TV Broadcasting
                new Employee {
                    CT_Code = "TV",
                    Code = 18,
                    Name = "51-200"
                },


                //Stock Exchange
                new Employee {
                    CT_Code = "ST",
                    Code = 19,
                    Name = "Not necessary"
                },


                //Energy
                new Employee {
                    CT_Code = "EN",
                    Code = 20,
                    Name = "Not necessary"
                },

                //Transportation
                new Employee {
                    CT_Code = "TR",
                    Code = 21,
                    Name = "Not necessary"
                },





             }.AsQueryable();
        }
    }
}