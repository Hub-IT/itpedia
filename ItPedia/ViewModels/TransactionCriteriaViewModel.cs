using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class TransactionCriteriaViewModel
    {
        private List<int> _selectedCustomerCriterias;
        private List<int> _selectedEmployeeCriterias;
        private List<int> _selectedIndustryCriterias;

        public TransactionCriterion TransactionCriterion { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }
        public IEnumerable<SelectListItem> AllEmployeeCriterias { get; set; }
        public IEnumerable<SelectListItem> AllCustomerCriterias { get; set; }

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedIndustryCriterias ??
                       TransactionCriterion.IndustryCriteria.Select(m => m.IndustryCriterionId).ToList();
            }
            set { _selectedIndustryCriterias = value; }
        }

        public List<int> SelectedEmployeeCriterias
        {
            get
            {
                return _selectedEmployeeCriterias ??
                       TransactionCriterion.EmployeeCriteria.Select(m => m.EmployeeCriterionId).ToList();
            }
            set { _selectedEmployeeCriterias = value; }
        }

        public List<int> SelectedCustomerCriterias
        {
            get
            {
                return _selectedCustomerCriterias ??
                       TransactionCriterion.CustomerCriteria.Select(m => m.CustomerCriterionId).ToList();
            }
            set { _selectedCustomerCriterias = value; }
        }
    }
}