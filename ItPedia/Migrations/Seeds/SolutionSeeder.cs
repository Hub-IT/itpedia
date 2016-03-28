using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class SolutionSeeder
    {
        public SolutionSeeder(ItPediaDbContext context)
        {
            var homeBusiness = context.IndustryCriteria.First(i => i.Name == "Home Business");
            var exportBusiness = context.IndustryCriteria.First(i => i.Name == "Export Business");
            var telecommunication = context.IndustryCriteria.First(i => i.Name == "Telecommunications");
            var banking = context.IndustryCriteria.First(i => i.Name == "Banking");
            var retail = context.IndustryCriteria.First(i => i.Name == "Retail");
            var automobile = context.IndustryCriteria.First(i => i.Name == "Automobile");
            var advertising = context.IndustryCriteria.First(i => i.Name == "Advertising");
            var insurance = context.IndustryCriteria.First(i => i.Name == "Insurance");
            var oil = context.IndustryCriteria.First(i => i.Name == "Oil");
            var pharmaceutical = context.IndustryCriteria.First(i => i.Name == "Pharmaceutical");
            var waterSupply = context.IndustryCriteria.First(i => i.Name == "Water Supply");
            var police = context.IndustryCriteria.First(i => i.Name == "Police");
            var tvBroadcasting = context.IndustryCriteria.First(i => i.Name == "TV Broadcasting");
            var stockExchange = context.IndustryCriteria.First(i => i.Name == "Stock Exchange");
            var energy = context.IndustryCriteria.First(i => i.Name == "Energy");
            var transportation = context.IndustryCriteria.First(i => i.Name == "Transportation");

            var employeeCriteriaUpTo10 = context.EmployeeCriteria.First(i => i.Size == "Up to 10");
            var employeeCriteria11To50 = context.EmployeeCriteria.First(i => i.Size == "11 - 50");
            var employeeCriteria51To200 = context.EmployeeCriteria.First(i => i.Size == "51 - 200");
            var employeeCriteriaNotNecessary = context.EmployeeCriteria.First(i => i.Size == "Not necessary");

            var customerCriteriaUpTo500 = context.CustomerCriterias.First(i => i.Size == "Up to 500");
            var customerCriteriaMore500 = context.CustomerCriterias.First(i => i.Size == "More than 500");

            var transactionCriteriaUpTo100 = context.TransactionCriteria.First(i => i.PerMonth == "Up to 100");
            var transactionCriteriaMoreThan100 = context.TransactionCriteria.First(i => i.PerMonth == "More than 100");



            context.Solutions.AddOrUpdate(
                solution => solution.Name,
                                        new Solution
                                        {
                                            Name = "Solution 1",
                                            IndustryCriterionId = homeBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 2",
                                            IndustryCriterionId = homeBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 3",
                                            IndustryCriterionId = homeBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 4",
                                            IndustryCriterionId = homeBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 5",
                                            IndustryCriterionId = exportBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 6",
                                            IndustryCriterionId = exportBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 7",
                                            IndustryCriterionId = exportBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 8",
                                            IndustryCriterionId = exportBusiness.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 9",
                                            IndustryCriterionId = telecommunication.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 10",
                                            IndustryCriterionId = telecommunication.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 11",
                                            IndustryCriterionId = telecommunication.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 12",
                                            IndustryCriterionId = telecommunication.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 13",
                                            IndustryCriterionId = banking.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 14",
                                            IndustryCriterionId = banking.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 15",
                                            IndustryCriterionId = banking.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 16",
                                            IndustryCriterionId = banking.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 17",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 18",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 19",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 20",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 21",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 22",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 23",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 24",
                                            IndustryCriterionId = retail.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 25",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 26",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 27",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 28",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaUpTo10.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 29",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 30",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 31",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 32",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 33",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 34",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 35",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 36",
                                            IndustryCriterionId = automobile.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 37",
                                            IndustryCriterionId = advertising.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 38",
                                            IndustryCriterionId = advertising.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 39",
                                            IndustryCriterionId = advertising.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 40",
                                            IndustryCriterionId = advertising.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 41",
                                            IndustryCriterionId = insurance.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 42",
                                            IndustryCriterionId = insurance.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 43",
                                            IndustryCriterionId = insurance.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 44",
                                            IndustryCriterionId = insurance.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 45",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 46",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 47",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 48",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 49",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 50",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 51",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 52",
                                            IndustryCriterionId = oil.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 53",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 54",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 55",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 56",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 57",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 58",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 59",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 60",
                                            IndustryCriterionId = pharmaceutical.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 61",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 62",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 63",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 64",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria11To50.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 65",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 66",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 67",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 68",
                                            IndustryCriterionId = waterSupply.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 69",
                                            IndustryCriterionId = police.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 70",
                                            IndustryCriterionId = police.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 71",
                                            IndustryCriterionId = police.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 72",
                                            IndustryCriterionId = police.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 73",
                                            IndustryCriterionId = tvBroadcasting.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 74",
                                            IndustryCriterionId = tvBroadcasting.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 75",
                                            IndustryCriterionId = tvBroadcasting.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 76",
                                            IndustryCriterionId = tvBroadcasting.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteria51To200.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 77",
                                            IndustryCriterionId = stockExchange.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 78",
                                            IndustryCriterionId = stockExchange.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 79",
                                            IndustryCriterionId = stockExchange.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 80",
                                            IndustryCriterionId = stockExchange.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 81",
                                            IndustryCriterionId = energy.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 82",
                                            IndustryCriterionId = energy.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 83",
                                            IndustryCriterionId = energy.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 84",
                                            IndustryCriterionId = energy.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 85",
                                            IndustryCriterionId = transportation.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 86",
                                            IndustryCriterionId = transportation.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaUpTo500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 87",
                                            IndustryCriterionId = transportation.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaUpTo100.TransactionCriterionId
                                        },
                                        new Solution
                                        {
                                            Name = "Solution 88",
                                            IndustryCriterionId = transportation.IndustryCriterionId,
                                            EmployeeCriterionId = employeeCriteriaNotNecessary.EmployeeCriterionId,
                                            CustomerCriterionId = customerCriteriaMore500.CustomerCriterionId,
                                            TransactionCriterionId = transactionCriteriaMoreThan100.TransactionCriterionId
                                        }
                                        );




            context.SaveChanges();


        }
    }
}