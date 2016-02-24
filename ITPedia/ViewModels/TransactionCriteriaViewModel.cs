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

        public TransactionCriteria TransactionCriteria { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }
        public IEnumerable<SelectListItem> AllEmployeeCriterias { get; set; }
        public IEnumerable<SelectListItem> AllCustomerCriterias { get; set; }

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedIndustryCriterias ??
                       TransactionCriteria.IndustryCriterias.Select(m => m.IndustryCriteriaId).ToList();
            }
            set { _selectedIndustryCriterias = value; }
        }

        public List<int> SelectedEmployeeCriterias
        {
            get
            {
                return _selectedEmployeeCriterias ??
                       TransactionCriteria.EmployeeCriterias.Select(m => m.EmployeeCriteriaId).ToList();
            }
            set { _selectedEmployeeCriterias = value; }
        }

        public List<int> SelectedCustomerCriterias
        {
            get
            {
                return _selectedCustomerCriterias ??
                       TransactionCriteria.CustomerCriterias.Select(m => m.CustomerCriteriaId).ToList();
            }
            set { _selectedCustomerCriterias = value; }
        }
    }
}