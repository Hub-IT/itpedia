using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ITPedia.Models
{
    public class Customer
    {
        public string Code { get; set; }
        public string Size { get; set; }

        public static IQueryable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Code = "500",
                    Size = "up to 500"
                },
                new Customer
                {
                    Code = "500more",
                    Size = "more than 500"
                }
            }.AsQueryable();
        }

        public static SelectList GetCustomerSelectList()
        {
            var customers = GetCustomers();

            return new SelectList(customers.ToArray(), "EmployeeId", "Size");
        }
    }
}