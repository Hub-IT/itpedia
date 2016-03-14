using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class SolutionSeeder
    {
        public SolutionSeeder(ItPediaDbContext context)
        {
//            context.Solutions.AddOrUpdate(solution => solution.Name,
//                new Solution
//                {
//                    Name = "Solution 1",
//                    IndustryCriteriaId = homeBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 2",
//                    IndustryCriteriaId = homeBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 3",
//                    IndustryCriteriaId = homeBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 4",
//                    IndustryCriteriaId = homeBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 5",
//                    IndustryCriteriaId = exportBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 6",
//                    IndustryCriteriaId = exportBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 7",
//                    IndustryCriteriaId = exportBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 8",
//                    IndustryCriteriaId = exportBusiness.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 9",
//                    IndustryCriteriaId = telecommunication.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 10",
//                    IndustryCriteriaId = telecommunication.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 11",
//                    IndustryCriteriaId = telecommunication.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 12",
//                    IndustryCriteriaId = telecommunication.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 13",
//                    IndustryCriteriaId = banking.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 14",
//                    IndustryCriteriaId = banking.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 15",
//                    IndustryCriteriaId = banking.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 16",
//                    IndustryCriteriaId = banking.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 17",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 18",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 19",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 20",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 21",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 22",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 23",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 24",
//                    IndustryCriteriaId = retail.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 25",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 26",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 27",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 28",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaUpTo10.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 29",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 30",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 31",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 32",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 33",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 34",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 35",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 36",
//                    IndustryCriteriaId = automobile.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 37",
//                    IndustryCriteriaId = advertising.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 38",
//                    IndustryCriteriaId = advertising.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 39",
//                    IndustryCriteriaId = advertising.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 40",
//                    IndustryCriteriaId = advertising.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 41",
//                    IndustryCriteriaId = insurance.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 42",
//                    IndustryCriteriaId = insurance.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 43",
//                    IndustryCriteriaId = insurance.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 44",
//                    IndustryCriteriaId = insurance.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 45",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 46",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 47",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 48",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 49",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 50",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 51",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 52",
//                    IndustryCriteriaId = oil.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 53",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 54",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 55",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 56",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 57",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 58",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 59",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 60",
//                    IndustryCriteriaId = pharmaceutical.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 61",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 62",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 63",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 64",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria11To50.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 65",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 66",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 67",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 68",
//                    IndustryCriteriaId = waterSupply.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 69",
//                    IndustryCriteriaId = police.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 70",
//                    IndustryCriteriaId = police.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 71",
//                    IndustryCriteriaId = police.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 72",
//                    IndustryCriteriaId = police.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 73",
//                    IndustryCriteriaId = tvBroadcasting.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 74",
//                    IndustryCriteriaId = tvBroadcasting.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 75",
//                    IndustryCriteriaId = tvBroadcasting.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 76",
//                    IndustryCriteriaId = tvBroadcasting.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteria51To200.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 77",
//                    IndustryCriteriaId = stockExchange.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 78",
//                    IndustryCriteriaId = stockExchange.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 79",
//                    IndustryCriteriaId = stockExchange.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 80",
//                    IndustryCriteriaId = stockExchange.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 81",
//                    IndustryCriteriaId = energy.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 82",
//                    IndustryCriteriaId = energy.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 83",
//                    IndustryCriteriaId = energy.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 84",
//                    IndustryCriteriaId = energy.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 85",
//                    IndustryCriteriaId = transportation.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 86",
//                    IndustryCriteriaId = transportation.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaUpTo500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 87",
//                    IndustryCriteriaId = transportation.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaUpTo100.TransactionCriteriaId
//                },
//                new Solution
//                {
//                    Name = "Solution 88",
//                    IndustryCriteriaId = transportation.IndustryCriteriaId,
//                    EmployeeCriteriaId = employeeCriteriaNotNecessary.EmployeeCriteriaId,
//                    CustomerCriteriaId = customerCriteriaMore500.CustomerCriteriaId,
//                    TransactionCriteriaId = transactionCriteriaMoreThan100.TransactionCriteriaId
//                }
//                );
//
//            context.SaveChanges();
        }
    }
}