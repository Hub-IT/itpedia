using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using ItPedia.Models.Contexts;

namespace ItPedia.Models.Initializers
{
    public class ItPediaDbInitializer : DropCreateDatabaseAlways<ItPediaDbContext>
    {
        protected override void Seed(ItPediaDbContext context)
        {
            var transactionCriteriaUpTo10 = new TransactionCriteria {PerMonth = "Up to 100"};
            var transactionCriteriaMoreThan100 = new TransactionCriteria {PerMonth = "More than 100"};
            var transactionCriterias = new List<TransactionCriteria>
            {
                transactionCriteriaUpTo10,
                transactionCriteriaMoreThan100
            };
            transactionCriterias.ForEach(transactionCriteria => context.TransactionCriterias.Add(transactionCriteria));
            context.SaveChanges();

            var customerCriterias = new List<CustomerCriteria>
            {
                new CustomerCriteria {Size = "Up to 10", TransactionCriterias = transactionCriterias},
                new CustomerCriteria {Size = "11 - 50", TransactionCriterias = transactionCriterias},
                new CustomerCriteria {Size = "50 - 200", TransactionCriterias = transactionCriterias},
                new CustomerCriteria {Size = "Unnecessary", TransactionCriterias = transactionCriterias}
            };
            customerCriterias.ForEach(customerCriteria => context.CustomerCriterias.Add(customerCriteria));
            context.SaveChanges();


            base.Seed(context);
        }
    }
}