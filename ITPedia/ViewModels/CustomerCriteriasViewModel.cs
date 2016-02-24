using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class CustomerCriteriasViewModel
    {
        public CustomerCriteria CustomerCriteria { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }
        public IEnumerable<SelectListItem> AllEmployeeCriterias { get; set; }

        private List<int> _selectedIndustryCriterias;
        private List<int> _selectedEmployeeCriterias;

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedIndustryCriterias ??
                       CustomerCriteria.IndustryCriterias.Select(m => m.IndustryCriteriaId).ToList();
            }
            set { _selectedIndustryCriterias = value; }
        }

        public List<int> SelectedEmployeeCriterias
        {
            get
            {
                return _selectedEmployeeCriterias ??
                       CustomerCriteria.EmployeeCriterias.Select(m => m.EmployeeCriteriaId).ToList();
            }
            set { _selectedEmployeeCriterias = value; }
        }
    }
}