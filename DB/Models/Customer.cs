using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Customer
    {
        public string C_Code { get; set; }
        public string C_Name { get; set; }

        public static IQueryable<Customer> GetCustomers()
        {

            return new List<Customer> {
                new Customer {
                            C_Code = "500",
                            C_Name = "up to 500"
                        },
                new Customer {
                            C_Code = "500more",
                            C_Name = "more than 500"
                        }                
             }.AsQueryable();
        }
    }
}