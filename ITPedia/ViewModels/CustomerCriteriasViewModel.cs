using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.ViewModels
{
    public class CustomerCriteriasViewModel
    {
        private List<int> _selectedTransactionCriterias;
        public CustomerCriteria CustomerCriteria { get; set; }
        public IEnumerable<SelectListItem> AllTransactionCriterias { get; set; }

        public List<int> SelectedTransactionCriterias
        {
            get
            {
                return _selectedTransactionCriterias ??
                       CustomerCriteria.TransactionCriterias.Select(m => m.TransactionCriteriaId).ToList();
            }
            set { _selectedTransactionCriterias = value; }
        }
    }
}