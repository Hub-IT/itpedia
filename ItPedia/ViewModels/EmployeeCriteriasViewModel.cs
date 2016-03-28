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
        public EmployeeCriterion EmployeeCriterion { get; set; }

        public IEnumerable<SelectListItem> AllIndustryCriterias { get; set; }

        public List<int> SelectedIndustryCriterias
        {
            get
            {
                return _selectedCustomerCriterias ??
                       EmployeeCriterion.IndustryCriteria.Select(m => m.IndustryCriterionId).ToList();
            }
            set { _selectedCustomerCriterias = value; }
        }
    }
}