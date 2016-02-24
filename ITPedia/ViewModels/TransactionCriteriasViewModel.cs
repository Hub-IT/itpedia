using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.ViewModels
{
    public class TransactionCriteriasViewModel
    {
        public TransactionCriteria TransactionCriteria { get; set; }
        public IEnumerable<SelectListItem> AllCustomerCriterias { get; set; }

        private List<int> _selectedCustomerCriterias;

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