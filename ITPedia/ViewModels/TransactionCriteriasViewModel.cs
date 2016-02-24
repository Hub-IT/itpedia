using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class TransactionCriteriasViewModel
    {
        public virtual TransactionCriteria TransactionCriteria { get; set; }
        public virtual IEnumerable<SelectListItem> AllCustomerCriterias { get; set; }

        private List<int> _selectedCustomerCriterias = new List<int>();

        public virtual List<int> SelectedCustomerCriterias
        {
            get {
                return _selectedCustomerCriterias ??
                       (_selectedCustomerCriterias =
                           TransactionCriteria.CustomerCriterias.Select(m => m.CustomerCriteriaId).ToList());
            }
            set { _selectedCustomerCriterias = value; }
        }
    }
}