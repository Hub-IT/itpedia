using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Customer> GetCustomers()
        {

            return new List<Customer> {
                new Customer {
                            Code = "500",
                            Name = "up to 500"
                        },
                new Customer {
                            Code = "500more",
                            Name = "more than 500"
                        }                
             }.AsQueryable();
        }
    }
}