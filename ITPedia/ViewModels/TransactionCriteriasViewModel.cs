using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class TransactionCriteriasViewModel
    {
        private List<int> _selectedCustomerCriterias;
        public TransactionCriteria TransactionCriteria { get; set; }
        public IEnumerable<SelectListItem> AllCustomerCriterias { get; set; }

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