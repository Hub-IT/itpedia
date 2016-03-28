using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class CustomerCriteriasViewModel
    {
        public CustomerCriterion CustomerCriterion { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }
        public IEnumerable<SelectListItem> AllEmployeeCriterias { get; set; }

        private List<int> _selectedIndustryCriterias;
        private List<int> _selectedEmployeeCriterias;

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedIndustryCriterias ??
                       CustomerCriterion.IndustryCriteria.Select(m => m.IndustryCriterionId).ToList();
            }
            set { _selectedIndustryCriterias = value; }
        }

        public List<int> SelectedEmployeeCriterias
        {
            get
            {
                return _selectedEmployeeCriterias ??
                       CustomerCriterion.EmployeeCriteria.Select(m => m.EmployeeCriterionId).ToList();
            }
            set { _selectedEmployeeCriterias = value; }
        }
    }
}