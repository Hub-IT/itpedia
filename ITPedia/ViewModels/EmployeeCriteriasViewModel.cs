using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class EmployeeCriteriasViewModel
    {
        private List<int> _selectedCustomerCriterias;
        public EmployeeCriteria EmployeeCriteria { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedCustomerCriterias ??
                       EmployeeCriteria.IndustryCriterias.Select(m => m.IndustryCriteriaId).ToList();
            }
            set { _selectedCustomerCriterias = value; }
        }
    }
}